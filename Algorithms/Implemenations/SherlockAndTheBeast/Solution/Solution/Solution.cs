
namespace Solution
{
    using System;
    using System.Text;

    /// <summary>
    /// https://www.hackerrank.com/challenges/sherlock-and-the-beast
    ///     A Decent Number has the following properties:

    ///    3, 5, or both as its digits.No other digit is allowed.
    ///    Number of times 3 appears is divisible by 5.
    ///    Number of times 5 appears is divisible by 3.
    /// </summary>
    class Solution
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                var sb = new StringBuilder();

                int n = int.Parse(Console.ReadLine());

                if (n < 3)
                {
                    Console.WriteLine("-1");
                    continue;
                }

                var threeCount = n / 3;
                var fiveCount = 0;

                while (threeCount >= 0)
                {
                    var rem = n - threeCount * 3;
                    if (rem % 5 == 0)
                    {
                        fiveCount = rem / 5;
                        break;
                    }
                    threeCount -= 1;
                }

                if (threeCount <= 0 && fiveCount == 0)
                {
                    Console.WriteLine("-1");
                    continue;
                }

                while (threeCount > 0)
                {
                    sb.Append("555");
                    threeCount--;
                }

                while (fiveCount > 0)
                {
                    sb.Append("33333");
                    fiveCount--;
                }
                
                Console.WriteLine(sb.ToString());
                t--;
            }
        }
    }
}
