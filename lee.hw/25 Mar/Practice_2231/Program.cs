using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2231
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_input = Convert.ToInt32(Console.ReadLine());
            int n = num_input.ToString().Length;
            int max = n * 9;
            int result = 0;

            for (int i = num_input - max; i < num_input; i++)
            {
                int a = i;
                if (i > 0)
                {
                    for (int j = 0; j < i.ToString().Length; j++)
                    {
                        a += int.Parse(i.ToString()[j].ToString());
                    }

                    if (a == num_input)
                    {
                        result = i;
                        break;
                    }
                }
            }
            Console.WriteLine(result);

        }
    }
}
