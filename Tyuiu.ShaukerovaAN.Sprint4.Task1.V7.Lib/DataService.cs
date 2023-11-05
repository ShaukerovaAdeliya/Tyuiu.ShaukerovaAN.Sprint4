using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShaukerovaAN.Sprint4.Task1.V7.Lib
{
    public class DataService : ISprint4Task1V7
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0) 
                {
                    sum += num; 
                }
            }
            return sum;
        }
    }
}
