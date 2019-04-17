using System.IO;
using Xunit;

namespace Com.Lepecki.AlgorithmicPlayground.Sorting
{
    public class SortTheoryData : TheoryData
    {
        protected void AddRow(int[] unsorted, int[] sorted)
        {
            if (unsorted.Length != sorted.Length)
            {
                throw new InvalidDataException("Unsorted and sorted arrays must be of the same size");
            }

            AddRow(new object[] { unsorted, sorted });
        }
    }
}
