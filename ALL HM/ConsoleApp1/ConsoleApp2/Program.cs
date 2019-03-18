using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"Input {i + 1} array value: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write("\nYour array is:  ");
                Console.Write(array[i]);
            }
            Console.Write("\nInput additional number: ");
            int adNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInput its position: ");
            int numPosition = Convert.ToInt32(Console.ReadLine());
            for (int i = 4; i >= numPosition; i--)
                array[i] = array[i - 1];
            array[numPosition - 1] = adNumber;
            Console.Write("\nFinal array is :");
            foreach (int p in array) Console.Write("{0,3}", p);
            Console.WriteLine();
            Console.ReadKey();



            int tempNum;
            for (int i = 0; i < (5 / 2); i++)
            {
                tempNum = array[i];
                array[i] = array[5 - i - 1];
                array[5 - i - 1] = tempNum;
            }

            Console.Write("Revers array is :");
            foreach (int p in array) Console.Write("{0,3}", p);
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
