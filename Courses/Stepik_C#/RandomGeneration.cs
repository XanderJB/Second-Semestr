using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            float num1 = rand.Next(10);
            float num2 = rand.Next(12);
            Console.WriteLine(num1 + num2);
        }
    }
}
 
