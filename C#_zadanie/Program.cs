using System;
using ClassLibraryTest;

namespace ConsoleAppTest
{
    class Program
    {
        static public double MinAVG(string[] marks)
        {
            Console.WriteLine("String length: {0}", marks.Length);
            int[] mass = new int[marks.Length];
            double res = 0, sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                mass[i] = Convert.ToInt32(marks[i]);
                Console.WriteLine(mass[i]);
                sum = sum + mass[i];
            }
            res = sum / mass.Length;
            Console.WriteLine("Вывод чисел: {0}", res);
            int modres = Convert.ToInt32(res);
            Console.WriteLine(modres);
            modres = (int)res;
            return modres;

        }
        static void Main(string[] args)
        {
            void GetStudNumber(int year, int group, string fio);
            Random rnd = new Random();
            int year = rnd.Next();
            int group = rnd.Next();
            string fio = rnd.ToString();
        }

       
    }
}
