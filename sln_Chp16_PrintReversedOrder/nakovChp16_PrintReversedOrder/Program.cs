using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nakovChp16_PrintReversedOrder
{
    class Program
    {
        static Stack<int> CheckUserInput()
        {
            Stack<int> seque = new Stack<int>();

            string str;
            int valid = 0;

            while ((str = Console.ReadLine()) != "")
            {
                bool check = int.TryParse(str, out valid);

                if (check == true)
                {
                    seque.Push(valid);
                }

                else
                { Console.WriteLine("Please input a valid integer"); }


            }
            return seque;
        }

        static void PrintInReverse(Stack<int> check)
        {
            while (check.Count > 0)
            {
                int reversed = check.Pop();
                Console.WriteLine(reversed);
            }
        }



        static void Main(string[] args)
        {

            //Console.WriteLine(CheckUserInput().Reverse());
            PrintInReverse(CheckUserInput()); 
        }
    }
}
