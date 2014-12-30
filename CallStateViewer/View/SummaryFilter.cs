using System;
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

        private static bool StringFilter(string needle, string haystack)
        {
            return (needle == "" || Regex.Match(haystack, needle).Success);
        }

        private static bool TimeFilter(DateTime timeToCheck, bool timeAfterFilterActive, DateTime timeAfterFilter, bool timeBeforeFilterActive, DateTime timeBeforeFilter, bool timeEmptyFilter)
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

        private static bool CallbackAttemptsFilter(bool minActive, int min, bool maxActive, int max, string numberOfAttemptsStr)
        {
            int numberOfAttempts = 0;
            Int32.TryParse(numberOfAttemptsStr, out numberOfAttempts);

            return ((!minActive || min <= numberOfAttempts) &&
                    (!maxActive || numberOfAttempts <= max ));
        }
    }
}
