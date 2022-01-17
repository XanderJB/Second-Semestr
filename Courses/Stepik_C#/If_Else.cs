using System;

public class MainClass
{
 static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            Console.WriteLine("Введите число:");
            int num2 = int.Parse(num1);
            if (num2 % 2 == 1)
            {
                Console.WriteLine("Число нечетное");
            }
            else
            {
                Console.WriteLine("Число четное");
            }
        }
}
