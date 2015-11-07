namespace FindDigitsTask
{
    using System;

    /// <summary>
    /// https://www.hackerrank.com/challenges/find-digits
    /// You are given an integer N. Find the digits in this number that exactly divide N 
    /// (division that leaves 0 as remainder) and display their count. For N=24, 
    /// there are 2 digits (2 & 4). Both of these digits exactly divide 24. So our answer is 2.
    /// </summary>
    public class Solution
    {
        public static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                var input = Console.ReadLine();
                var count = 0;

                foreach (var ch in input)
                {
                    if (int.Parse(ch.ToString()) != 0 && 
                        int.Parse(input) % int.Parse(ch.ToString()) == 0)
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}
