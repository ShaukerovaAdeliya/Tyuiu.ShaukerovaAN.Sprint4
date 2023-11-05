using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShaukerovaAN.Sprint4.Task2.V5.Lib
{
    public class DataService : ISprint4Task2V5
    {
        public int Calculate(int[] array)
        {
            int MultiplyArray = 1;

            foreach (int x in array)
            {
                if (x >= 3 && x <= 9 && x % 2 == 0)
                {
                    MultiplyArray *= x;
                }
            }

            return MultiplyArray;
        }
    }
}
