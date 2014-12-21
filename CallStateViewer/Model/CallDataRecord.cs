using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace CallStateViewer.Model
{
    class CallDataRecord : IEquatable<CallDataRecord>
    {
        public CallDataRecord(string callId, string currentState, string name, string value, DateTime timestamp)
        {
            this.CallId = callId;
            this.CurrentState = currentState;
            this.Name = name;
            this.Value = value;
            this.Timestamp = timestamp;
        }

        public string CallId
        {
            get;
            private set;
        }

        public string CurrentState
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }

        public string Value
        {
            get;
            private set;
        }

        public DateTime Timestamp
        {
            get;
            private set;
        }

        public override bool Equals(object other)
        {
            if ( this == other )
            {
                return true;
            }
            else if ( other is CallDataRecord)
            {
                CallDataRecord cdr = other as CallDataRecord;

                return (this.CallId == cdr.CallId &&
                        this.Name == cdr.Name &&
                        this.Value == cdr.Value &&
                        this.Timestamp == cdr.Timestamp);
            }
            else
            {
                return false;
            }
        }

        public bool Equals(CallDataRecord other)
        {
            return this.Equals(other as object);
        }

        public override int GetHashCode()
        {
            return this.CallId.GetHashCode() ^ this.Name.GetHashCode() ^ this.Value.GetHashCode() ^ this.Timestamp.GetHashCode();
        }

    }
}
