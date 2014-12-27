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
            return ((CallIdFilter == "" || Regex.Match(callSummary.CallId, CallIdFilter).Success) &&
                    (FinalStateFilter == "" || Regex.Match(callSummary.FinalState, FinalStateFilter).Success));
        }

        public string CallIdFilter
        {
            get;
            set;
        }

        public DateTime TimeInAfterFilter
        {
            get;
            set;
        }

        public DateTime TimeInBeforeFilter
        {
            get;
            set;
        }

        public bool TimeInEmptyFilter
        {
            get;
            set;
        }

        public DateTime FinalStateTimeAfterFilter
        {
            get;
            set;
        }

        public DateTime FinalStateTimeBeforeFilter
        {
            get;
            set;
        }

        public bool FinalStateTimeEmptyFilter
        {
            get;
            set;
        }

        public string FinalStateFilter
        {
            get;
            set;
        }

        public int CallbackAttemptsMinFilter
        {
            get;
            set;
        }

        public int CallbackAttemptsMaxFilter
        {
            get;
            set;
        }

        public string RecordNameFilter
        {
            get;
            set;
        }

        public string RecordValueFilter
        {
            get;
            set;
        }

    }
}
