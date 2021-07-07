using System;

namespace FFX_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin FizzBuzz!");
            for(int i = 1; i < 101; i++)
            {
                Console.WriteLine(PrintMethod(i));
            }
        }
        static String PrintMethod(int i)
        {
            String str = "";
            if((i % 3) == 0)
            {
                str += "Fizz";

                if ((i % 5) == 0)
                {
                    str += "Buzz";
                }
            }
            else if((i % 5) == 0)
            {
                str += "Buzz";
            }
            else
            {
                str = i.ToString();
            }

            return str;
        }
    }
}
