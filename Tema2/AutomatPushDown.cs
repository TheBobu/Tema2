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
        public Stack<object> stiva;
        public Stack<object> intrare;

        public AutomatPushDown()
        {
            N = new List<string>();
            T = new List<string>();
            P = new Dictionary<int, (string, string)>();
            TA = new Dictionary<int, Dictionary<string, string>>();
            TS = new Dictionary<int, Dictionary<string, string>>();
            stiva = new Stack<object>();
            intrare = new Stack<object>();
        }

        public void Verificare(string sirIntrare, ListBox listIntrare, ListBox listStiva)
        {
            foreach (var item in T)
            {
                sirIntrare = sirIntrare.Replace(item, " " + item + " ");
            }

            string[] termeniIntrare = sirIntrare.Split(' ');
            foreach (var i in termeniIntrare.Reverse())
            {
                intrare.Push(i);
            }
            stiva.Push("$");
            stiva.Push(0);
            bool accept = false;
            while(!accept)
            {
                
            }
            Console.WriteLine(stiva.Peek());
        }
    }
}
