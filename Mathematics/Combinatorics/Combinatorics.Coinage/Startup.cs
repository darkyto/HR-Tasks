namespace Combinatorics.Coinage
{
    using System;
    using System.Linq;

    /// <summary>
    /// https://www.hackerrank.com/challenges/coinage
    /// The first line contains an integer T (number of testcases). Each testcase contains 2 lines. 
    /// The first line contains integer N (sum to be achieved) 
    /// A, B, C and D in the next line, each representing the number of ₹1, ₹2, ₹5 and ₹10 coins respectively.
    /// </summary>
    class CombinationsGeneratorWithReps
    {
        private const int n = 4;
        private static int k = 0;
        private static string[] coins = new string[n]
        {
        "1", "2", "5", "10"
        };
        private static long[] arr = new long[k];
        private static int count = 0;
        private static int sum = 0;

        public static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                sum = int.Parse(Console.ReadLine());
                var quantities = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var ones = quantities[0];
                var twos = quantities[1];
                var fives = quantities[2];
                var tens = quantities[3];

                if (sum <= quantities[0])
                {
                    k = sum;
                }
                else
                {
                    k = quantities[0] + quantities[1] / 2 + quantities[2] / 5 + quantities[3] / 10 + 2 + 5 + 10;
                }
               
                while (k > 0)
                {
                    arr = new long[k];
                    GenerateCombinationsNoRepetitions(0, 0, quantities);

                    k--;
                }

                Console.WriteLine(count);
                count = 0;
                t--;
            }

        }

        static void GenerateCombinationsNoRepetitions(int index, int start, int[] quantities)
        {
            if (index >= k)
            {            
                if (CheckCoints(quantities[0], quantities[1], quantities[2], quantities[3]))
                {
                    count++;
                }
            }
            else
            {
                for (int i = start; i < n; i++)
                {
                    arr[index] = i;
                    GenerateCombinationsNoRepetitions(index + 1, i, quantities);
                }
            }
        }

        private static bool CheckCoints(int ones, int twos, int fives, int tens)
        {
            int[] tempCounts = new int[4];
            for (int i = 0; i < arr.Length; i++)
            {
                if (coins[arr[i]] == "1")
                {
                    tempCounts[0]++;
                    if (tempCounts[0] > ones)
                    {
                        return false;
                    }
                }
                if (coins[arr[i]] == "2")
                {
                    tempCounts[1]++;
                    if (tempCounts[1] > twos)
                    {
                        return false;
                    }
                }
                if (coins[arr[i]] == "5")
                {
                    tempCounts[2]++;
                    if (tempCounts[2] > fives)
                    {
                        return false;
                    }
                }
                if (coins[arr[i]] == "10")
                {
                    tempCounts[3]++;
                    if (tempCounts[3] > tens)
                    {
                        return false;
                    }
                }
            }

            if (tempCounts[0] <= ones && tempCounts[1] <= twos && tempCounts[2] <= fives && tempCounts[3] <= tens && CheckSum())
            {
                return true;
            }

            return false;
        }

        private static void PrintVariations()
        {
            Console.Write("(" + String.Join(", ", arr) + ") --> ( ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(coins[arr[i]] + " ");
            }
            Console.WriteLine(")");
        }

        private static bool CheckSum()
        {
            int currentSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                currentSum += int.Parse(coins[arr[i]]);
                if (currentSum > sum)
                {
                    return false;
                }
            }

            if (sum == currentSum)
            {
                return true;
            }

            return false;
        }
    }

}
