using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallStateViewer.View
{
    public partial class SummaryFilterDialog : Form
    {

        public EventHandler FilterUpdated;

        public SummaryFilterDialog()
        {
            InitializeComponent();

            Filter = new SummaryFilter();

            Filter.CallIdFilter = "";
            Filter.TimeInFilter = "";
            Filter.FinalStateTimeFilter = "";
            Filter.FinalStateFilter = "";
            Filter.CallbackAttemptsFilter = "";
            Filter.RecordNameFilter = "";
            Filter.RecordValueFilter = "";

            this.okButton.Enabled = false;
            this.applyButton.Enabled = false;
        }

        public SummaryFilter Filter
        {
            get;
            private set;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.okButton.Enabled = false;
            this.applyButton.Enabled = false;

            Filter.CallIdFilter = callIdFilterComboBox.Text;
            Filter.TimeInFilter = timeInFilterComboBox.Text;
            Filter.FinalStateTimeFilter = finalStateTimeFilterComboBox.Text;
            Filter.FinalStateFilter = finalStateFilterComboBox.Text;
            Filter.CallbackAttemptsFilter = callbackAttemptsFilterComboBox.Text;
            Filter.RecordNameFilter = recordNameFilterComboBox.Text;
            Filter.RecordValueFilter = recordValueFilterComboBox.Text;

            if (FilterUpdated != null)
            {
                FilterUpdated(this, EventArgs.Empty);
            }

            if ( sender == this.okButton )
            {
                this.Hide();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.okButton.Enabled = false;
            this.applyButton.Enabled = false;

            callIdFilterComboBox.Text = Filter.CallIdFilter;
            timeInFilterComboBox.Text = Filter.TimeInFilter;
            finalStateTimeFilterComboBox.Text = Filter.FinalStateTimeFilter;
            finalStateFilterComboBox.Text = Filter.FinalStateFilter;
            callbackAttemptsFilterComboBox.Text = Filter.CallbackAttemptsFilter;
            recordNameFilterComboBox.Text = Filter.RecordNameFilter;
            recordValueFilterComboBox.Text = Filter.RecordValueFilter;

            this.Hide();
        }

        private void filterComboBox_TextChanged(object sender, EventArgs e)
        {
            this.okButton.Enabled = true;
            this.applyButton.Enabled = true;
        }

        private void SummaryFilter_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
