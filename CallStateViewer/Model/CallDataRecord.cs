using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallStateViewer.Model
{
    class CallDataRecord
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

        public override string ToString()
        {
            return String.Format("{0}|{1}|{2}|{3}", this.CallId, this.Name, this.Value, this.Timestamp.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        }
    }
}
