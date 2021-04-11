using System;
using System.Text;

namespace Problem_11729
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sboutData = new StringBuilder();
            int iData = Convert.ToUInt16(Console.ReadLine());

            solve(iData - 1, 1, 2, sboutData);
            sboutData.AppendLine("1 3");
            solve(iData - 1, 2, 3, sboutData);

            Console.Write(Math.Pow(2, iData) - 1 + "\n" + sboutData.ToString());
        }

        static void solve(int n, int x, int y, StringBuilder sb) // n개를 x에서 y로 옮긴다
        {
            if (n == 1)
            {
                sb.AppendLine(x + " " + y);
                return;
            }
            else
            {
                solve(n - 1, x, 6 - x - y, sb);
                sb.AppendLine(x + " " + y);
                solve(n - 1, 6 - x - y, y, sb);
            }
        }

    }
}