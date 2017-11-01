using System;
using System.Collections.Generic;

class Program
{
    public static void RemoveNegatINT(List<int> numList)
    {

        if (numList.Count == 0)
        {
            throw new NullReferenceException("No data found in the list");
        }
        
        List<int> result = new List<int>();
                
        foreach (var item in numList)
        {
            if (item > 0)
            {
                result.Add(item);
            }
        }

        numList = result;

        foreach (var item in numList)
        {
            Console.WriteLine(item);
        }
        
    }
    

    public static void Main()
    {
        List<int> intList = new List<int>() { 2, 4, -6, -6, -34, -56, 67, 67, 67, -82, -83, -83 };

        RemoveNegatINT(intList);
    }
}

