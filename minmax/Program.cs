using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minmax
{
    class Program
    {
        static void Main(string[] args)
        {
            //massiiv leia kõige suurim ja väikseim number 
            int [] numbers = new int [5] { 1, -4, 8, 4, 100 };
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            
            foreach(int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }

            foreach(int number in numbers)
            {
                if (number >= max)
                {
                    max = number;
                } 
            }
            Console.WriteLine($"The minimum value is {min}");
            Console.WriteLine($"The maximum value is {max}");
            Console.ReadLine();
        }
        
    }
}
