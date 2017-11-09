using System;
using System.Collections.Generic;


class RemoveEvenTimesOccuringNumbers
{
    public static void RemoveEvenTimesOccuringNum(int [] arr)
    {
        Dictionary<int, int> countNum = new Dictionary<int, int>();

        foreach (var item in arr)
        {
            if (countNum.ContainsKey(item))
            {
                countNum[item]++;
            }

            else
            {
                countNum.Add(item, 1);
            }

        }

        List<int> removedNum = new List<int>();
        foreach (var item in arr)
        {
            if (countNum[item] % 2 == 0)
            {
                removedNum.Add(item);

            }
        }

        removedNum.Sort();
       
        foreach (var item in removedNum)
        {
            Console.Write(" " + item);
        }


    }


    public static void Main()
    {
        int[] testArr = { 21, 3, 6, 77, 21, 35, 35, 43, 77, 25, 77, 36, 77 };

        RemoveEvenTimesOccuringNum(testArr);

        





    }
}