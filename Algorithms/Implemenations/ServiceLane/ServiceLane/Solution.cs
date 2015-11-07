using System.IO;
using System.Xml;

namespace ServiceLane
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// https://www.hackerrank.com/challenges/service-lane
    /// </summary>
    public class Solution
    {
        public static void Main(string[] args)
        {
            var input = @"8 5
                        2 3 1 2 3 2 3 3
                        0 3
                        4 6
                        6 7
                        3 5
                        0 7";

            var line = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var n = line[0];
            var testsCount = line[1];
            int left, right;

            var arr = new int[n*2];

            arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            while (testsCount > 0)
            {
                var min = int.MaxValue;
                var leftRight = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                left = leftRight[0];
                right = leftRight[1];

                for (int i = left; i <= right; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                    
                }
                Console.WriteLine(min);
                testsCount--;
            }           
        }
    }
}
