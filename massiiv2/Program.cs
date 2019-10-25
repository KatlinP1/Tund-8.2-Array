using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace massiiv2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eilse koduse ülesande tegemine- leia kõikide massiivide summa 
            //Leia massiivide summa keskmine

            int[] numbers = new int[100];
            int sum = 0;
            

            for(int i=0; i<numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            foreach(int num in numbers)
            {
                sum = sum + num;
            }
            Console.WriteLine(sum);

            double avarage = sum / numbers.Length;
            Console.WriteLine(avarage);
            

            Console.ReadLine();


        }
    }
}
