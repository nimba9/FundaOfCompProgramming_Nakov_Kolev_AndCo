using System;
using System.Collections.Generic;


namespace nakovChp16_50firstElemOfSeque
{
    class Program
    {

        public static void PrintRecurrSeque(int num)
        {
            Queue<int> seque = new Queue<int>();

            seque.Enqueue(num);

            for (int i = 0; i < 50; i++)
            {
                int currNum = seque.Dequeue();
                Console.WriteLine(currNum);
                seque.Enqueue(currNum + 1);
                seque.Enqueue(2 * currNum + 1);
                seque.Enqueue(currNum + 2);
            }
            
            
        }


        static void Main(string[] args)
        {
            PrintRecurrSeque(2);
        }
    }
}
