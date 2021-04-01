using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10828
{
    class Program
    {
        static void Main(string[] args)
        {
            // 구현 시작
            int iCount = Convert.ToInt32(Console.ReadLine());
            string strData = string.Empty;
            string[] arrStrData = new string[iCount];
            Stack<int> stkidata = new Stack<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < iCount; i++)
            {
                strData = Console.ReadLine();
                arrStrData = Array.ConvertAll(strData.Split(' '), p => p);

                switch (arrStrData[0])
                {
                    case "push":
                        stkidata.Push(Convert.ToInt32(arrStrData[1]));
                        break;
                    case "pop":
                        if (stkidata.Count > 0)
                        {
                            sb.Append(stkidata.Peek() + "\n");
                            stkidata.Pop();
                        }
                        else
                        {
                            sb.Append("-1" + "\n");
                        }
                        break;
                    case "size":
                        sb.Append(stkidata.Count() + "\n");
                        break;
                    case "empty":
                        if (stkidata.Count > 0)
                        {
                            sb.Append("0" + "\n");
                        }
                        else
                        {
                            sb.Append("1" + "\n");
                        }
                        break;
                    case "top":
                        if (stkidata.Count > 0)
                        {
                            sb.Append(stkidata.Peek() + "\n");
                        }
                        else
                        {
                            sb.Append("-1" + "\n");
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(sb);
            // 구현 종료
        }
    }
}
