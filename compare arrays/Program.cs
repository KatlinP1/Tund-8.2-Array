using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compare_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = new string[5] { "apple", "banana", "orange", "lemon", "grapes" };
            string[] vegetables = new string[5] { "potato", "tomato", "onion", "carrot", "cucumber" };

            //kas on juurvili või puuvili?
            Console.WriteLine("Enter a fruit or a veggie: ");
            string userSearch = Console.ReadLine();

            int indexFruit = Array.IndexOf(fruit, userSearch);
            int indexVeggie = Array.IndexOf(vegetables, userSearch);


            if (indexFruit != -1)
            {
                Console.WriteLine($"It is a fruit: {userSearch}");
            }
            else if (indexVeggie != -1)
            {
                Console.WriteLine($"It is a veggi: {userSearch}");
            }
            else
            {
                Console.WriteLine($"{userSearch} Is something else!");
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
