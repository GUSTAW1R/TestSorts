using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSorts
{
    class GnomeSort
    {
        static void Swap(ref int item1, ref int item2)
        {
            var temp = item1;
            item1 = item2;
            item2 = temp;
        }
        public int[] Sort(int[] array)
        {
            var index = 1;
            var nextIndex = index + 1;

            while (index < array.Length)
            {
                if (array[index - 1] < array[index])
                {
                    index = nextIndex;
                    nextIndex++;
                }
                else
                {
                    Swap(ref array[index - 1], ref array[index]);
                    index--;
                    if (index == 0)
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                }
            }

            return array;
        }
    }
}
