using Xunit;

namespace Com.Lepecki.AlgorithmicPlayground.ProjectEuler
{
    // https://projecteuler.net/problem=1
    public class Problem001
    {
        [Fact]
        public void Solution()
        {
            const int limes = 1000;

            int sum = 0;
            int divisibleByThree = 3;
            int divisibleByFive = 5;

            while (divisibleByThree < limes)
            {
                if (divisibleByThree < divisibleByFive)
                {
                    sum += divisibleByThree;
                    divisibleByThree += 3;
                }
                else if (divisibleByThree > divisibleByFive)
                {
                    sum += divisibleByFive;
                    divisibleByFive += 5;
                }
                if (divisibleByThree == divisibleByFive)
                {
                    sum += divisibleByThree;
                    divisibleByThree += 3;
                    divisibleByFive += 5;
                }
            }

            Assert.Equal(233168, sum);
        }
    }
}
