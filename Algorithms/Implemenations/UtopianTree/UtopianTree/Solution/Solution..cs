
namespace Solution
{
    using System;

    /// <summary>
    /// https://www.hackerrank.com/challenges/utopian-tree
    /// The Utopian Tree goes through 2 cycles of growth every year. 
    /// The first growth cycle occurs during the spring, when it doubles in height. 
    /// The second growth cycle occurs during the summer, when its height increases by 1 meter.
    /// Now, a new Utopian Tree sapling is planted at the onset of spring.Its height 
    /// is 1 meter.Can you find the height of the tree after N growth cycles?
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());
            
            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var height = 1;

                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        height *= 2;
                    }
                    else
                    {
                        height += 1;
                    }
                }

                Console.WriteLine(height);

                t--;
            }
        }
    }
}
