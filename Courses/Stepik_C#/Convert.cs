using System;

public class MainClass
{
    static void Main(string[] args)
        {
            string start = ("Введите числа в диапазоне от 1 до 100.");
            Console.WriteLine(start);
            string num_1 = Console.ReadLine();
            int number = Convert.ToInt32(num_1);
            string num_2 = Console.ReadLine();
            double number2 = Convert.ToDouble(num_2);
            double result = number / number2;
            Console.WriteLine("1 число:");
            Console.WriteLine("2 число:");
            Console.WriteLine(result);
        } 
}
