Console.WriteLine("Введите номерокъ");
int TripleA = Convert.ToInt32(Console.ReadLine());
if (TripleA == 1)
{
    Console.WriteLine("введите последовательность чисел через пробел");
    var a = Console.ReadLine();
    string[] da = a.Split(' ');
    int b = 0;
    foreach (var i in da)
    {
        var ii = Convert.ToInt32(i);
        b += ii;
    }
    Console.WriteLine(b);
}
else if (TripleA == 2)
{
    Console.WriteLine("Введите количество дней");
    var fx = Convert.ToDouble(Console.ReadLine());
    var f = Convert.ToDouble(10);
    var fy = f;
    if (fx == 1)
    {
        Console.WriteLine("10");
    }
    else if (fx == 0) 
    {
        Console.WriteLine("спортсмен жестб обленился");
    }
    else if (fx < 0) 
    {
        Console.WriteLine("тут что-то не так");
    }
    else
    {
        for (int i = 1; i<fx; i++)
        {
            fy += fy / 10;
            f += fy;
        }
        Console.WriteLine(f);
    }
}
else if (TripleA == 3)
{
    Console.WriteLine("Введите n");
    var ni = Convert.ToDouble(Console.ReadLine());
    int f = 1;
    for (int i = 1; i < ni; i++)
    {
        f = f * 2;
    }
    Console.WriteLine(f);
}
else if (TripleA == 4)
{
    Console.WriteLine("введите последовательность чисел через пробел");
    var a = Console.ReadLine();
    Console.WriteLine("введите искомое число");
    var ki = Convert.ToDouble(Console.ReadLine());
    string[] da = a.Split(' ');
    int b = 0;
    foreach (var i in da)
    {
        var ii = Convert.ToDouble(i);
        if (ii == ki) { b++; }
    }
    Console.WriteLine(b);
}
else if (TripleA == 5)
{
    int lap = 64;
    int x = 0;
    for (int i = 0; lap-(i*2)>4;  i++)
    {
        x += 1;
    }
    Console.WriteLine(x);
}
else if (TripleA == 6)
{
    Console.WriteLine("введите последовательность чисел через пробел");
    var a = Console.ReadLine();
    string[] da = a.Split(' ');
    int b = 0;
    foreach (var i in da)
    {
        var ii = Convert.ToInt32(i);
        b = b * ii;
    }
    Console.WriteLine(b);
}