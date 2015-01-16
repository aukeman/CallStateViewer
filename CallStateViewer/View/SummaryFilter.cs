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
            return (FilterHelper.PassesStringFilter(CallId, callSummary.CallId, this.CaseSensitive, this.UseRegex) &&
                    FilterHelper.PassesStringFilter(FinalState, callSummary.FinalState, this.CaseSensitive, this.UseRegex) &&
                    FilterHelper.PassesRecordFilter(RecordName, RecordValue, this.CaseSensitive, this.UseRegex, callSummary.Records) &&
                    FilterHelper.PassesTimeFilter(callSummary.TimeIn, TimeInAfterActive, TimeInAfter, TimeInBeforeActive, TimeInBefore, TimeInEmpty) &&
                    FilterHelper.PassesTimeFilter(callSummary.FinalStateTime, FinalStateTimeAfterActive, FinalStateTimeAfter, FinalStateTimeBeforeActive, FinalStateTimeBefore, FinalStateTimeEmpty) &&
                    FilterHelper.PassesMinMaxNumberFilter(CallbackAttemptsMinActive, CallbackAttemptsMin, CallbackAttemptsMaxActive, CallbackAttemptsMax, callSummary.CallbackAttempts));
        }

        public bool Active
        {
            get
            {
                return (CallId != string.Empty ||
                        FinalState != string.Empty ||
                        RecordName != string.Empty ||
                        RecordValue != string.Empty ||
                        TimeInAfterActive ||
                        TimeInBeforeActive ||
                        TimeInEmpty ||
                        FinalStateTimeAfterActive ||
                        FinalStateTimeBeforeActive ||
                        FinalStateTimeEmpty ||
                        CallbackAttemptsMinActive ||
                        CallbackAttemptsMaxActive);
            }
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
    }
}
