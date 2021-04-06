using System;
using System.Collections;
using System.Text;

namespace Problem_10828
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Stack stack = new Stack();

            for (int i = 0; i < cnt; i++)
            {
                String cmd = Console.ReadLine();
                String[] cmdlist = cmd.Split(' ');

                switch (cmdlist[0])
                {
                    case "push":
                        stack.Push(cmdlist[1]); ;
                        break;
                    case "pop":
                        if (stack.Count > 0)
                        {
                            //Console.WriteLine(stack.Peek());
                            sb.AppendFormat("{0}\n", stack.Peek());
                            stack.Pop();
                        }
                        else
                            //Console.WriteLine("-1");
                            sb.AppendFormat("{0}\n", -1);
                        break;
                    case "size":
                        //Console.WriteLine(stack.Count);
                        sb.AppendFormat("{0}\n", stack.Count);
                        break;
                    case "empty":
                        if (stack.Count > 0)
                            //Console.WriteLine("0");
                            sb.AppendFormat("{0}\n", 0);
                        else
                            //Console.WriteLine("1");
                            sb.AppendFormat("{0}\n", 1);
                        break;
                    case "top":
                        if (stack.Count > 0)
                            //Console.WriteLine(stack.Peek());
                            sb.AppendFormat("{0}\n", stack.Peek());
                        else
                            //Console.WriteLine("-1");
                            sb.AppendFormat("{0}\n", -1);
                        break;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
