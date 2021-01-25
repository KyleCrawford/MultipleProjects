using System;

namespace MiniTests
{
    class MiniTests
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));




            Console.ReadKey(true);

        }

        //returns a string of the Fibonocci sequence up to the provided position (includes 0)
        private static string FibNums(int count)
        {
            //returns the number of Fibonici sequence numbers asked for
            if (count <= 0)
            {
                return "";
            }

            int[] sequence = new int[count];
            string finalString = "";

            if (count == 1)
            {
                return "0";
            }

            sequence[0] = 0;
            sequence[1] = 1;
            finalString = (count <= 2) ? "0, 1" : "0, 1, ";

            for (int i = 2; i < count; i++)
            {
                sequence[i] = sequence[i - 1] + sequence[i - 2];

                finalString += i != (count - 1) ? sequence[i].ToString() + ", " : sequence[i].ToString();
            }

            return finalString;
        }

        //calculates factorial (recursive)
        private static int Factorial(int num)
        {
            //start with end case
            if (num == 0)
            {
                //we're at the end
                return 1;
            }

            return num * Factorial(num - 1);
        }

        //returns the Fibonocci sequence at the requested position (ignores 0)
        public static int Fib(int num)
        {
            if (num <= 2)
            {
                return 1;
            }
            else
            {
                return Fib(num - 1) + Fib(num - 2);
            }
        }
    }
}
