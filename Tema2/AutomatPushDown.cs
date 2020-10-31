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

        public void Verificare(string sirIntrare, ListBox listIntrare, ListBox listStiva, ListBox listOp)
        {
            foreach (var item in T)
            {
                sirIntrare = sirIntrare.Replace(item, " " + item + " ");
            }
            intrare.Clear();
            string[] termeniIntrare = sirIntrare.Split(' ');
            foreach (var i in termeniIntrare.Reverse())
            {
                intrare.Push(i);
            }
            stiva.Clear();
            stiva.Push("$");
            stiva.Push(0);
            bool accept = false;
            AfisareStiva1(stiva, listStiva);
            AfisareStiva(intrare, listIntrare);
            while (!accept)
            {
                if (stiva.Peek().GetType().Equals(typeof(int)))
                {
                    var linie = (int)stiva.Peek();
                    var coloana = intrare.Peek().ToString();
                    var operation = String.Empty;
                    if(TA.ContainsKey(linie))
                    {
                        if(TA[linie].ContainsKey(coloana))
                        {
                            operation = TA[linie][coloana];
                            listOp.Items.Add(operation);
                        }
                        else
                        {
                            listIntrare.Items.Add("Sirul nu apartine gramaticii.");
                            return;
                        }
                    }
                    else
                    {
                        listIntrare.Items.Add("Sirul nu apartine gramaticii.");
                        return;
                    }
                    if(operation.Equals("acc"))
                    {
                        accept = true;
                        listIntrare.Items.Add("Sirul apartine gramaticii.");
                        return;
                    }
                    if(operation.StartsWith("d"))
                    {
                        stiva.Push(intrare.Pop());
                        stiva.Push(int.Parse(operation[1].ToString()));
                        AfisareStiva1(stiva, listStiva);
                        AfisareStiva(intrare, listIntrare);
                    }
                    if(operation.StartsWith("r"))
                    {
                        string popOperatie = String.Empty;
                        foreach(var item in stiva.ToArray())
                        {
                            stiva.Pop();
                            if(item.GetType().Equals(typeof(string)))
                            {
                                popOperatie += item.ToString();
                                int index = int.Parse(operation[1].ToString());
                                string derivare = P[index].Item2;
                                if (Reverse(popOperatie).Equals(derivare))
                                {
                                    break;
                                }
                            }
                        }
                        stiva.Push(P[int.Parse(operation[1].ToString())].Item1);
                    }

                }
                else
                {
                    var col = stiva.Pop().ToString();
                    var line = int.Parse(stiva.Peek().ToString());
                    stiva.Push(col);
                    if (TS.ContainsKey(line))
                    {
                        if (TS[line].ContainsKey(col))
                        {
                            stiva.Push(int.Parse(TS[line][col]));
                        }
                        else
                        {
                            listIntrare.Items.Add("Sirul nu apartine gramaticii.");
                            return;
                        }
                    }
                    AfisareStiva1(stiva, listStiva);
                    AfisareStiva(intrare, listIntrare);
                }
            }
        }

        public void AfisareStiva(Stack<object> stack, ListBox listBox)
        {
            string aux = String.Empty;
            foreach(var item in stack)
            {
                aux += item.ToString();
            }
            listBox.Items.Add(aux);
        }

        public void AfisareStiva1(Stack<object> stack, ListBox listBox)
        {
            string aux = String.Empty;
            foreach (var item in stack.Reverse())
            {
                aux += item.ToString();
            }
            listBox.Items.Add(aux);
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
