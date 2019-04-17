namespace Com.Lepecki.AlgorithmicPlayground.Sorting
{
    public class SelectSortTest : SortTest
    {
        protected override void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int p = i;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[p])
                    {
                        p = j;
                    }
                }

                int tmp = array[p];
                array[p] = array[i];
                array[i] = tmp;
            }
        }
    }
}