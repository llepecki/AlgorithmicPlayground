using System;

namespace Com.Lepecki.AlgorithmicPlayground.Sorting
{
    public class SystemSortTest : SortTest
    {
        protected override void Sort(int[] array)
        {
            Array.Sort(array);
        }
    }
}
