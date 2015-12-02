namespace Combinatorics.CoingageItterative
{
    using System;
    using System.Linq;

    public class Startup
    {
        private static int[,] allSums = new int[1001,4];
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());

                int ones, twos, fives, tens;
                var quantities = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                ones = quantities[0];
                twos = quantities[1];
                fives = quantities[2];
                tens = quantities[3];

                for (int i = 0; i <= Math.Min(1000, ones); i++)
                {
                    allSums[i, 0] = 1;
                }

                for (int i = 0; i <= twos; i++)
                {
                    for (int j = 0; j <= 1000; j++)
                    {
                        if (j + i * 2 <= 1000)
                        {
                            allSums[j + i * 2, 1] += allSums[j, 0];
                        }
                    }
                }

                for (int i = 0; i <= fives; i++)
                {
                    for (int j = 0; j <= 1000; j++)
                    {
                        if (j + i * 5 <= 1000)
                        {
                            allSums[j + i * 5, 2] += allSums[j, 1];
                        }
                    }
                }

                for (int i = 0; i <= tens; i++)
                {
                    for (int j = 0; j <= 1000; j++)
                    {
                        if (j + i * 10 <= 1000)
                        {
                            allSums[j + i * 10, 3] += allSums[j, 2];
                        }
                    }
                }

                var countOfWantedSum = allSums[n, 3];


                Console.WriteLine(countOfWantedSum);
                allSums = new int[1001, 4];
                t--;
            }
        }
    }
}
