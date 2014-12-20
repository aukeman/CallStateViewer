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

using CallStateViewer.Parser;
using CallStateViewer.Model;

namespace CallStateViewer
{
    public partial class Form1 : Form
    {

        private List<CallDataRecord> records = new List<CallDataRecord>();

        bool loadingFiles = false;

        public Form1()
        {
            InitializeComponent();

            mCallIdDataGridView.AutoGenerateColumns = false;
            mDataGridView.AutoGenerateColumns = false;
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
            if ( loadingFiles )
            {
                return;
            }

            loadingFiles = true;

            var callIdsBindingSource = new BindingSource();
            int numberOfCallsLoaded = 0;

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;

            progressBar.Visible = true;

            this.Cursor = Cursors.WaitCursor;

            worker.DoWork += delegate(object sender, DoWorkEventArgs e)
            {
                MainReportParser.Reset();
                records.Clear();

                foreach (string logfile in files)
                {
                    worker.ReportProgress(0, logfile);

                    records.AddRange(MainReportParser.Parse(logfile));
                }

                if (0 < records.Count())
                {
                    var callIds = from record in records
                                  group record by record.CallId into g
                                  let newCall = g.SingleOrDefault(c => c.Name == "New Call")
                                  let finalState = g.SingleOrDefault(c => c.Name == "Final State")
                                  select new
                                  {
                                      CallId = g.Key,
                                      TimeIn = (newCall != null ? newCall.Timestamp : DateTime.MinValue),
                                      FinalFateTime = (finalState != null ? finalState.Timestamp : DateTime.MinValue),
                                      FinalFate = (finalState != null ? finalState.Value : "")
                                  };

                    callIdsBindingSource.DataSource = callIds;
                    numberOfCallsLoaded = callIds.Count();
                }
            };

            worker.ProgressChanged += delegate(object sender, ProgressChangedEventArgs e)
            {
                statusLabel.Text = String.Format("Loading {0}...", e.UserState);
            };

            worker.RunWorkerCompleted += delegate(object sender, RunWorkerCompletedEventArgs e)
            {
                var earliestTimestamp = records.Min(record => record.Timestamp);
                var latestTimestamp = records.Max(record => record.Timestamp);


                mCallIdDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                mCallIdDataGridView.DataSource = callIdsBindingSource;

                mCallIdDataGridView.Width = mCallIdDataGridView.PreferredSize.Width;
                mCallIdDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                statusLabel.Text = String.Format("{0} Calls Loaded   {1} - {2}", numberOfCallsLoaded, earliestTimestamp, latestTimestamp);
                
                loadingFiles = false;
                progressBar.Visible = false;
                this.Cursor = Cursors.Default;
            };

            worker.RunWorkerAsync();
        }

        private void mDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            string propertyName = dataGridView.Columns[e.ColumnIndex].DataPropertyName;

            if ( propertyName.Equals("Timestamp") ||
                 propertyName.Equals("TimeIn") ||
                 propertyName.Equals("FinalFateTime") )
            {
                if (e.Value == null ||
                    ((DateTime)e.Value) == DateTime.MinValue)
                {
                    e.Value = "";
                }
                else
                {
                    e.Value = ((DateTime)e.Value).ToString("HH:mm:ss.fff");
                }
            }
        }

        private void mCallIdDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if ( 0 < mCallIdDataGridView.SelectedRows.Count )
            {
                var callIds = from DataGridViewRow row in mCallIdDataGridView.SelectedRows
                              select row.Cells[0].Value.ToString();

                var callEvents = from record in records
                                 where callIds.Contains(record.CallId)
                                 select record;

                var callEventsBindingSource = new BindingSource();
                callEventsBindingSource.DataSource = callEvents;
                mDataGridView.DataSource = callEventsBindingSource;

                mDataGridView.Columns[0].Visible = (1 < mCallIdDataGridView.SelectedRows.Count);

            }
            else
            {
                mDataGridView.Columns[0].Visible = false;
                mDataGridView.DataSource = null;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (!loadingFiles && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                LoadFiles(e.Data.GetData(DataFormats.FileDrop) as string[]);
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if ( !loadingFiles && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            Point p = new Point(MousePosition.X, MousePosition.Y);

            Point callIdCoord = mCallIdDataGridView.PointToClient(p);
            Point logRecordCoord = mDataGridView.PointToClient(p);

            DataGridView.HitTestInfo callIdHitTestInfo = mCallIdDataGridView.HitTest(callIdCoord.X, callIdCoord.Y);
            DataGridView.HitTestInfo logRecordHitTestInfo = mDataGridView.HitTest(logRecordCoord.X, logRecordCoord.Y);

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
            contextMenuStrip.Items.Add(BuildCopyCallIdMenuItem(callId));

            var numberOfSelectedRows = mCallIdDataGridView.SelectedRows.Count;
            if (0 < numberOfSelectedRows)
            {
                var label =
                    String.Format("Copy selected Call ID{0} to Clipboard", (1 < numberOfSelectedRows ? "s" : ""));

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

                contextMenuStrip.Items.Add(copySelectedCallIds);
            }
        }

        void BuildLogRecordTableContextMenu(int rowIndex)
        {
            contextMenuStrip.Items.Clear();

            var callId = (mDataGridView.Rows[rowIndex].DataBoundItem as CallDataRecord).CallId;
            contextMenuStrip.Items.Add(BuildCopyCallIdMenuItem(callId));

            var numberOfSelectedRows = mDataGridView.SelectedRows.Count;
            if (0 < numberOfSelectedRows)
            {
                var label =
                    String.Format("Copy selected Log Record{0} to Clipboard", (1 < numberOfSelectedRows ? "s" : ""));

                var copySelectedLogRecords = new ToolStripMenuItem(label, null, new EventHandler(delegate(object sender, EventArgs e)
                {
                    // if the call IDs are taken from the selected rows collection, they are in the 
                    // order they were selected.
                    // This way they are in the order they appear on screen
                    var selectedLogRecords = from logRow in mDataGridView.Rows.Cast<DataGridViewRow>()
                                             where logRow.Selected
                                             select logRow.DataBoundItem.ToString();

                    Clipboard.SetText(String.Join(Environment.NewLine, selectedLogRecords));
                }));

                contextMenuStrip.Items.Add(copySelectedLogRecords);
            }
        }

        ToolStripMenuItem BuildCopyCallIdMenuItem(string callId)
        {
            return new ToolStripMenuItem(String.Format("Copy \"{0}\" to Clipboard", callId), null, new EventHandler(delegate(object sender, EventArgs e)
            {
                Clipboard.SetText(callId);
            }));
        }
    }
}
