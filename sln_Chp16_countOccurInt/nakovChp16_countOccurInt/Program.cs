using System;
using System.Collections.Generic;

namespace nakovChp16_countOccurInt
{
    class Program
    {
        public static void CountOccurInt(int [] arr)
        {
            Dictionary<int, int> intCount= new Dictionary<int, int>();
            
            foreach (var item in arr)
            {
                if (intCount.ContainsKey(item))
                {
                    intCount[item]++;
                    
                }

                else
                {
                    intCount.Add(item, 1);
                }
            }

            Console.WriteLine("The numbers in sequence occured as followed:");
            foreach (var item in intCount)
            {
                Console.Write("\nNumber: " + item.Key + "; Occurences: " + item.Value);
            }

        }

        static void Main(string[] args)
        {
            
           int[] testArr = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

           CountOccurInt(testArr);

        }
    }
}
