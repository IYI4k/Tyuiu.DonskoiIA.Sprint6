using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;
using System.Reflection.PortableExecutable;

namespace Tyuiu.DonskoiIA.Sprint6.Task5.V8.Lib
{
    public class DataService : ISprint6Task5V8
    {
        public double[] LoadFromDataFile(string path)
        {

            int ArraySize = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    ArraySize++;
                }

                
            }

            double[] arr = new double[ArraySize];
            ArraySize = 0;
            
            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    double temp = Convert.ToDouble(line);

                    if (temp < 0)
                    {
                        arr[ArraySize++] = Math.Round(temp, 3);
                    }
                }
            }

            double[] ans = new double [ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                ans[i] = arr[i];
            }

            return ans;
        }
    }
}