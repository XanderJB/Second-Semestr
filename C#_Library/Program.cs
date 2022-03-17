using System;
using ClassLibraryTest;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int year = rnd.Next(2000, 2004);
            int group = rnd.Next(190, 220);
            Console.WriteLine("Напишите ФИО студента:");
            string fio = Console.ReadLine();
            string result = Library.GetStudNumber(year, group, fio);
        }
    }
}
