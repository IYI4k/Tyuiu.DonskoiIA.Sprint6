using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DonskoiIA.Sprint6.Task7.V18.Lib
{
    public class DataService : ISprint6Task7V18
    {
        public int[,] GetMatrix(string path)
        {
            int RowsCount = 0;
            int ColumnsCount = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    RowsCount++;
                    ColumnsCount = line.Split(";").Length;
                    goto NEXTLINES;
                }
            NEXTLINES:
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        RowsCount++;
                    }
                }
            }

            int[,] ans = new int[RowsCount, ColumnsCount];

            int pos = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] Splitedline = line.Split(";");
                    for (int i = 0; i < ColumnsCount; i++)
                    {
                        ans[pos, i] = Convert.ToInt32(Splitedline[i]);
                    }
                    pos++;
                }
            }

            if (ColumnsCount>8)
            {
                for (int i = 0; i < RowsCount; i++)
                {
                    if (ans[i, 8] != 11)
                    {
                        ans[i, 8] = 11;
                    }
                }
            }

            return ans;
        }
    }
}