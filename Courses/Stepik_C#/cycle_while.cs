#решил через for

using System;

public class MainClass
{
     static void Main(string[] args)
        {
            int count = 1;
            int count_1 = int.Parse(Console.ReadLine());
            for (count = 1; count <= count_1; count++)
            {
                Console.WriteLine(count);
            }
        }
}
