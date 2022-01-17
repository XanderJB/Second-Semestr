using System;

public class MainClass
{
     static void Main(string[] args)
        {
            
            string num_1 = Console.ReadLine();
            int num1 = int.Parse(num_1);
           
            
            string num_2 = Console.ReadLine();
            int num2 = int.Parse(num_2);
           

            bool res = num1 <= num2;

            Console.WriteLine("Введите число 1:");
            Console.WriteLine("Введите число 2:");
            Console.WriteLine(num1 + " меньше или равно " + num2 + " - " + res);
        }
}
