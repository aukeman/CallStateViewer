using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

using System.Threading;

using System.IO;

using CallStateViewer.Parser;
using CallStateViewer.Model;
using CallStateViewer.View;

namespace CallStateViewer
{
    public partial class Form1 : Form
    {

        private List<CallDataRecord> records = new List<CallDataRecord>();

        string[] loadedFiles = {};

        SummaryFilterDialog summaryFilterDialog = new SummaryFilterDialog();

        public Form1()
        {
            InitializeComponent();

            mCallIdDataGridView.AutoGenerateColumns = false;
            mDataGridView.AutoGenerateColumns = false;

            summaryFilterDialog.Hide();

            summaryFilterDialog.FilterUpdated += new EventHandler(delegate(object sender, EventArgs e)
            {
                DisplayCallSummaryTable();
            });
        }

        private bool busy = false;
        public bool Busy
        {
            get { return this.busy; }
            private set
            {
                this.busy = value;
                this.progressBar.Visible = value;
                this.UseWaitCursor = value;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var files = (from arg in Environment.GetCommandLineArgs()
                        select arg).Skip(1);
                        
            if ( 0 < files.Count() )
            {
                LoadFiles(files.ToArray());
            }
        }

        private void LoadFiles( string[] files )
        {
            if ( this.Busy )
            {
                return;
            }

            this.Busy = true;

            // ensure the logfiles are read in alphabetical order
            // we are assuming this correlates with the logfiles 
            // being in the correct time order
            loadedFiles = files.OrderBy(s => s).ToArray();

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;

            IEnumerable<CallSummary> callSummaryList = null;

            worker.DoWork += delegate(object sender, DoWorkEventArgs e)
            {
                MainReportParser.Reset();
                records.Clear();

                foreach (string logfile in loadedFiles)
                {
                    if (File.Exists(logfile))
                    {
                        worker.ReportProgress(0, logfile);
                        records.AddRange(MainReportParser.ParseFile(logfile));
                    } 
                    else if (Directory.Exists(logfile))
                    {
                        foreach (string containedLogFile in Directory.EnumerateFiles(logfile, "MainReportLog_*.txt", SearchOption.AllDirectories))
                        {
                            worker.ReportProgress(0, containedLogFile);
                            records.AddRange(MainReportParser.ParseFile(containedLogFile));
                        }
                    }
                }

                if (0 < records.Count())
                {
                    var minimumFilterTime = records.Min(record => record.Timestamp);
                    var maximumFilterTime = records.Max(record => record.Timestamp);

                    summaryFilterDialog.SetValidTimeSpan(minimumFilterTime, maximumFilterTime);

                    callSummaryList = BuildCallSummaryTable();
                }
            };

            worker.ProgressChanged += delegate(object sender, ProgressChangedEventArgs e)
            {
                statusLabel.Text = String.Format("Loading {0}...", e.UserState);
            };

            worker.RunWorkerCompleted += delegate(object sender, RunWorkerCompletedEventArgs e)
            {
                this.Busy = false;
                DisplayCallSummaryTable();
            };

            worker.RunWorkerAsync();
        }

        private void DisplayCallSummaryTable()
        {

            if ( this.Busy )
            {
                return;
            }

            this.Busy = true;

            statusLabel.Text = "Building Call Summary Table...";

            var callIdsBindingSource = new BindingSource();
            string statusLabelText = "";


            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += delegate(object sender, DoWorkEventArgs e)
            {
                var callSummaryList = BuildCallSummaryTable();

                if (0 < callSummaryList.Count())
                {
                    callIdsBindingSource.DataSource = callSummaryList;

                    int numberOfCallsLoaded = callSummaryList.Count();
                    var earliestTimestamp = callSummaryList.Min(summary => summary.EarliestRecordTimestamp);
                    var latestTimestamp = callSummaryList.Max(summary => summary.LatestRecordTimestamp); 

                    statusLabelText = String.Format("{0} Calls Loaded   {1} - {2}", numberOfCallsLoaded, earliestTimestamp, latestTimestamp);
                }
                else
                {
                    statusLabelText = "No Calls Loaded";
                }
            };

            worker.RunWorkerCompleted += delegate(object sender, RunWorkerCompletedEventArgs e)
            {
                mCallIdDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                mCallIdDataGridView.DataSource = callIdsBindingSource;

                mCallIdDataGridView.Width = mCallIdDataGridView.PreferredSize.Width;
                mCallIdDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                statusLabel.Text = statusLabelText;

                this.Busy = false;
            };

            worker.RunWorkerAsync();
        }

        private IEnumerable<CallSummary> BuildCallSummaryTable()
        {
            var callSummary = from record in records
                              group record by record.CallId into g
                              let newCall = g.FirstOrDefault(c => c.Name == "New Call")
                              let finalState = g.FirstOrDefault(c => c.Name == "Final State")
                              let callbackAttempts = g.Where(c => c.Name == "Callback Attempts").Distinct().Count()
                              let earliestRecordTimestamp = g.Min(c => c.Timestamp)
                              let latestRecordTimestamp = g.Max(c => c.Timestamp)
                              select new CallSummary()
                              {
                                  CallId = g.Key,
                                  TimeIn = (newCall != null ? newCall.Timestamp : DateTime.MinValue),
                                  FinalStateTime = (finalState != null ? finalState.Timestamp : DateTime.MinValue),
                                  FinalState = (finalState != null ? finalState.Value : ""),
                                  CallbackAttempts = (callbackAttempts == 0 ? "" : callbackAttempts.ToString()),
                                  EarliestRecordTimestamp = earliestRecordTimestamp,
                                  LatestRecordTimestamp = latestRecordTimestamp
                              };

            return callSummary.Where(c => summaryFilterDialog.Filter.Passes(c));
        }

        private void mDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            string propertyName = dataGridView.Columns[e.ColumnIndex].DataPropertyName;

            if ( propertyName.Equals("Timestamp") ||
                 propertyName.Equals("TimeIn") ||
                 propertyName.Equals("FinalStateTime") )
            {
                if (e.Value == null ||
                    ((DateTime)e.Value) == DateTime.MinValue)
                {
                    e.Value = "";
                }
                else
                {
                    e.Value = ((DateTime)e.Value).ToString("MM/dd HH:mm:ss.fff");
                }
            }
        }

        private void mCallIdDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if ( 0 < mCallIdDataGridView.SelectedRows.Count )
            {
                var callIds = from DataGridViewRow row in mCallIdDataGridView.SelectedRows
                              select row.Cells[0].Value.ToString();

                var callEvents = (from record in records
                                  where callIds.Contains(record.CallId)
                                  select record).Distinct();

                var callEventsBindingSource = new BindingSource();
                callEventsBindingSource.DataSource = callEvents;
                mDataGridView.DataSource = callEventsBindingSource;

                mDataGridView.Columns[0].Visible = (1 < mCallIdDataGridView.SelectedRows.Count);

                for ( int row_idx = 0; row_idx < mDataGridView.RowCount-1; ++row_idx)
                {
                    CallDataRecord thisRow = mDataGridView.Rows[row_idx].DataBoundItem as CallDataRecord;
                    CallDataRecord nextRow = mDataGridView.Rows[row_idx+1].DataBoundItem as CallDataRecord;

                    if ( thisRow.CallId != nextRow.CallId )
                    {
                        mDataGridView.Rows[row_idx].DividerHeight = 3;
                    }
                }

            }
            else
            {
                mDataGridView.Columns[0].Visible = false;
                mDataGridView.DataSource = null;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (!this.Busy && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                LoadFiles(e.Data.GetData(DataFormats.FileDrop) as string[]);
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if ( !this.Busy && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            Point p = new Point(MousePosition.X, MousePosition.Y);

            Point callIdCoord = mCallIdDataGridView.PointToClient(p);
            Point logRecordCoord = mDataGridView.PointToClient(p);

            DataGridView.HitTestInfo callIdHitTestInfo = mCallIdDataGridView.HitTest(callIdCoord.X, callIdCoord.Y);
            DataGridView.HitTestInfo logRecordHitTestInfo = mDataGridView.HitTest(logRecordCoord.X, logRecordCoord.Y);

            e.Cancel = false;

            if ( DataGridViewHitTestType.Cell == callIdHitTestInfo.Type )
            {
                BuildCallIdTableContextMenu(callIdHitTestInfo.RowIndex);
            }
            else if ( DataGridViewHitTestType.Cell == logRecordHitTestInfo.Type )
            {
                BuildLogRecordTableContextMenu(logRecordHitTestInfo.RowIndex);
            }
            else
            {
                e.Cancel = true;
            }
        }

        void BuildCallIdTableContextMenu(int rowIndex)
        {
            contextMenuStrip.Items.Clear();

            var callId = mCallIdDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            var copyClickedCallId = BuildCopyCallIdMenuItem(callId);

            var numberOfSelectedRows = mCallIdDataGridView.SelectedRows.Count;

            var label =
                    String.Format("Copy &selected Call ID{0} to Clipboard", (1 < numberOfSelectedRows ? "s" : ""));

            var copySelectedCallIds = new ToolStripMenuItem(label, null, new EventHandler(delegate(object sender2, EventArgs e2)
            {
                // if the call IDs are taken from the selected rows collection, they are in the 
                // order they were selected.
                // This way they are in the order they appear on screen
                var selectedCallIds = from callIdRow in mCallIdDataGridView.Rows.Cast<DataGridViewRow>()
                                        where callIdRow.Selected
                                        select callIdRow.Cells[0].Value.ToString();

                Clipboard.SetText(String.Join(Environment.NewLine, selectedCallIds));
            }));

            copySelectedCallIds.Enabled = (0 < numberOfSelectedRows);

            var reload = BuildReloadMenuItem();

            var summaryFilter = new ToolStripMenuItem("&Filter Call Summary", null, new EventHandler(delegate(object sender, EventArgs e)
            {
                this.summaryFilterDialog.Show();
            }));

            contextMenuStrip.Items.Add(copyClickedCallId);
            contextMenuStrip.Items.Add(copySelectedCallIds);
            contextMenuStrip.Items.Add(new ToolStripSeparator());
            contextMenuStrip.Items.Add(reload);
            contextMenuStrip.Items.Add(new ToolStripSeparator());
            contextMenuStrip.Items.Add(summaryFilter);

        }

        void BuildLogRecordTableContextMenu(int rowIndex)
        {
            contextMenuStrip.Items.Clear();

            var callId = (mDataGridView.Rows[rowIndex].DataBoundItem as CallDataRecord).CallId;
            var copyClickedCallId = BuildCopyCallIdMenuItem(callId);

            var numberOfSelectedRows = mDataGridView.SelectedRows.Count;

            var label =
                String.Format("Copy &selected Log Record{0} to Clipboard", (1 < numberOfSelectedRows ? "s" : ""));

            var copySelectedLogRecords = new ToolStripMenuItem(label, null, new EventHandler(delegate(object sender, EventArgs e)
            {
                // if the call IDs are taken from the selected rows collection, they are in the 
                // order they were selected.
                // This way they are in the order they appear on screen
                var selectedLogRecords = from logRow in mDataGridView.Rows.Cast<DataGridViewRow>()
                                            where logRow.Selected
                                            select MainReportParser.LogStringFromCallDataRecord( logRow.DataBoundItem as CallDataRecord );

                Clipboard.SetText(String.Join(Environment.NewLine, selectedLogRecords));
            }));
            copySelectedLogRecords.Enabled = (0 < numberOfSelectedRows);


            var copyAllLogRecords = new ToolStripMenuItem("Copy &all Log Records to Clipboard", null, new EventHandler(delegate(object sender, EventArgs e)
            {
                var allLogRecords = from logRow in mDataGridView.Rows.Cast<DataGridViewRow>()
                                    select MainReportParser.LogStringFromCallDataRecord(logRow.DataBoundItem as CallDataRecord);

                Clipboard.SetText(String.Join(Environment.NewLine, allLogRecords));
            }));

            var reload = BuildReloadMenuItem();

            contextMenuStrip.Items.Add(copyClickedCallId);
            contextMenuStrip.Items.Add(copySelectedLogRecords);
            contextMenuStrip.Items.Add(copyAllLogRecords);
            contextMenuStrip.Items.Add((new ToolStripSeparator()));
            contextMenuStrip.Items.Add(reload);
        }

        ToolStripMenuItem BuildCopyCallIdMenuItem(string callId)
        {
            return new ToolStripMenuItem(String.Format("&Copy \"{0}\" to Clipboard", callId), null, new EventHandler(delegate(object sender, EventArgs e)
            {
                Clipboard.SetText(callId);
            }));
        }

        ToolStripMenuItem BuildReloadMenuItem()
        {
            var result = new ToolStripMenuItem("&Reload", null, new EventHandler(delegate(object sender, EventArgs e)
            {
                LoadFiles(this.loadedFiles);
            }));

            result.Enabled = !this.Busy;

            return result;
        }
    }
}
