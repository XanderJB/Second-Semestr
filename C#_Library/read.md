
![image](https://user-images.githubusercontent.com/86486142/158786641-564fd6cd-29be-4827-b025-b8af96640993.png)
массив(есть []) - один тип данных, список(List{}) - разные
функция состоит из 3 частей
1) тип данных: простые и сложные
к простым относятся число(int i float, double) и строка (string), void (если ыункция ничего не возвращает. Пример: простотвывод чернз Console.WriteLine)
к сложным относятся: массивы и списки
2) имя функции(любой набор символов, который начинается не с йифры)
3) аргументы(то что передвается в функцию и берется из Main)

  List<Mark> GetMarks (DateTime now, List<string> students)
  {
    code;
    List<Mark> marks = new Mark;
    return marks;
  }
  тд: список оценок
  имя: получить оценки 
  агрументы: 10 дней вперед, начиная с текущей даты и  списком переданных студентов
  
  int[] GetCountTruancy(List<Mark> marks),
  {
    code;
    int[] i = {1, 2, 3};
    return i;
  }
  тд:массив чисел
  имя: получить число прогулов
  аргументы: список оценок
  
  string GetStudNumber (int year, int group, string fio),
    {
    code;
    string i = "hw";
    return i;
  }
  тд: строка
  имя: получить номер студбилета
  агрументы: год поступления, группа, фио
  
  double MinAVG(string [] marks)
    {
    code;
    double i = 1.2;
    return i;
  }
  тд: плав запятая
  имя: минимальное среднее значение
  агрументы: массив оценок
  
  int[] GetCountDisease (List<Mark> marks)
    {
    code;
    int[] i = {1, 2, 3};
    return i;
  }
  тд: массив чисел
  имя:получить число пропусков
  агрументы:список оценок
  
  фунцкия мб в 3 состояниях:
  1) обьявление (пока не используем)
  2) структура фунциии: перчисляются 3 части функции {код}. Если тд функции не void, обяхательно есть слово return, после которого идет элемент того же тд, что и фунция
  3) вызов в мейне: тд функции убирается как и тип данных аргументов, однако содается переменная с тд что и у returna, чтобы в нее мб сохранить результат работы функции, ее же можно выводить на экран. Арументы фунции должны быть предварительно обьявлены в мейн
  
 static void Main(string[] args)
  {
    DateTime now = DateTime;
    List<string> students = new students;
    GetMarks (now, students)
    List<mark>res = new res;
    Console.Write(res)
  
    List<Mark> marks = new marks;
    GetCountTruancy(marks)
    int[]res = {res};
    Console.Write(res)
  
    int year = 2020;
    int group = (190, 220)
    string fio = "As As As"
    GetStudNumber (year, group, fio)
    string res = "res"
    Console.Write(res)
  
    string [] marks = {marks}
    MinAVG( marks)
    double res = 1.0
    Console.Write(res)
  
    List<Mark> marks = new marks
    GetCountDisease (marks)
    int[] res = {res};
    Console.Write(res)
  }
  
  
  
  
