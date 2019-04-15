using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Com.Lepecki.AlgorithmicPlayground.Sorting
{
    public class SortTestData : SortTheoryData
    {
        public SortTestData()
        {
            Stream resource = Assembly.GetExecutingAssembly().GetManifestResourceStream($"{typeof(SortTestData).FullName}.csv");

            using (var reader = new StreamReader(resource, Encoding.UTF8))
            {
                bool dataRow = false;

                while (!reader.EndOfStream)
                {
                    if (dataRow)
                    {
                        string[] testData = reader.ReadLine()?.Split(',');

                        if (testData != null)
                        {
                            int[] unsorted = ExtractNumbers(testData[0]);
                            int[] sorted = ExtractNumbers(testData[1]);
                            
                            AddRow(unsorted, sorted);
                        }
                    }
                    else
                    {
                        reader.ReadLine();
                        dataRow = true;
                    }
                }
            }
        }

        private int[] ExtractNumbers(string stringData)
        {
            return stringData.Split(' ').Select(int.Parse).ToArray();
        }
    }
}
