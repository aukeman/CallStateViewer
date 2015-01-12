using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using CallStateViewer.Model;



namespace CallStateViewer.View
{
    public abstract class FilterHelper
    {
        public static bool PassesStringFilter(string needle, string haystack, bool caseSensitive, bool useRegex)
        {
            if (needle == "")
            {
                return true;
            }
            else if (useRegex)
            {
                return (Regex.Match(haystack, needle, caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase).Success);
            }
            else if (caseSensitive)
            {
                return haystack.Contains(needle);
            }
            else
            {
                return haystack.ToLower().Contains(needle.ToLower());
            }
        }

        public static bool PassesTimeFilter(DateTime timeToCheck, bool timeAfterFilterActive, DateTime timeAfterFilter, bool timeBeforeFilterActive, DateTime timeBeforeFilter, bool timeEmptyFilter)
        {
            bool result = ((!timeAfterFilterActive || timeAfterFilter < timeToCheck) &&
               (!timeBeforeFilterActive || timeToCheck != DateTime.MinValue && timeToCheck < timeBeforeFilter));

            if (!timeAfterFilterActive && !timeBeforeFilterActive && timeEmptyFilter)
            {
                result = (timeToCheck == DateTime.MinValue);
            }
            else if (timeEmptyFilter)
            {
                result = (result || timeToCheck == DateTime.MinValue);
            }

            return result;
        }

        public static bool PassesMinMaxNumberFilter(bool minActive, int min, bool maxActive, int max, string numberStr)
        {
            int number = 0;
            Int32.TryParse(numberStr, out number);

            return ((!minActive || min <= number) &&
                    (!maxActive || number <= max));
        }

        public static bool PassesRecordFilter(string recordNamePattern, string recordValuePattern, bool caseSensitive, bool useRegex, IEnumerable<CallDataRecord> records)
        {
            return (from record in records
                    where PassesRecordFilter(recordNamePattern, recordValuePattern, caseSensitive, useRegex, record)
                    select record).Any();
        }

        public static bool PassesRecordFilter(string recordNamePattern, string recordValuePattern, bool caseSensitive, bool useRegex, CallDataRecord record)
        {
            return (PassesStringFilter(recordNamePattern, record.Name, caseSensitive, useRegex) &&
                    PassesStringFilter(recordValuePattern, record.Value, caseSensitive, useRegex));
        }

        public static bool CheckForValidFilterRegex(string filterText)
        {
            bool result = true;

            try
            {
                if (filterText != "")
                {
                    new Regex(filterText);
                }
            }
            catch (Exception e)
            {
                result = false;
            }

            return result;
        }

        public static void ResetTextFilterComboBoxErrorState(ComboBox cb) 
        {
            if (cb != null)
            {
                cb.BackColor = SystemColors.Window;
            }
        }

        public static bool CheckForFilterTextComboBoxErrors(IWin32Window owner, ComboBox[] comboBoxes)
        {
            bool result = true;

            foreach ( ComboBox comboBox in comboBoxes )
            {
                if ( !CheckForValidFilterRegex(comboBox.Text) )
                {
                    result = false;
                    comboBox.BackColor = Color.LightPink;
                }
            }

            if ( !result )
            {
                MessageBox.Show(owner, "Invalid regular expression Detected.  Correct and submit again.", "Invalid Regular Expression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        public static void UpdateTimeFilterSensitivity(bool sensitivity, DateTimePicker dateTimePicker, DateTime currentFilterValue)
        {
            dateTimePicker.Enabled = sensitivity;

            if (sensitivity)
            {
                dateTimePicker.Value = currentFilterValue;
            }
        }

        public static void UpdateDropDownWithFilterText(ComboBox comboBox)
        {
            if (comboBox.Text != "" && !comboBox.Items.Contains(comboBox.Text))
            {
                comboBox.Items.Add(comboBox.Text);
            }
        }
    }
}
