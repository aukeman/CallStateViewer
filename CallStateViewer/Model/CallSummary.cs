using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallStateViewer.Model
{
    public class CallSummary
    {
        public string CallId
        {
            get;
            set;
        }

        public DateTime TimeIn
        {
            get;
            set;
        }

        public DateTime FinalStateTime
        {
            get;
            set;
        }

        public string FinalState
        {
            get;
            set;
        }

        public string CallbackAttempts
        {
            get;
            set;
        }
    }
}
