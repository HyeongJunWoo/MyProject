using System;

namespace Problem_7568
{
    class Program
    {
        static void Main(string[] args)
        {
            int person = int.Parse(Console.ReadLine());
            int[] weight = new int[person];
            int[] height = new int[person];

            for (int i = 0; i < person; i++)
            {
                string input = Console.ReadLine();
                weight[i] = int.Parse(input.Split(' ')[0]);
                height[i] = int.Parse(input.Split(' ')[1]);
            }

            int rank = 1;

            for (int i = 0; i < person; i++)
            {
                rank = 1;
                for (int j = 0; j < person; j++)
                {
                    if (weight[i] < weight[j] && height[i] < height[j])
                        rank++;
                }
                Console.Write(rank + " ");
            }
        }
    }
}
