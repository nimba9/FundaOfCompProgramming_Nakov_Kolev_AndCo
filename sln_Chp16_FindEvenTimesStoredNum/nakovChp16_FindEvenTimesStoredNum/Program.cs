using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nakovChp16_FindEvenTimesStoredNum
{
    class Program
    {
        private static void SortEvenOccurence(List<int> seque)
        {
            List<int> evenList = new List<int>();

            int[] arr = seque.ToArray();
            Array.Sort(arr);

            

            int timesOccured = 1;

            for (int i = 0; i < arr.Length -1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    timesOccured++;
                    //evenList.Add(arr[i]);
                 
                }


                else if ((timesOccured % 2) == 0)
                {
                    evenList.Add(arr[i]);
                    timesOccured = 1;
                }

            }

            foreach (var item in evenList)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            List<int> check = new List<int>() { 77, 5, 12, 14, 26, 32, 26, 5, 77 };

            SortEvenOccurence(check);
        }
    }
}
