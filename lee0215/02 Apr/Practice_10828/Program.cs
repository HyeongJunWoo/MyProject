using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_10828
{
    class Stack_Practice
    {
        Stack<int> rst = new Stack<int>();        
        public void stack_Push(string str)
        {
            rst.Push(Convert.ToInt32(str));
        }
        public int stack_Pop()
        {
            if(rst.Count() == 0)
            {
                return -1;
            }
            return rst.Pop();
        }

        public int stack_Size()
        {
            return rst.Count;
        }

        public int stack_Empty()
        {
           int cnt = rst.Count;
            if(cnt == 0)
            {
                return 1;
            }
                return 0;

        }

        public int stack_Top()
        {           
            return rst.Count == 0 ? -1 : rst.First();

        }
    }

    class Program
    {      

        static void Main(string[] args)
        {
            int int_N = Convert.ToInt32(Console.ReadLine());
            Stack_Practice sp = new Stack_Practice();
            List<int> result = new List<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < int_N; i++)
            {
                int a = 0;
                string str = Console.ReadLine();
                string[] array = str.Split(' ');
                switch (array[0])
                {
                    case "push":
                        sp.stack_Push(array[1]);                        
                        break;
                    case "pop":
                        a = sp.stack_Pop();                        
                        break;
                    case "size":
                        a = sp.stack_Size();                      
                        break;
                    case "empty":
                        a = sp.stack_Empty();                       
                        break;
                    case "top":
                        a = sp.stack_Top();                        
                        break;
                }
                if(!array[0].Equals("push")) sb.Append(a + "\n");
            }           

            Console.WriteLine(sb);
                                    
        }

    }


}
