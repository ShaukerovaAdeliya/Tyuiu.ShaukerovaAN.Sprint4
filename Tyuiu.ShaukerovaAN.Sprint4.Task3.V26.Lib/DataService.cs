using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShaukerovaAN.Sprint4.Task3.V26.Lib
{
    public class DataService : ISprint4Task3V26
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int secondRow = 1;
            int m = 0;
            for (int i = 0; i < array.GetLength(secondRow); i++)
            {
                if (array[secondRow, i] > m)
                {
                    m = array[secondRow, i];
                }
            }
            return m;
        }    
    }
}
