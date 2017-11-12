using System;
using System.Collections.Generic;

class Program
{
    public static void FindLongestEqualnumSeq(List<int> numList)
    {

        if (numList.Count == 0)
        {
            throw new NullReferenceException("There is no data stored in the list");
        }

        int currNum = numList[0];
        int currSeq = 0;
        int longestSeqNum = 0;
        int longestSeq = 0;
                
        foreach (var number in numList)
        {
            if (number == currNum)
            {
                currSeq++;
                if (currSeq > longestSeq)
                {
                    longestSeq = currSeq;
                    longestSeqNum = currNum;
                }

            }

            else
            {
                currNum = number;
                currSeq = 1;
            }

        }
        
        List<int> storeSeq = new List<int>();
        
        Console.WriteLine("The longestSubsequence of equal number is: ");
        for (int i = 0; i < longestSeq; i++)
        {
            storeSeq.Add(longestSeqNum);
            Console.Write(" " + longestSeqNum);
         }
        
    }

    public static void Main()
    {
        List<int> findSeq = new List<int>() { 2, 4, 6, 6, 34, 56, 67, 67, 67, 82, 83, 83 };

        FindLongestEqualnumSeq(findSeq);
    }
}


