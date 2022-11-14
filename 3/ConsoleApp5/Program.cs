using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] Array = new int[20];
            int i, min=100;
            for(i=0; i<Array.Length; i++)
            {
                Array[i] = rnd.Next(100);
            }
            Console.WriteLine("Массив:");
            for(i=0; i<Array.Length; i++)
            {
                if (Array[i] < min) min = Array[i];
                Console.WriteLine(""+Array[i]);
            }
            Console.WriteLine("Минимальное число в массиве: " + min);
            Console.WriteLine("Индексы элементов с этим значением:");
            for (i = 0; i < Array.Length; i++)
            {
                if (Array[i] == min) Console.WriteLine(""+i);
            }
            Console.ReadLine();
        }
    }
}
