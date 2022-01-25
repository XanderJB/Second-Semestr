using System;

public class MainClass
{
    public static void Main()
    {
       for (int i = -100; i<=100; i++)
            {
                string q = Console.ReadLine();
                
                Console.WriteLine("Для остановки введите 'exit':");
                if (q == "exit")
                {
                    break;
                }
                Console.WriteLine(i);
            }
    }
}
