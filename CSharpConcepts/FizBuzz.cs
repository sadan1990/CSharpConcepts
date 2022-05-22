using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    class FizBuzzs
    {
        public static void fizzBuzz(int n)
        {
            string number = "00248666550000200001";
            var ORDER_NUMBER = number.Substring(0, 10);
            var ORDER_LINE_NUMBER = number.Substring(10, 5);
            var ORDER_SCHEDULE_LINE_NUMBER = number.Substring(15, 5);
            Console.WriteLine("ORDER NUMBER -" + ORDER_NUMBER);
            Console.WriteLine("ORDER LINE NUMBER -" + ORDER_LINE_NUMBER);
            Console.WriteLine("ORDER SCHEDULE LINE NUMBER -" + ORDER_SCHEDULE_LINE_NUMBER);
            Console.ReadLine();
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (i % 3 == 0 && i % 5 != 0)
            //    {
            //        Console.WriteLine("Fizz");

            //    }
            //    else if (i % 3 != 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");

            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }


            //}

        }
    }
}
