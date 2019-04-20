using System;

namespace Com.Lepecki.AlgorithmicPlayground.Sorting.Algorithms
{
    public class SystemSort : ISort
    {
        public void Sort(int[] array)
        {
            Array.Sort(array);
        }
    }
}
