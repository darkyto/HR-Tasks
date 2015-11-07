namespace CutTheSticks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// https://www.hackerrank.com/challenges/cut-the-sticks
    /// </summary>
    public class Solution
    {
        public static void Main(String[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] sticks = new int[size + 1];

            sticks = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            Array.Sort(sticks);

            do
            {
                int count = 0;
                int leastLength = sticks[0];
                for (int j = 0; j < sticks.Length; j++)
                {
                    sticks[j] = sticks[j] - leastLength;
                    count++;
                }

                Console.WriteLine(count);

                List<int> resizeArray = new List<int>();
                for (int i = 0; i < sticks.Length; i++)
                {
                    if (sticks[i] != 0)
                    {
                        resizeArray.Add(sticks[i]);
                    }
                }

                int[] temp = new int[resizeArray.Count];
                for (int i = 0; i < resizeArray.Count; i++)
                {
                    temp[i] = resizeArray[i];
                }

                sticks = temp;
            }
            while (sticks.Length > 0);
        }
    }
}
