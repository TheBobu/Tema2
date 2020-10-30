using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2
{
    public class AutomatPushDown
    {
        public List<string> N;
        public List<string> T;
        public Dictionary<int, (string, string)> P;
        public Dictionary<int, Dictionary<string, string>> TA;
        public Dictionary<int, Dictionary<string, string>> TS;
        public Stack<Object> stiva;

        public AutomatPushDown()
        {
            N = new List<string>();
            T = new List<string>();
            P = new Dictionary<int, (string, string)>();
            TA = new Dictionary<int, Dictionary<string, string>>();
            TS = new Dictionary<int, Dictionary<string, string>>();
            stiva = new Stack<Object>();
        }

        public void Verificare(string intrare, ListBox intrareBox, ListBox stivaBox)
        {
            int a = 1;
            string x = "aa";
            stiva.Push(a);
            stiva.Push(x);
        }
    }
}
