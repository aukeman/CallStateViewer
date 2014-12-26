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
            return (FinalStateFilter == "" || Regex.Match(callSummary.FinalState, FinalStateFilter).Success);
        }

        public string CallIdFilter
        {
            get;
            set;
        }

        public string TimeInFilter
        {
            get;
            set;
        }

        public string FinalStateTimeFilter
        {
            get;
            set;
        }

        public string FinalStateFilter
        {
            get;
            set;
        }

        public string CallbackAttemptsFilter
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
