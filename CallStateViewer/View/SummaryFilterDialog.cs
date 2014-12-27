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
            Filter.FinalStateFilter = "";
            Filter.RecordNameFilter = "";
            Filter.RecordValueFilter = "";
            Filter.TimeInAfterFilter = DateTime.MinValue;
            Filter.TimeInBeforeFilter = DateTime.MinValue;
            Filter.FinalStateTimeAfterFilter = DateTime.MinValue;
            Filter.FinalStateTimeBeforeFilter = DateTime.MinValue;

            Filter.CallbackAttemptsMinFilter = -1;
            Filter.CallbackAttemptsMaxFilter = -1;

            this.okButton.Enabled = false;
            this.applyButton.Enabled = false;
        }

        public SummaryFilter Filter
        {
            get;
            private set;
        }

        public void SetValidTimeSpan( DateTime minTime, DateTime maxTime )
        {
            this.timeInAfterDateTimePicker.MinDate =
                this.timeInBeforeDateTimePicker.MinDate =
                this.finalStateTimeAfterDateTimePicker.MinDate =
                this.finalStateTimeBeforeDateTimePicker.MinDate = minTime;

            this.timeInAfterDateTimePicker.MaxDate =
                this.timeInBeforeDateTimePicker.MaxDate =
                this.finalStateTimeAfterDateTimePicker.MaxDate =
                this.finalStateTimeBeforeDateTimePicker.MaxDate = maxTime;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.okButton.Enabled = false;
            this.applyButton.Enabled = false;

            callIdFilterComboBox.Text = Filter.CallIdFilter;
            finalStateFilterComboBox.Text = Filter.FinalStateFilter;
            recordNameFilterComboBox.Text = Filter.RecordNameFilter;
            recordValueFilterComboBox.Text = Filter.RecordValueFilter;

            Filter.TimeInAfterFilter = timeInFilterAfterEnabledCheckBox.Checked ? timeInAfterDateTimePicker.Value : DateTime.MinValue;
            Filter.TimeInBeforeFilter = timeInFilterBeforeEnabledCheckBox.Checked ? timeInBeforeDateTimePicker.Value : DateTime.MinValue;
            Filter.TimeInEmptyFilter = timeInEmptyCheckBox.Checked;

            Filter.FinalStateTimeAfterFilter = finalStateTimeFilterAfterEnabledCheckBox.Checked ? finalStateTimeAfterDateTimePicker.Value : DateTime.MinValue;
            Filter.FinalStateTimeBeforeFilter = finalStateTimeFilterBeforeEnabledCheckBox.Checked ? finalStateTimeBeforeDateTimePicker.Value : DateTime.MinValue;
            Filter.FinalStateTimeEmptyFilter = finalStateTimeEmptyCheckBox.Checked;

            Filter.CallbackAttemptsMinFilter = (int)(callbackAttemptsMinEnabledCheckBox.Checked ? callbackAttemptsMinNumericUpDown.Value : -1);
            Filter.CallbackAttemptsMaxFilter = (int)(callbackAttemptsMaxEnabledCheckBox.Checked ? callbackAttemptsMaxNumericUpDown.Value : -1);

            callbackAttemptsMinEnabledCheckBox.Checked = (-1 < Filter.CallbackAttemptsMinFilter);
            callbackAttemptsMinNumericUpDown.Enabled = callbackAttemptsMinEnabledCheckBox.Checked;
            callbackAttemptsMinNumericUpDown.Value = Filter.CallbackAttemptsMinFilter;

            callbackAttemptsMaxEnabledCheckBox.Checked = (-1 < Filter.CallbackAttemptsMaxFilter);
            callbackAttemptsMaxNumericUpDown.Enabled = callbackAttemptsMaxEnabledCheckBox.Checked;
            callbackAttemptsMaxNumericUpDown.Value = Filter.CallbackAttemptsMaxFilter;

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
            finalStateFilterComboBox.Text = Filter.FinalStateFilter;
            recordNameFilterComboBox.Text = Filter.RecordNameFilter;
            recordValueFilterComboBox.Text = Filter.RecordValueFilter;

            timeInFilterAfterEnabledCheckBox.Checked = (Filter.TimeInAfterFilter != DateTime.MinValue);
            timeInAfterDateTimePicker.Enabled = timeInFilterAfterEnabledCheckBox.Checked;
            timeInAfterDateTimePicker.Value = (timeInFilterAfterEnabledCheckBox.Checked ? Filter.TimeInAfterFilter : timeInAfterDateTimePicker.MinDate);

            timeInFilterBeforeEnabledCheckBox.Checked = (Filter.TimeInBeforeFilter != DateTime.MinValue);
            timeInBeforeDateTimePicker.Enabled = timeInFilterBeforeEnabledCheckBox.Checked;
            timeInBeforeDateTimePicker.Value = (timeInFilterBeforeEnabledCheckBox.Checked ? Filter.TimeInBeforeFilter : timeInBeforeDateTimePicker.MaxDate);

            timeInEmptyCheckBox.Checked = Filter.TimeInEmptyFilter;

            finalStateTimeFilterAfterEnabledCheckBox.Checked = (Filter.FinalStateTimeAfterFilter != DateTime.MinValue);
            finalStateTimeAfterDateTimePicker.Enabled = finalStateTimeFilterAfterEnabledCheckBox.Checked;
            finalStateTimeAfterDateTimePicker.Value = (finalStateTimeFilterAfterEnabledCheckBox.Checked ? Filter.FinalStateTimeAfterFilter : finalStateTimeAfterDateTimePicker.MinDate);

            finalStateTimeFilterBeforeEnabledCheckBox.Checked = (Filter.FinalStateTimeBeforeFilter != DateTime.MinValue);
            finalStateTimeBeforeDateTimePicker.Enabled = finalStateTimeFilterBeforeEnabledCheckBox.Checked;
            finalStateTimeBeforeDateTimePicker.Value = (finalStateTimeFilterBeforeEnabledCheckBox.Checked ? Filter.FinalStateTimeBeforeFilter : finalStateTimeBeforeDateTimePicker.MaxDate);

            finalStateTimeEmptyCheckBox.Checked = Filter.FinalStateTimeEmptyFilter;

            callbackAttemptsMinEnabledCheckBox.Checked = (-1 < Filter.CallbackAttemptsMinFilter);
            callbackAttemptsMinNumericUpDown.Enabled = callbackAttemptsMinEnabledCheckBox.Checked;
            callbackAttemptsMinNumericUpDown.Value = Filter.CallbackAttemptsMinFilter;

            callbackAttemptsMaxEnabledCheckBox.Checked = (-1 < Filter.CallbackAttemptsMaxFilter);
            callbackAttemptsMaxNumericUpDown.Enabled = callbackAttemptsMaxEnabledCheckBox.Checked;
            callbackAttemptsMaxNumericUpDown.Value = Filter.CallbackAttemptsMaxFilter;

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

        private void filterCheckBox_Click(object sender, EventArgs e)
        {
            if ( sender == timeInFilterAfterEnabledCheckBox )
            {
                UpdateTimeFilterSensitivity(timeInFilterAfterEnabledCheckBox.Checked, timeInAfterDateTimePicker, Filter.TimeInAfterFilter, true );
            }
            else if ( sender == timeInFilterBeforeEnabledCheckBox )
            {
                UpdateTimeFilterSensitivity(timeInFilterBeforeEnabledCheckBox.Checked, timeInBeforeDateTimePicker, Filter.TimeInBeforeFilter, false );
            }
            else if ( sender == finalStateTimeFilterAfterEnabledCheckBox )
            {
                UpdateTimeFilterSensitivity(finalStateTimeFilterAfterEnabledCheckBox.Checked, finalStateTimeAfterDateTimePicker, Filter.FinalStateTimeAfterFilter, true );
            }
            else if ( sender == finalStateTimeFilterBeforeEnabledCheckBox )
            {
                UpdateTimeFilterSensitivity(finalStateTimeFilterBeforeEnabledCheckBox.Checked, finalStateTimeBeforeDateTimePicker, Filter.FinalStateTimeBeforeFilter, false);
            }
            else if ( sender == callbackAttemptsMinEnabledCheckBox )
            {
                UpdateCallbackAttemptsFilterSensitivity(callbackAttemptsMinEnabledCheckBox.Checked, callbackAttemptsMinNumericUpDown, Filter.CallbackAttemptsMinFilter);
            }
            else if ( sender == callbackAttemptsMaxEnabledCheckBox )
            {
                UpdateCallbackAttemptsFilterSensitivity(callbackAttemptsMaxEnabledCheckBox.Checked, callbackAttemptsMaxNumericUpDown, Filter.CallbackAttemptsMaxFilter);
            }
        }

        private void UpdateTimeFilterSensitivity(bool sensitivity, DateTimePicker dateTimePicker, DateTime currentFilterValue, bool afterFilter )
        {
            dateTimePicker.Enabled = sensitivity;

            if ( sensitivity )
            {
                if ( currentFilterValue != DateTime.MinValue )
                {
                    dateTimePicker.Value = currentFilterValue;
                }
                else if (afterFilter )
                {
                    dateTimePicker.Value = dateTimePicker.MinDate;
                }
                else
                {
                    dateTimePicker.Value = dateTimePicker.MaxDate;
                }
            }
            else if ( afterFilter )
            {
                dateTimePicker.Value = dateTimePicker.MinDate;
            }
            else
            {
                dateTimePicker.Value = dateTimePicker.MaxDate;
            }
        }

        private void UpdateCallbackAttemptsFilterSensitivity(bool sensitivity, NumericUpDown numericUpDown, int currentFilterValue )
        {
            numericUpDown.Enabled = sensitivity;
            numericUpDown.Value = sensitivity ? currentFilterValue : numericUpDown.Minimum;
        }
    }
}
