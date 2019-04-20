namespace Com.Lepecki.AlgorithmicPlayground.Sorting.Algorithms
{
    public class InsertSort : ISort
    {
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int tmp = array[i];
                int j = i;

                while (j > 0 && array[j - 1] > tmp)
                {
                    array[j] = array[j - 1];
                    j--;
                }

                array[j] = tmp;
            }
        }
    }
}
