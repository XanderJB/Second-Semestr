using System;

namespace Course_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите 1 если хотите выполнить сложение\nНажмите 2 если хотите выполнить вычитание\n" +
                "Нажмите 3 если хотите выполнить умножение\nНажмите 4 если хотите выполнить деление\nНажмите 5 если хотите найти остаток от деления");
            int math = int.Parse(Console.ReadLine());
            if (math == 1)
            {
                Console.WriteLine("Введите слагаемое 1:");
                int a1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите слагаемое 2:");
                int a2 = int.Parse(Console.ReadLine());
                int sum = a1 + a2;
                Console.WriteLine("Сумма чисел = "+sum);
            } else if (math == 2)
            {
                Console.WriteLine("Введите уменьшаемое 1:");
                int b1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите вычитаемое 2:");
                int b2 = int.Parse(Console.ReadLine());
                int razn = b1 - b2;
                Console.WriteLine("Разность чисел = "+razn);
            } else if (math == 3)
            {
                Console.WriteLine("Введите множитель 1:");
                int c1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите множитель 2:");
                int c2 = int.Parse(Console.ReadLine());
                int proizv = c1 * c2;
                Console.WriteLine("Произведение чисел = "+proizv);
            }
            else if (math == 4)
            {
                Console.WriteLine("Введите делимое 1:");
                int d1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите делитель 2:");
                int d2 = int.Parse(Console.ReadLine());
                int chast = d1 / d2;
                Console.WriteLine("Частное чисел = "+chast);
            }
            else if (math == 5)
            {
                Console.WriteLine("Введите делимое 1:");
                double e1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите делитель 2:");
                double e2 = int.Parse(Console.ReadLine());
                double ost = e1 % e2;
                Console.WriteLine("Остаток от числа = "+ost);
            }
            else
            {
                Console.WriteLine("Значение некорректно");
            }
            /* if (math > 5)
             {
                 Console.WriteLine("Значение некорректно");
                 Environment.Exit(0);
             }*/
            /*Console.WriteLine("Введите число 1:");
            Console.WriteLine("Введите число 2:");*/

           /* int num_1 = int.Parse(Console.ReadLine());
            int num_2 = int.Parse(Console.ReadLine());*/
/*
            

            if (math == 1)
            {
                Console.WriteLine("Сумма чисел=" + sum);
            }
            else if (math == 2)
            {
                Console.WriteLine("Разность чисел=" + raznost);
            }
            else if (math == 3)
            {
                Console.WriteLine("Произведение чисел=" + umnozhenie);
            }
            else if (math == 4)
            {
                Console.WriteLine("Частное чисел=" + divizion);
            }
            else if (math == 5)
            {
                Console.WriteLine("Остаток от деления =" + ostatok);
            }*/
        }
    }
}
