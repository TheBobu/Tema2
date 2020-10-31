using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2
{
    public class PushDownReader
    {
        public static void Read(AutomatPushDown automatPushDown, StreamReader reader)
        {
            string line = reader.ReadLine();
            string[] items = line.Split(',');
            foreach (var i in items)
            {
                automatPushDown.N.Add(i);
            }

            line = reader.ReadLine();
            items = line.Split(',');
            foreach (var i in items)
            {
                automatPushDown.T.Add(i);
            }
            string table = String.Empty;
            while (!reader.EndOfStream)
            {
                if (table.Equals(String.Empty))
                    line = reader.ReadLine();

                if (line.Equals("P") || line.Equals("TA") || line.Equals("TS"))
                {
                    table = line;
                }
                switch (table)
                {
                    case "P":
                        {
                            line = reader.ReadLine();
                            if (line.Equals("TA"))
                                break;
                            items = line.Split(' ');
                            automatPushDown.P.Add(int.Parse(items[0]), (items[1], items[2]));
                            break;
                        }
                    case "TA":
                        {
                            line = reader.ReadLine();
                            if (line.Equals("TS"))
                                break;
                            items = line.Split(' ');
                            int index = int.Parse(items[0]);
                            if (!automatPushDown.TA.ContainsKey(index))
                            {
                                automatPushDown.TA.Add(index, new Dictionary<string, string>());
                            }
                            automatPushDown.TA[index].Add(items[1], items[2]);
                            
                            break;
                        }
                    case "TS":
                        {
                            line = reader.ReadLine();
                            items = line.Split(' ');
                            int index = int.Parse(items[0]);
                            if (!automatPushDown.TS.ContainsKey(index))
                            {
                                automatPushDown.TS.Add(index, new Dictionary<string, string>());
                            }
                            automatPushDown.TS[index].Add(items[1], items[2]);

                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
