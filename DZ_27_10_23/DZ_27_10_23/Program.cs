Console.WriteLine("Введите номер задания");
double BoomBox = Convert.ToDouble(Console.ReadLine());
if (BoomBox == 25)
{
    Console.WriteLine("введите размер первого параллелепипеда через пробел (высота, длина, ширина)");
    string aaa = Console.ReadLine();
    string[] aa = aaa.Split(" ");
    double a = Convert.ToDouble(aa[0]) * Convert.ToDouble(aa[1]) * Convert.ToDouble(aa[2]);
    Console.WriteLine("введит размер второг параллелепипеда через пробел (высота, длина, ширина)");
    string bbb = Console.ReadLine();
    string[] bb = bbb.Split(" ");
    double b = Convert.ToDouble(aa[0]) * Convert.ToDouble(aa[1]) * Convert.ToDouble(aa[2]);
    if (a > b)
    {
        Console.WriteLine("первый параллелепипед больше");
    }
    else { Console.WriteLine("второй паралелепипед больше"); }
}
else if (BoomBox == 20)
{
    Console.WriteLine("Введите через пробел: а, b, c, m, n");
    string aa = Console.ReadLine();
    string[] a = aa.Split(" ");
    if (Convert.ToDouble(a[0]) * Convert.ToDouble(a[3]) * Convert.ToDouble(a[3]) + Convert.ToDouble(a[1]) * Convert.ToDouble(a[3]) + Convert.ToDouble(a[2]) == Convert.ToDouble(a[4]))
    {
        Console.WriteLine("Такая точка может лежать в данной функции");
    }
    else { Console.WriteLine("Такая точка не может лежать в данной функции"); }
}
else if (BoomBox == 4)
{
    Console.WriteLine("Не смог решить");
}
else if (BoomBox == 11)
{
    double a = (1 + Math.Sin(0.1));
    for (double i = 0.2;i <=10; i+=0.1 ) 
    {
        a *= 1 + Math.Sin(i);
    }
    Console.WriteLine(a);
}
else if (BoomBox == 22)
{
    Console.WriteLine("Введите последовательность чисел через пробел");
    string aa = Console.ReadLine();
    string[] a = aa.Split(' ');
    Console.WriteLine("Введите последнюю цифру");
    char aaa = Convert.ToChar(Console.ReadLine());
    double c = 0;
    foreach (var b in a)
    {
        if (b[-1] == aaa) { c += Convert.ToDouble(b); }
    }
    Console.WriteLine(c);
}