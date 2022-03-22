using System;
using System.Collections.Generic;
using ClassLibraryTest;

namespace Popytka3
{
    class Program
    {
        static void Main(string[] args)
        {
            Students student_1 = new Students();

            DateTime now = DateTime.Now;

            Random rnd = new Random();

            student_1.year = rnd.Next(2000, 2004);
            student_1.group = rnd.Next(190, 220);
            student_1.fio = ("Алибеков Мустафа");

            List<string> Students = new List<string>();
            Students.Add(student_1.fio);
            Students.Add("Михаил Калашников");


            List<Mark> res = Library.GetMarks(now, Students);

            int res_1 = Library.GetCountTruancy(res);
            int res_2 = Library.GetCountDicease(res);

        }
    }
}
