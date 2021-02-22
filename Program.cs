using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            string num = Console.ReadLine();
            string[] str = new string[T];
            str = num.Split(' '); //you have to use split and trim method to format string. then only it can be pass to array.
            int[] N = new int[T];
            for (int i = 0; i < T; i++)
            {
                N[i] = int.Parse(str[i]);
            }
            for (int n = 0; n < T; n++)
            {
                for (int k = 1; k <= N[n]; k++)
                {
                    if (k % 15 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (k % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (k % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(k);
                    }
                }

            }

        }
    }
}
