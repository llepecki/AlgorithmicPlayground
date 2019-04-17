using Xunit;

namespace Com.Lepecki.AlgorithmicPlayground.Sorting
{
    public abstract class SortTest
    {
        [Theory]
        [ClassData(typeof(SortTestData))]
        public void Test(int[] unsorted, int[] sorted)
        {
            Sort(unsorted);

            for (int i = 0; i < unsorted.Length; i++)
            {
                Assert.Equal(unsorted[i], sorted[i]);
            }
        }

        protected abstract void Sort(int[] array);
    }
}
