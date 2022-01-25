using System;

namespace Course_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Имя ученика:" + name);

            Console.WriteLine("Введите возраст:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Возраст ученика:" + age);

            Console.WriteLine("Введите балл по русскому языку:");
            int rus = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите балл по математике:");
            int math = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите балл по информатике");
            int inf = int.Parse(Console.ReadLine());
            double mid_score = (rus + math + inf) / 3;
            Console.WriteLine("Средний балл ученика:"+mid_score);
        }
    }
}
