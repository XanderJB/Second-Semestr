using System;
using System.Collections.Generic;

namespace ConsoleAppTest
{
    class Students
    {
        int group;
        int year;
        string fio;

    }

    public class Mark
    {
        public string Student;
        public DateTime date;
        public string Estimation;
    }
    class Program
    {
        static List<Mark> GetMarks(DateTime now, List<string> students)
        {
            Random rnd = new Random();
            List<Mark> listMark1 = new List<Mark>();
            for (int i = 0; i < 10; i++)
            {
                
                DateTime data = now.AddDays(i);
                Console.WriteLine(data);
                for (int j = 0; j < students.Count; j++)
                {
                    List<Mark> listMark = new List<Mark>();

                    string[] Estimation = { "5", "4", "3", "2", "прогул", "болезнь" };
                    int index = rnd.Next(0, Estimation.Length);
                    
                    Mark mark = new Mark();
                    mark.Estimation = Estimation[index];
                    mark.date = data;
                    listMark.Add(mark);
                    listMark.ForEach(p => Console.WriteLine($"" + $"Студент: {students[j]}\nОценка: {Estimation[index]}\n"));
                    listMark1 = listMark;
                }
                
            }
            
            return listMark1;
        }
        static void Main(string[] args)
        { 
            DateTime now = DateTime.Now;

            Random rnd = new Random();

            int year = rnd.Next(2000, 2004);
            int group = rnd.Next(190, 220);


            List<string> Students = new List<string>();
            Students.Add("Алибеков Мустафа");
            Students.Add("Михаил Калашников");

           
            List<Mark> res = GetMarks(now, Students);
            /*Console.WriteLine(res);*/
        }
    }
}
