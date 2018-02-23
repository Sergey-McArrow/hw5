using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Task 5.3");
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());

            for (int i = N1; i < N2; i++)
            {
                if (i % 2 == 0)

                    Console.WriteLine(i);
            }

                       
            Console.WriteLine("Task 5.6");
            int NString = int.Parse(Console.ReadLine());

            for (int i = 0; i < NString; i++)
            {
                for (int ii = 0; ii <= i; ii++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            for (int i = NString - 1; i > 0; i--)
            {
                for (int ii = i; ii > 0; ii--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }


            Console.WriteLine("Task 5.7");
            int N = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= N; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);


            Console.WriteLine("Task 5.8");
            double Money = double.Parse(Console.ReadLine());
            int NumberOfYears = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Money * 0.2 * NumberOfYears + Money}");


            Console.WriteLine("Task 5.9");
            for (int i = 1; i <= 50; i++)
            {
                if ((i % 3 == 0) && (i % 5 != 0))
                    Console.WriteLine(i);

            }

            Console.WriteLine("Task 5.11");
            int NZvezdochek = int.Parse(Console.ReadLine());

            for (int i = 0; i < NZvezdochek; i++)
            {
                for (int ii = 0; ii < NZvezdochek; ii++)
                {
                    if (i == 0 || i == NZvezdochek - 1)
                        Console.Write('*');
                    else if ((i > 0) && (ii == 0) || (i > 0) && (ii == NZvezdochek - 1))
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
