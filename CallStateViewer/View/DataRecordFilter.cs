using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CallStateViewer.Model;

namespace CallStateViewer.View
{
    public class DataRecordFilter
    {
        public bool Passes(CallDataRecord callDataRecord)
        {
            return (FilterHelper.PassesRecordFilter(RecordName, RecordValue, CaseSensitive, UseRegex, callDataRecord) &&
                    FilterHelper.PassesTimeFilter(callDataRecord.Timestamp, TimeAfterActive, TimeAfter, TimeBeforeActive, TimeBefore, false));
        }

        public bool Active
        {
            get
            {
                return (RecordName != string.Empty ||
                        RecordValue != string.Empty ||
                        TimeAfterActive ||
                        TimeBeforeActive);
            }
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

        public bool TimeAfterActive
        {
            get;
            set;
        }

        public DateTime TimeAfter
        {
            get;
            set;
        }

        public bool TimeBeforeActive
        {
            get;
            set;
        }

        public DateTime TimeBefore
        {
            get;
            set;
        }

    }
}
