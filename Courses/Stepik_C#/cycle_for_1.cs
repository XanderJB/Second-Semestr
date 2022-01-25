using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите число 1:");
            int num_1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2:");
            int num_2 = int.Parse(Console.ReadLine());
            const int g = 2;
            for (int i = 0; i < num_1; i++)
            {
                Console.WriteLine(num_2 + " * " + g + " = " + num_2 * g);
                num_2++;
            }
    }
}
