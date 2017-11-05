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

                if (check == true && valid > 0)
                {
                    seque.Add(valid);
                }

                else
                { Console.WriteLine("Please input a positive integer"); }


            }
            return seque;
        }

        public static void Print_ascendingOrder(List<int> intList)
        {

            intList.Sort();
       
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }

        }

        public static void Main()
        {
            Console.WriteLine("Please enter non negative integers, use void input for ending your sequence");

            Print_ascendingOrder(CheckUserInput());


        }
    }

}


