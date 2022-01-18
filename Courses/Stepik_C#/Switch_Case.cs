using System;
class HelloWorld 
{
  static void Main() 
  { 
    char a = char.Parse(Console.ReadLine());
    switch (a)
    {
        case '1':
        Console.WriteLine("Персонаж применяет аптечку");
        break;
        case '2':
        Console.WriteLine("Персонаж пьет зелье");
        break;
        case 'e':
        Console.WriteLine("Персонаж открывает дверь");
        break;
    }
  }
}
