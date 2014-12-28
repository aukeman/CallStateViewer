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

            Filter.CallId = "";
            Filter.FinalState = "";
            Filter.RecordName = "";
            Filter.RecordValue = "";

            Filter.TimeInAfterActive = false;
            Filter.TimeInAfter = DateTime.MinValue;
            Filter.TimeInBeforeActive = false;
            Filter.TimeInBefore = DateTime.MinValue;
            
            Filter.FinalStateTimeAfterActive = false;
            Filter.FinalStateTimeAfter = DateTime.MinValue;
            Filter.FinalStateTimeBeforeActive = false;
            Filter.FinalStateTimeBefore = DateTime.MinValue;

            Filter.CallbackAttemptsMinActive = false;
            Filter.CallbackAttemptsMin = 0;

            Filter.CallbackAttemptsMaxActive = false;
            Filter.CallbackAttemptsMax = 0;

            this.okButton.Enabled = false;
            this.applyButton.Enabled = false;
        }

        public SummaryFilter Filter
        {
            get;
            private set;
        }

        public void SetTimeSpan( DateTime minTime, DateTime maxTime )
        {
            this.timeInAfterDateTimePicker.Value =
                this.finalStateTimeAfterDateTimePicker.Value =
                Filter.TimeInAfter =
                Filter.FinalStateTimeAfter =
                minTime;

            this.timeInBeforeDateTimePicker.Value =
                this.finalStateTimeBeforeDateTimePicker.Value =
                Filter.TimeInBefore =
                Filter.FinalStateTimeBefore =
                maxTime;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.okButton.Enabled = false;
            this.applyButton.Enabled = false;

            callIdFilterComboBox.Text = Filter.CallId;
            finalStateFilterComboBox.Text = Filter.FinalState;
            recordNameFilterComboBox.Text = Filter.RecordName;
            recordValueFilterComboBox.Text = Filter.RecordValue;

            Filter.TimeInAfterActive = timeInFilterAfterEnabledCheckBox.Checked;
            Filter.TimeInAfter = timeInAfterDateTimePicker.Value;
            Filter.TimeInBeforeActive = timeInFilterBeforeEnabledCheckBox.Checked;
            Filter.TimeInBefore = timeInBeforeDateTimePicker.Value;
            Filter.TimeInEmpty = timeInEmptyCheckBox.Checked;

            Filter.FinalStateTimeAfterActive = finalStateTimeFilterAfterEnabledCheckBox.Checked;
            Filter.FinalStateTimeAfter = finalStateTimeAfterDateTimePicker.Value;
            Filter.FinalStateTimeBeforeActive = finalStateTimeFilterBeforeEnabledCheckBox.Checked;
            Filter.FinalStateTimeBefore = finalStateTimeBeforeDateTimePicker.Value;
            Filter.FinalStateTimeEmpty = finalStateTimeEmptyCheckBox.Checked;

            Filter.CallbackAttemptsMinActive = callbackAttemptsMinEnabledCheckBox.Checked;
            Filter.CallbackAttemptsMin = (int)callbackAttemptsMinNumericUpDown.Value;

            Filter.CallbackAttemptsMaxActive = callbackAttemptsMaxEnabledCheckBox.Checked;
            Filter.CallbackAttemptsMax = (int)callbackAttemptsMaxNumericUpDown.Value;

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

            callIdFilterComboBox.Text = Filter.CallId;
            finalStateFilterComboBox.Text = Filter.FinalState;
            recordNameFilterComboBox.Text = Filter.RecordName;
            recordValueFilterComboBox.Text = Filter.RecordValue;

            timeInFilterAfterEnabledCheckBox.Checked = timeInAfterDateTimePicker.Enabled = Filter.TimeInAfterActive;
            timeInAfterDateTimePicker.Value = Filter.TimeInAfter;

            timeInFilterBeforeEnabledCheckBox.Checked = timeInBeforeDateTimePicker.Enabled = Filter.TimeInBeforeActive;
            timeInBeforeDateTimePicker.Value = Filter.TimeInBefore;

            timeInEmptyCheckBox.Checked = Filter.TimeInEmpty;

            finalStateTimeFilterAfterEnabledCheckBox.Checked = timeInAfterDateTimePicker.Enabled = Filter.TimeInAfterActive;
            finalStateTimeAfterDateTimePicker.Value = Filter.TimeInAfter;

            finalStateTimeFilterBeforeEnabledCheckBox.Checked = timeInBeforeDateTimePicker.Enabled = Filter.TimeInBeforeActive;
            finalStateTimeBeforeDateTimePicker.Value = Filter.TimeInBefore;

            finalStateTimeEmptyCheckBox.Checked = Filter.FinalStateTimeEmpty;

            callbackAttemptsMinEnabledCheckBox.Checked = callbackAttemptsMinNumericUpDown.Enabled = Filter.CallbackAttemptsMinActive;
            callbackAttemptsMinNumericUpDown.Value = Filter.CallbackAttemptsMin;

            callbackAttemptsMaxEnabledCheckBox.Checked = callbackAttemptsMaxNumericUpDown.Enabled = Filter.CallbackAttemptsMaxActive;
            callbackAttemptsMaxNumericUpDown.Value = Filter.CallbackAttemptsMax;

            this.Hide();
        }

        private void filterComboBox_TextChanged(object sender, EventArgs e)
        {
            this.okButton.Enabled = true;
            this.applyButton.Enabled = true;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.okButton.Enabled = true;
            this.applyButton.Enabled = true;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.okButton.Enabled = true;
            this.applyButton.Enabled = true;
        }

        private void SummaryFilter_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void filterCheckBox_Click(object sender, EventArgs e)
        {
            if ( sender == timeInFilterAfterEnabledCheckBox )
            {
                UpdateTimeFilterSensitivity(timeInFilterAfterEnabledCheckBox.Checked, timeInAfterDateTimePicker, Filter.TimeInAfter);
            }
            else if ( sender == timeInFilterBeforeEnabledCheckBox )
            {
                UpdateTimeFilterSensitivity(timeInFilterBeforeEnabledCheckBox.Checked, timeInBeforeDateTimePicker, Filter.TimeInBefore);
            }
            else if ( sender == timeInEmptyCheckBox )
            {
                Filter.TimeInEmpty = timeInEmptyCheckBox.Checked;
            }
            else if ( sender == finalStateTimeFilterAfterEnabledCheckBox )
            {
                UpdateTimeFilterSensitivity(finalStateTimeFilterAfterEnabledCheckBox.Checked, finalStateTimeAfterDateTimePicker, Filter.FinalStateTimeAfter);
            }
            else if ( sender == finalStateTimeFilterBeforeEnabledCheckBox )
            {
                UpdateTimeFilterSensitivity(finalStateTimeFilterBeforeEnabledCheckBox.Checked, finalStateTimeBeforeDateTimePicker, Filter.FinalStateTimeBefore);
            }
            else if (sender == finalStateTimeEmptyCheckBox )
            {
                Filter.FinalStateTimeEmpty = finalStateTimeEmptyCheckBox.Checked;
            }
            else if ( sender == callbackAttemptsMinEnabledCheckBox )
            {
                UpdateCallbackAttemptsFilterSensitivity(callbackAttemptsMinEnabledCheckBox.Checked, callbackAttemptsMinNumericUpDown, Filter.CallbackAttemptsMin);
            }
            else if ( sender == callbackAttemptsMaxEnabledCheckBox )
            {
                UpdateCallbackAttemptsFilterSensitivity(callbackAttemptsMaxEnabledCheckBox.Checked, callbackAttemptsMaxNumericUpDown, Filter.CallbackAttemptsMax);
            }

            this.okButton.Enabled = true;
            this.applyButton.Enabled = true;
        }

        private void UpdateTimeFilterSensitivity(bool sensitivity, DateTimePicker dateTimePicker, DateTime currentFilterValue)
        {
            dateTimePicker.Enabled = sensitivity;

            if (sensitivity)
            {
                dateTimePicker.Value = currentFilterValue;
            }
        }

        private void UpdateCallbackAttemptsFilterSensitivity(bool sensitivity, NumericUpDown numericUpDown, int currentFilterValue )
        {
            numericUpDown.Enabled = sensitivity;

            if (sensitivity)
            {
                numericUpDown.Value = currentFilterValue;
            }
        }

    }
}
