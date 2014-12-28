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
            return ((CallId == "" || Regex.Match(callSummary.CallId, CallId).Success) &&
                    (FinalState == "" || Regex.Match(callSummary.FinalState, FinalState).Success) &&
                    ((TimeInEmpty && callSummary.TimeIn == DateTime.MinValue) || ((!TimeInAfterActive || TimeInAfter < callSummary.TimeIn) &&
                                                                                  (!TimeInBeforeActive || callSummary.TimeIn < TimeInBefore))) &&
                    (!FinalStateTimeAfterActive || FinalStateTimeAfter < callSummary.FinalStateTime) &&
                    (!FinalStateTimeBeforeActive || callSummary.FinalStateTime < FinalStateTimeBefore) &&
                    (!CallbackAttemptsMinActive || CallbackAttemptsMin <= Int32.Parse(callSummary.CallbackAttempts)) &&
                    (!CallbackAttemptsMaxActive || Int32.Parse(callSummary.CallbackAttempts) <= CallbackAttemptsMax));
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

    }
}
