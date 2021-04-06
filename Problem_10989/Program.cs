using System;
using System.Collections;
using System.IO;

namespace Problem_10989
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            ArrayList list = new ArrayList();
            //int[] list = new int[10000];
            for(int i = 0; i < N; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            list.Sort();

            StreamWriter sw = new StreamWriter("test.txt");

            for(int i = 0; i < list.Count; i++)
            {
                sw.WriteLine(list[i]);
            }

            sw.Close();

            StreamReader sr = new StreamReader("test.txt");

            Console.WriteLine(sr.ReadToEnd());

            sr.Close();
        }
    }
}
