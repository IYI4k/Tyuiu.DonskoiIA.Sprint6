using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DonskoiIA.Sprint6.Task2.V29.Lib
{
    public class DataService : ISprint6Task2V29
    {

        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] ans = new double[++stopValue - startValue];
            int pos = 0;

            while (startValue < stopValue)
            {
                double down = 2 * startValue - 1;
                if (down == 0)
                {
                    ans[pos++] = 0;
                    startValue++;
                    continue;
                }
                ans[pos++] = Math.Round((2 * Math.Cos(startValue) + 2) / down + Math.Cos(startValue) - 5 * startValue + 3, 2);
                startValue++;
            }

            return ans;
        }
    }
}