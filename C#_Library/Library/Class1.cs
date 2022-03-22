using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryTest
{
  
    static public class Library
    {
        static public void test_function()
        {
            Console.WriteLine("Hello, World!");
        }

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

        static public string GetStudNumber(int year, int group, string fio)
        {
            string[] s = fio.Replace(".", "").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string LastName = s[0];
            string Name = s[1];
            string FatherName = s[2];
            Console.WriteLine("{0}.{1}.{2}{3}{4}", year, group, LastName[0], Name[0], FatherName[0]);
            string res = "The End";
            return res;
        }

        static public List<Mark> GetMarks(DateTime now, List<string> students)
        {
            List<Mark> marks = new List<Mark>();

            for (int j = 0; j < 30; j++)
            {

                DateTime date = now.AddDays(j);
                Console.WriteLine(date);

                for (int i = 0; i < students.Count; i++)
                {
                    var random = new Random();
                    string[] Estimation = { "5", "4", "3", "2", "прогул", "болезнь" };

                    int index = random.Next(Estimation.Length);
                    Console.WriteLine("ФИО: {0}; Оценка: {1}", students[i], Estimation[index]);

                    Mark mark = new Mark();
                    mark.Estimation = Estimation[index];
                    mark.date = date;
                    mark.Student = students[i];
                    //test_mark1.Print();
                    marks.Add(mark);

                }

            }
            //marks.ForEach(p => Console.WriteLine($"" + $"Дата выставленной отметки: {p.date}\n Студент: {p.Student},  Оценка: {p.Estimation}"));

            return marks;
        }

        static public int GetCountTruancy(List<Mark> marks)
        {
            DateTime date1 = new DateTime(2022, 03, 21, 0, 0, 0);
            var Truancy = from p in marks where p.Estimation == "прогулы" where p.date >= date1 select p;
            int count = 0;
            foreach (Mark mark in Truancy)
            {
                Console.WriteLine($"Студент: {mark.Student}, Оценка: {mark.Estimation}");
                count += 1;
            }
            Console.WriteLine($"Количество прогулов: {count}");
            return count;
        }
        static public int GetCountDicease(List<Mark> marks)
        {
            DateTime date1 = new DateTime(2022, 03, 21, 0, 0, 0);
            var Truancy = from p in marks where p.Estimation == "болезнь" where p.date >= date1 select p;
            int count = 0;
            foreach (Mark mark in Truancy)
            {
                Console.WriteLine($"Студент: {mark.Student}, Оценка: {mark.Estimation}");
                count += 1;
            }
            Console.WriteLine($"Количество болезней: {count}");
            return count;
        }
    }
}
