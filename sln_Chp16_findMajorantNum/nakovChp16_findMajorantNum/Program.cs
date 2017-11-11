using System;
using System.Collections.Generic;

public class Program
{
    public static void FindMajorNum(List<int> checkList)
    {
      
        Console.WriteLine("The input sequence is: ");

        for (int i = 0; i < checkList.Count; i++)
        {
            Console.Write(checkList[i] + " ");
        }

        Console.WriteLine();

        Dictionary<int, int> countOccurNum = new Dictionary<int, int>();
        foreach (int number in checkList)
        {
            if (countOccurNum.ContainsKey(number))
            {
                countOccurNum[number] += 1;
            }
            else
            {
                countOccurNum.Add(number, 1);
            }
        }

        int listLength = checkList.Count;
        double limitForMajor = listLength / 2 + 1;
        int majorNum = 0;
        foreach (var number in countOccurNum)
        {
            if (number.Value >= limitForMajor)
            {
                majorNum = number.Key;
            }
        }


        Console.WriteLine("The majorant for this sequence is: {0}", majorNum);
    }

    public static void Main()
    {
        List<int> intList = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

        FindMajorNum(intList);

    }
}