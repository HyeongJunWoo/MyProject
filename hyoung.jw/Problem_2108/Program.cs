using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2108
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] list = new int[N];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                list[i] = int.Parse(Console.ReadLine());
            }

            sb.Append(Aver(list) + "\n");

            sb.Append(Mid(list) + "\n");

            sb.Append(Mode(list) + "\n");

            sb.Append(Range(list));

            Console.WriteLine(sb);
        }

        public static String Aver(int[] list)
        {
            //int sum = 0;
            //for (int i = 0; i < list.Length; i++)
            //{
            //    sum += list[i];
            //}

            double aver = list.Average();

            return Math.Round(aver).ToString();
        }

        public static String Mid(int[] list)
        {
            int temp;

            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[i] > list[j])
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }

            return list[list.Length / 2].ToString();
        }

        public static String Mode(int[] list)
        {
            int maxidx = list.GroupBy(a => a)
                             .Max(b => b.Count());

            int mode = 0;

            if (list.Length == 1)
                mode = list.GroupBy(a => a).Where(b => b.Count() == maxidx).OrderBy(c => c.Key).Min(d => d.Key);
            else
                mode = list.GroupBy(a => a).Where(b => b.Count() == maxidx).OrderBy(c => c.Key).Skip(1).Take(1).Min(d => d.Key);
           
            return mode.ToString();
        }

        public static String Range(int[] list)
        {
            int max = list.Max();
            int min = list.Min();

            return (max - min).ToString();
        }
    }
}