using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7568
{
    class Program
    {
        static void Main(string[] args)
        {
            int int_N = Convert.ToInt32(Console.ReadLine());
            int[,] array_int = new int[int_N, 2];
            int[] result_cnt = new int[int_N];
            int[] result = new int[int_N];
            for (int i = 0; i < int_N; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                for (int j = 0; j < 2; j++)
                {

                    array_int[i, j] = Convert.ToInt32(str[j]);
                }
            }

            for (int i = 0; i < int_N; i++)
            {
                result[i]++;
                for (int z = 0; z < int_N; z++)
                {

                    if ((array_int[i, 0] < array_int[z, 0]) && array_int[i, 1] < array_int[z, 1])
                    {
                        result[i]++;
                    }

                }

            }

            for (int i = 0; i < int_N; i++)
            {
                Console.Write(result[i]);

                Console.Write(' ');
            }
        }
    }
}
