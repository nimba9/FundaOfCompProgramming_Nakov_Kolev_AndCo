using System;
using System.Collections.Generic;
using System.Linq;

namespace nakovChp16_SequeSumAndAVG
{
    class Program
    {

        static List<int> CheckUserInput()
        {
            List<int> seque = new List<int>();

            string str;
            int valid = 0;
            
            while ((str = Console.ReadLine()) != "")
            {
                bool check = int.TryParse(str, out valid);

                if (check == true)
                {
                    seque.Add(valid);
                }

                else
                { Console.WriteLine("Please input a positive integer"); }

                
            }
                return seque;
        }

        public static void PrintList_SumAndAvg(List<int> intList)
        {

            Console.WriteLine("The sum of your sequence is: {0}", intList.Sum());
            Console.WriteLine("The average of your sequence is: {0}", intList.Average());

        }

        public static void Main()
        {
            Console.WriteLine("Please enter non negative integers, use void input for ending your sequence");
            PrintList_SumAndAvg(CheckUserInput());
        }
    }

}


      