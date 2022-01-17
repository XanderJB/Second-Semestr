using System;

public class MainClass
{
   static void Main(string[] args)
        {
            string start = ("Введите любое число от 1 до 10:");
            Console.WriteLine(start);
            string num = Console.ReadLine();
            int number = int.Parse(num);
            int number1 = ++number;
            Console.WriteLine("Измененное число:" + number1);
        }
}
