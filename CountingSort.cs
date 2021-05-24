using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSorts
{
    class CountingSort
    {
        public int[] Sort(int[] array, int k)
        {
            var count = new int[k+1];
            for (var i = 0; i < array.Length; i++)
            {
                count[array[i]]++;
            }

            var index = 0;
            for (var i = 0; i < count.Length; i++)
            {
                for (var j = 0; j < count[i]; j++)
                {
                    array[index] = i;
                    index++;
                }
            }

            return array;
        }
    }
}
