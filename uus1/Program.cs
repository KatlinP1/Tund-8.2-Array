using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uus1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = new string[5] { "apple", "banana", "orange", "lemon", "grapes" };
            

            PrintArray(fruit);

            //Get the element index
            int index;
            index= Array.IndexOf(fruit, "banana");
            Console.WriteLine($"The index of your element is:{index}");

            //mis puuvilja kasutaja ise otsib
            Console.WriteLine("What fruit would you like?");
            string userAnswer = Console.ReadLine();
            index = Array.IndexOf(fruit, userAnswer);

            if (index != -1)
            {
                Console.WriteLine($"Here is your fruit: {userAnswer}");
            }
            else
            {
                Console.WriteLine($"{userAnswer} fruit not found.");
            }

            Console.ReadLine();

        }
        public static void PrintArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }

        }

    }
}
