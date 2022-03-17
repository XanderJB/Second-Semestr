using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
/*группа, год поступления, ФИО.*/

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

        internal void ForEach(Action<object> p)
        {
            throw new NotImplementedException();
        }
    }

}
