using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text.RegularExpressions;

using CallStateViewer.Model;

namespace CallStateViewer.Parser
{
    class MainReportParser
    {
        private static Dictionary<string,string> namesTable = new Dictionary<string,string>();
        private static Dictionary<string,string> callIdsTable = new Dictionary<string,string>();
        private static Dictionary<string, string> currentStatesTable = new Dictionary<string, string>();

        private static Regex recordRegex = new Regex(@"^(.+)\|(.+)\|(.+)\|(\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2}.\d{3})$");

        public static void Reset()
        {
            namesTable.Clear();
            callIdsTable.Clear();
            currentStatesTable.Clear();
        }

        public static List<CallDataRecord> ParseAllFiles(string[] filepaths)
        {
            Reset();

            var result = new List<CallDataRecord>();

            foreach (string filepath in filepaths)
            {
                result.AddRange( ParseFile(filepath) );
            }

            return result;
        }

        public static List<CallDataRecord> ParseFile(string filepath)
        {
            var result = new List<CallDataRecord>();

            using (var r = new StreamReader( new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite) ) )
            {
                while (!r.EndOfStream)
                {
                    string line = r.ReadLine();

                    CallDataRecord cdr = CallDataRecordFromLogString(line);

                    if ( cdr != null )
                    {
                        result.Add(cdr);
                    }
                }
            }

            return result;
        }

        public static CallDataRecord CallDataRecordFromLogString(string log)
        {
            CallDataRecord result = null;

            Match m = recordRegex.Match(log);

            if (m.Success)
            {
                string callId = m.Groups[1].Value;
                string name = m.Groups[2].Value;
                string value = m.Groups[3].Value;
                string timestamp = m.Groups[4].Value;

                string currentState = "";

                if (!callIdsTable.ContainsKey(callId))
                {
                    callIdsTable[callId] = callId;
                }

                if (!namesTable.ContainsKey(name))
                {
                    namesTable[name] = name;
                }

                if (name == "State")
                {
                    currentStatesTable[callId] = value;
                }
                else if (name == "Restoring Call" && value == "Restoring Call")
                {
                    // a call being restored after a restart doesn't have a state yet
                    currentStatesTable[callId] = "";
                }

                if (currentStatesTable.ContainsKey(callId))
                {
                    currentState = currentStatesTable[callId];
                }

                result = new CallDataRecord(callIdsTable[callId], currentState, namesTable[name], value, DateTime.Parse(timestamp));
            }

            return result;
        }

        public static string LogStringFromCallDataRecord(CallDataRecord cdr)
        {
            return String.Format("{0}|{1}|{2}|{3}", cdr.CallId, cdr.Name, cdr.Value, cdr.Timestamp.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        }

    }
}
