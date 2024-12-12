using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DonskoiIA.Sprint6.Task6.V16.Lib
{
    public class DataService : ISprint6Task6V16
    {
        public string CollectTextFromFile(string str, string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string s = "";

                while ((line = reader.ReadLine()) != null)
                {
                    string[] Splitedline = line.Split(" ");

                    for (int i = 0; i < Splitedline.Length; i++)
                    {
                        foreach (char j in Splitedline[i])
                        {
                            if (j == 'b')
                            {
                                s += " " + Splitedline[i];
                                break;
                            }
                        }
                    }
                }

                return str + s;
            }
        }
    }
}