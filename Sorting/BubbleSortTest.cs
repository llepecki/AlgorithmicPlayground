namespace Com.Lepecki.AlgorithmicPlayground.Sorting
{
    public class BubbleSortTest : SortTest
    {
        protected override void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = tmp;
                    }
                }
            }
        }
    }
}
