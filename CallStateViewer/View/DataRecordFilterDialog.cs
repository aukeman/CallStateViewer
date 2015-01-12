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
    public partial class DataRecordFilterDialog : Form
    {

        public EventHandler FilterUpdated;

        public DataRecordFilterDialog()
        {
            InitializeComponent();

            Filter = new DataRecordFilter();

            Filter.RecordName = "";
            Filter.RecordValue = "";

            Filter.TimeAfterActive = false;
            Filter.TimeAfter = DateTime.MinValue;
            Filter.TimeBeforeActive = false;
            Filter.TimeBefore = DateTime.MinValue;

            Filter.CaseSensitive = false;
            Filter.UseRegex = false;

            this.okButton.Enabled = false;
            this.applyButton.Enabled = false;
        }

        public DataRecordFilter Filter
        {
            get;
            private set;
        }

        public void SetTimeSpan( DateTime minTime, DateTime maxTime )
        {
            this.timestampAfterDateTimePicker.Value =
                Filter.TimeAfter =
                minTime;

            this.timestampBeforeDateTimePicker.Value =
                Filter.TimeBefore =
                maxTime;
        }

        private void okButton_Clicked(object sender, EventArgs e)
        {
            this.okButton.Enabled = false;
            this.applyButton.Enabled = false;

            if ( this.regexCheckBox.Checked &&
                !FilterHelper.CheckForFilterTextComboBoxErrors(this, new ComboBox[] {recordNameFilterComboBox, 
                                                                                     recordValueFilterComboBox}))
            {
                return;
            }

            Filter.RecordName = recordNameFilterComboBox.Text;
            Filter.RecordValue = recordValueFilterComboBox.Text;

            Filter.TimeAfterActive = timestampFilterAfterEnabledCheckBox.Checked;
            Filter.TimeBeforeActive = timestampFilterBeforeEnabledCheckBox.Checked;

            Filter.TimeAfter = timestampAfterDateTimePicker.Value;
            Filter.TimeBefore = timestampBeforeDateTimePicker.Value;

            Filter.UseRegex = regexCheckBox.Checked;
            Filter.CaseSensitive = caseSensitiveCheckBox.Checked;

            FilterHelper.UpdateDropDownWithFilterText(recordNameFilterComboBox);
            FilterHelper.UpdateDropDownWithFilterText(recordValueFilterComboBox);

            if (FilterUpdated != null)
            {
                FilterUpdated(this, EventArgs.Empty);
            }

            if ( sender == this.okButton )
            {
                this.Hide();
            }

        }

        private void cancelButton_Clicked(object sender, EventArgs e)
        {
            this.okButton.Enabled = false;
            this.applyButton.Enabled = false;

            recordNameFilterComboBox.Text = Filter.RecordName;
            recordValueFilterComboBox.Text = Filter.RecordValue;

            timestampFilterAfterEnabledCheckBox.Checked = Filter.TimeAfterActive;
            timestampFilterBeforeEnabledCheckBox.Checked = Filter.TimeBeforeActive;

            timestampAfterDateTimePicker.Value = Filter.TimeAfter;
            timestampBeforeDateTimePicker.Value = Filter.TimeBefore;

            this.Hide();
        }

        private void checkbox_Changed(object sender, EventArgs e)
        {
            if ( sender == timestampFilterAfterEnabledCheckBox )
            {
                FilterHelper.UpdateTimeFilterSensitivity(timestampFilterAfterEnabledCheckBox.Checked, timestampAfterDateTimePicker, Filter.TimeAfter);
            }
            else if ( sender == timestampFilterBeforeEnabledCheckBox )
            {
                FilterHelper.UpdateTimeFilterSensitivity(timestampFilterBeforeEnabledCheckBox.Checked, timestampBeforeDateTimePicker, Filter.TimeBefore);
            }
                        
            this.okButton.Enabled = true;
            this.applyButton.Enabled = true;
        }

        private void timeValue_Changed(object sender, EventArgs e)
        {
            this.okButton.Enabled = true;
            this.applyButton.Enabled = true;

        }

        private void comboBox_TextChanged(object sender, EventArgs e)
        {
            FilterHelper.ResetTextFilterComboBoxErrorState(sender as ComboBox);

            this.okButton.Enabled = true;
            this.applyButton.Enabled = true;
        }

        private void DataRecordFilterDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
