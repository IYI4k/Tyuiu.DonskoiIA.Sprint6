using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DonskoiIA.Sprint6.Task4.V15.Lib
{
    public class DataService : ISprint6Task4V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] ans = new double[++stopValue - startValue];

            int pos = 0;

            for (int i = startValue; i < stopValue; i++)
            {
                ans[pos++] = Math.Round(Math.Sin(i) + 2 * i / 3.0 - Math.Cos(i) * 4 * i, 2);
            }

            return ans;
        }
    }
}