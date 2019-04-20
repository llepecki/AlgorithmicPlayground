using Com.Lepecki.AlgorithmicPlayground.Sorting.Algorithms;
using Xunit;

namespace Com.Lepecki.AlgorithmicPlayground.Sorting
{
    public abstract class SortTest<T> where T : class, ISort, new()
    {
        [Theory]
        [ClassData(typeof(SortTestData))]
        public void UnsortedArraryShouldGetSorted(int[] unsorted, int[] sorted)
        {
            ISort algorithm = new T();
            algorithm.Sort(unsorted);

            for (int i = 0; i < unsorted.Length; i++)
            {
                Assert.Equal(unsorted[i], sorted[i]);
            }
        }
    }
}
