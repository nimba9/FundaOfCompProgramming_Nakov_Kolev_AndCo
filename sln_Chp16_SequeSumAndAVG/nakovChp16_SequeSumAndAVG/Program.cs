using System;
using System.Collections.Generic;
using System.Linq;

namespace nakovChp16_SequeSumAndAVG
{
    class Program
    {

        public static void Main()
        {
            List<int> seque = new List<int>();
            bool inputEnd = false;

            while(!inputEnd)
            {
                Console.Write("Enter number: ");
                string userInp = Console.ReadLine();

                if(String.IsNullOrWhiteSpace(userInp))
                {
                    inputEnd = true;
                }

                else
                {
                    int valid;
                    bool result = int.TryParse(userInp, out valid);
                
                    if (valid > 0)
                    {
                        seque.Add(valid);
                    }

                    else
                    {
                        Console.WriteLine("Invalid value: Please try again");
                    }
                }

                int sum = seque.Sum();
                int average = seque.Count;

                Console.WriteLine("sum is: {0}", sum);
                Console.WriteLine("average is: {0}", average);
            }
            
        }

    }

}


      