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

using CallStateViewer.Parser;
using CallStateViewer.Model;

namespace CallStateViewer
{
    public partial class Form1 : Form
    {

        private List<CallDataRecord> records = new List<CallDataRecord>();

        public Form1()
        {
            InitializeComponent();

            mCallIdDataGridView.AutoGenerateColumns = false;
            mDataGridView.AutoGenerateColumns = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if ( 0 < Environment.GetCommandLineArgs().Length )
            {
                LoadFiles(Environment.GetCommandLineArgs());
            }
        }

        private void LoadFiles( string[] files )
        {
            records.Clear();

            foreach ( string logfile in files )
            {
                if (Regex.Match(logfile, @"MainReportLog_\d{5}\.txt$").Success )
                {
                    records.AddRange(MainReportParser.Parse(logfile));
                }
            }

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


            var earliestTimestamp = records.Min(record => record.Timestamp);
            var latestTimestamp = records.Max(record => record.Timestamp);

            var callIdsBindingSource = new BindingSource();
            callIdsBindingSource.DataSource = callIds;

            mCallIdDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            
            mCallIdDataGridView.DataSource = callIdsBindingSource;

            mCallIdDataGridView.Width = mCallIdDataGridView.PreferredSize.Width;
            mCallIdDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            numberOfCallsLoadedStatusLabel.Text = String.Format("{0} Calls Loaded", callIds.Count());
            timespanOfLoadedCallsStatusLabel.Text = String.Format("Timespan: {0} - {1}", earliestTimestamp, latestTimestamp);
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
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                LoadFiles(e.Data.GetData(DataFormats.FileDrop) as string[]);
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
    }
}
