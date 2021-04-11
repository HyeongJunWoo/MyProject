using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2108
{
    class Program
    {
        static void Main(string[] args)
        {
            int iCount = Convert.ToInt32(Console.ReadLine());
            int iData = 0;
            var lisData = new List<int>();
            var lisData_temp = new List<int>();
            var lisSearch = new List<int>();
            int iout = 0;

            int[] arrData = new int[8001];

            for (int i = 0; i < iCount; i++)
            {
                iData = Convert.ToInt32(Console.ReadLine());
                lisData.Add(iData);

                arrData[iData + 4000]++;
            }

            lisData_temp = arrData.ToList();
            lisSearch = arrData.ToList();

            FuncA(ref lisData);
            FuncB(ref lisData);

            // 최빈값
            lisData_temp.Sort();
            lisData_temp.Reverse();
            if (lisData_temp[0] == lisData_temp[1])
            {
                for (int i = lisSearch.IndexOf(lisData_temp[0]) + 1; i < lisSearch.ToArray().Length; i++)
                {
                    if (lisSearch[i] == lisData_temp[0])
                    {
                        iout = i;
                        break;
                    }
                }
                Console.WriteLine(iout - 4000);
            }
            else
            {
                Console.WriteLine(lisSearch.IndexOf(lisData_temp[0]) - 4000);
            }
            FuncD(lisData);
        }

        // 산술 평균
        static void FuncA(ref List<int> listData)
        {
            int temp = 0;

            for (int i = 0; i < listData.Count; i++)
            {
                temp += listData[i];
            }
            Console.WriteLine(Math.Round((double)temp / listData.Count));
        }

        // 중앙값
        static void FuncB(ref List<int> listData)
        {
            int temp = 0;

            temp = (listData.Count - 1) / 2;

            listData.Sort();
            Console.WriteLine(listData[temp]);
        }

        // 범위
        static void FuncD(List<int> listData)
        {
            int temp = 0;

            temp = listData.Max() - listData.Min();
            Console.WriteLine(temp);
        }
    }
}