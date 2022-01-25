using System;

namespace Course_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1;)
            {
                double num1, num2;
                char math;

                Console.WriteLine("Введите число 1:");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число 2:");
                num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
                math = char.Parse(Console.ReadLine());

                switch (math)
                {
                    case '+':
                        double p = num1 + num2;
                        Console.WriteLine("a + b = " + p);
                        break;

                    case '-':
                        double k = num1 - num2;
                        Console.WriteLine("a - b = " + k);
                        break;
                    case '*':
                        double l = num1 * num2;
                        Console.WriteLine("a * b = " + l);
                        break;
                    case '/':
                        double m = num1 / num2;
                        Console.WriteLine("a / b = " + m);
                        break;

                }
                Console.WriteLine("Хотите продолжить выполнение программы?\nДА - 1. НЕТ - 2.");
                int user = int.Parse(Console.ReadLine());
                if (user == 1)
                {
                    continue;
                }
                else
                {
                    break;
                }

            }
        }

    }
}
