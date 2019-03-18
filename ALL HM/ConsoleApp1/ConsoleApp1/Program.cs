using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstMassive = new int[10];
            Random k = new Random();
            for (int i = 0; i < 10; i++)
            {
                firstMassive[i] = k.Next(0, 10);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nFirst Massive is :");
                Console.WriteLine(firstMassive[i]);
            }

            int[] secondMassive = new int[10];
            for (int i = 0; i < 10; i++)
            {
                secondMassive[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nSecond Massive is :");
                Console.WriteLine(secondMassive[i]);

            }

            int[] thirdMassive = new int[10];
            for (int i = 0; i < 10; i++)
            {
                thirdMassive[i] = (firstMassive[i] + secondMassive[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nThird Massive is: ");
                Console.WriteLine(thirdMassive[i]);
            }


            Console.ReadKey();

        }
    }
}


