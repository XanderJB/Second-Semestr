using System;
using System.Collections.Generic;
using ClassLibraryTest;

namespace ConsoleAppTest
{
    class Program
    {
        static List<Mark> GetMarks(DateTime now, List<string> students)
        {
            List<Mark> result = new List<Mark>();
            return result; 
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int year = rnd.Next(2000, 2004);
            int group = rnd.Next(190, 220);
            /*Console.WriteLine("Напишите ФИО студента:");*/
           /* string fio = Console.ReadLine();*/
            /*string result = Library.GetStudNumber(year, group, fio);*/

            List<string> Students = new List<string>();
            Students.Add("Student1");
            Students.Add("Student2");

            /*DateTime now = DateTime.Now;*/

            /*List<Mark> result1 = GetMarks(now, Students);*/
            for (int i=0; i<10; i++)
            {
                DateTime now = DateTime.Now;
                DateTime data = now.AddDays(i);
                Console.WriteLine(data);

/*
                DateTime currentDate = DateTime.Now;
                DateTime date = currentDate.AddDays(j);
                Console.WriteLine("Day {0}: {1}", j + 1, date);
*/

                for (int j = 0; j < Students.Count; j++)
                {
                    
                }
                List<Mark> listMark = new List<Mark>();
                Mark mark = new Mark();
                mark.Estimation = "5";
                mark.date = DateTime.Now;
                mark.Student = "Алибеков Мустафа";
                listMark.Add(mark);

                listMark.ForEach(p => Console.WriteLine($"" + $"Студент: {p.Student}, Дата выставленной отметки: {p.date}, Оценка: {p.Estimation}"));
            }
        }
    }
}
