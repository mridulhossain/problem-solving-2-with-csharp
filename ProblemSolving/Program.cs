using System;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Reverse(321)); 
        }


        public static int Reverse(int x)
        {


            int remainder;
            long reverse = 0;





            if (x < 0)
            {
                var positive = x * -1;

                while (positive > 0)
                {
                    remainder = positive % 10;
                    reverse = reverse * 10 + remainder;
                    positive /= 10;
                }
                reverse = reverse * -1;
                bool test = reverse <= -2147483648;
                if (test != true)
                {
                    return Convert.ToInt32(reverse);
                }
                else
                {
                    return 0;
                }


            }
            else
            {
                while (x > 0)
                {
                    remainder = x % 10;
                    reverse = reverse * 10 + remainder;
                    x /= 10;
                }

                bool test = reverse <= 2147483647;
                if (test != true)
                {
                    return 0;
                }
                else
                {
                    return Convert.ToInt32(reverse);
                }

            }

        }
    }
}
