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



        public static List<CallDataRecord> Parse(string filepath)
        {
            var result = new List<CallDataRecord>();

            using (var r = new StreamReader(filepath))
            {
                while (!r.EndOfStream)
                {
                    string line = r.ReadLine();

                    Match m = recordRegex.Match(line);

                    if ( m.Success )
                    {
                        string callId = m.Groups[1].Value;
                        string name = m.Groups[2].Value;
                        string value = m.Groups[3].Value;
                        string timestamp = m.Groups[4].Value;

                        string currentState = "";

                        if ( !callIdsTable.ContainsKey(callId) )
                        {
                            callIdsTable[callId] = callId;
                        }

                        if ( !namesTable.ContainsKey(name) )
                        {
                            namesTable[name] = name;
                        }

                        if ( name == "State" )
                        {
                            currentStatesTable[callId] = value;
                        }

                        if ( currentStatesTable.ContainsKey(callId) )
                        {
                            currentState = currentStatesTable[callId];
                        }

                        result.Add( new CallDataRecord(callIdsTable[callId], currentState, namesTable[name], value, DateTime.Parse(timestamp)));
                    }
                }
            }

            return result;
        }

        
    }
}
