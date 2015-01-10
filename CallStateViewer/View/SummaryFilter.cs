﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CallStateViewer.Model;

using System.Text.RegularExpressions;

namespace CallStateViewer.View
{
    public class SummaryFilter
    {
        public bool Passes(CallSummary callSummary)
        {
            return (StringFilter(CallId, callSummary.CallId) &&
                    StringFilter(FinalState, callSummary.FinalState) &&
                    RecordFilter(RecordName, RecordValue, callSummary.Records) &&
                    TimeFilter(callSummary.TimeIn, TimeInAfterActive, TimeInAfter, TimeInBeforeActive, TimeInBefore, TimeInEmpty) &&
                    TimeFilter(callSummary.FinalStateTime, FinalStateTimeAfterActive, FinalStateTimeAfter, FinalStateTimeBeforeActive, FinalStateTimeBefore, FinalStateTimeEmpty) &&
                    CallbackAttemptsFilter(CallbackAttemptsMinActive, CallbackAttemptsMin, CallbackAttemptsMaxActive, CallbackAttemptsMax, callSummary.CallbackAttempts));
        }

        public string CallId
        {
            get;
            set;
        }

        public bool TimeInAfterActive
        {
            get;
            set;
        }

        public DateTime TimeInAfter
        {
            get;
            set;
        }

        public bool TimeInBeforeActive
        {
            get;
            set;
        }

        public DateTime TimeInBefore
        {
            get;
            set;
        }

        public bool TimeInEmpty
        {
            get;
            set;
        }

        public bool FinalStateTimeAfterActive
        {
            get;
            set;
        }

        public DateTime FinalStateTimeAfter
        {
            get;
            set;
        }

        public bool FinalStateTimeBeforeActive
        {
            get;
            set;
        }

        public DateTime FinalStateTimeBefore
        {
            get;
            set;
        }

        public bool FinalStateTimeEmpty
        {
            get;
            set;
        }

        public string FinalState
        {
            get;
            set;
        }

        public bool CallbackAttemptsMinActive
        {
            get;
            set;
        }

        public int CallbackAttemptsMin
        {
            get;
            set;
        }

        public bool CallbackAttemptsMaxActive
        {
            get;
            set;
        }

        public int CallbackAttemptsMax
        {
            get;
            set;
        }

        public string RecordName
        {
            get;
            set;
        }

        public string RecordValue
        {
            get;
            set;
        }

        public bool UseRegex
        {
            get;
            set;
        }

        public bool CaseSensitive
        {
            get;
            set;
        }

        private bool StringFilter(string needle, string haystack)
        {
            if ( needle == "" )
            {
                return true;
            }
            else if (this.UseRegex)
            {
                return (Regex.Match(haystack, needle, this.CaseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase).Success);
            }
            else if (this.CaseSensitive)
            {
                return haystack.Contains(needle);
            }
            else
            {
                return haystack.ToLower().Contains(needle.ToLower());
            }
        }

        private bool TimeFilter(DateTime timeToCheck, bool timeAfterFilterActive, DateTime timeAfterFilter, bool timeBeforeFilterActive, DateTime timeBeforeFilter, bool timeEmptyFilter)
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

        private bool CallbackAttemptsFilter(bool minActive, int min, bool maxActive, int max, string numberOfAttemptsStr)
        {
            int numberOfAttempts = 0;
            Int32.TryParse(numberOfAttemptsStr, out numberOfAttempts);

            return ((!minActive || min <= numberOfAttempts) &&
                    (!maxActive || numberOfAttempts <= max ));
        }

        private bool RecordFilter(string recordNamePattern, string recordValuePattern, IEnumerable<CallDataRecord> records)
        {
            bool result = true;
            
            if ( recordNamePattern != "" && recordValuePattern == "")
            {
                result = (from record in records
                          where Regex.Match(record.Name, recordNamePattern).Success
                          select record).Any();
            }
            else if ( recordNamePattern == "" && recordValuePattern != "" )
            {
                result = (from record in records
                          where Regex.Match(record.Value, recordValuePattern).Success
                          select record).Any();
            }
            else if ( recordNamePattern != "" && recordValuePattern != "" )
            {
                result = (from record in records
                          where Regex.Match(record.Name, recordNamePattern).Success && Regex.Match(record.Value, recordValuePattern).Success
                          select record).Any();
            }

            return result;
        }
    }
}
