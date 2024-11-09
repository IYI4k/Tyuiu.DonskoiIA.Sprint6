using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DonskoiIA.Sprint6.Task1.V2.Lib
{
    public class DataService : ISprint6Task1V2
    {

        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] ans = new double[++stopValue - startValue];
            int pos = 0;

            while (startValue<stopValue)
            {
                double down = Math.Sin(startValue) + 2;
                if (down == 0)
                {
                    ans[pos++] = 0;
                    startValue++;
                    continue;
                }
                ans[pos++] = Math.Round((5 * startValue + 2.5) / down + 2 * startValue + 2, 2);
                startValue++;
            }

            return ans;
        }
    }
}