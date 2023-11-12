using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShaukerovaAN.Sprint4.Task7.V3.Lib
{
    public class DataService : ISprint4Task7V3
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] array = new int[n, m];
            int count = 0;
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
