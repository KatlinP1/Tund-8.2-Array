using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uus
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[5];

            //Värvide ülesanne
            for (int i=0; i < colors.Length; i++)
            {
                Console.WriteLine("Enter a color: ");
                colors[i] = Console.ReadLine();
            }
            //Sort an array
            Array.Sort(colors);
            Console.WriteLine("\n");
            Console.WriteLine("Array sorted: ");
            PrintArray(colors);
            Console.WriteLine("\n");

            //Reverse an array
            Array.Reverse(colors);
            Console.WriteLine("Array reversed: ");
            PrintArray(colors);

            /*foreach (string color in colors)
            {
                Console.WriteLine(color);
            }*/

            Console.ReadLine();
        }
        public static void PrintArray(string[] array)
        {
            foreach(string item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
