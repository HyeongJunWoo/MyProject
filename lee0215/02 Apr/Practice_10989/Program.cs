using System;
using System.Collections;
using System.Text;

namespace Practice_10989
{
    class Program
    {
        //카운팅 정렬
        static void Main(string[] args)
        {
            int int_N = Convert.ToInt32(Console.ReadLine());
            int[] counting = new int[10001];
            ArrayList array_list = new ArrayList();
            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < int_N; i++)
            {
                int M = Convert.ToInt32(Console.ReadLine());
                counting[M]++;
            }            
            for (int i = 0; i < counting.Length; i++)
            {
                if (counting[i] > 0)
                {
                    for (int j = 0; j < counting[i]; j++)
                    {
                        sb.Append(i + "\n");
                    }
                }
            }
            Console.WriteLine(sb);
        }
    }
}
