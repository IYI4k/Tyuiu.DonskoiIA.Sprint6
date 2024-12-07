using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DonskoiIA.Sprint6.Task3.V19.Lib
{
    public class DataService : ISprint6Task3V19
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = matrix[i, 4];
            }

            Array.Sort(arr);

            for (int i = 0; i < 5; i++)
            {
                matrix[i, 4] = arr[i];
            }

            return matrix;
        }
    }
}