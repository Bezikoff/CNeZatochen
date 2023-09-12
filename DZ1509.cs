Console.WriteLine("Введите номер задания (3, 5, 6, 7, 10, 11)");
int TripleA = Convert.ToInt32(Console.ReadLine());
if (TripleA == 3)
{
    Console.WriteLine("Номер 3 - посчитать площадь и длинну круга, зная радиус. Введите радиус");
    var R = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Длинна круга равна {R * 2 * Math.PI}, а площадь - {R * R * Math.PI}");
}
else if (TripleA == 5)
{
    Console.WriteLine("Номер 5 - найти из 2-х числе среднее арифметическое их квадратов и среднее геометрическое их модулей. Введите 2 числа");
    var a = Convert.ToInt32(Console.ReadLine());
    var b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"среднее арифметическое квадратов равно {(a*a+b*b)/2}, а среднее геометрическое модулей - {Math.Sqrt(Math.Abs(a)*Math.Abs(b))}");
}
else if (TripleA == 6)
{
    Console.WriteLine("Номер 6 - найти расстояние меж 2-мя точками. Введите х1, у1, х2, у2");
    var a = Convert.ToInt32(Console.ReadLine());
    var b = Convert.ToInt32(Console.ReadLine());
    var c = Convert.ToInt32(Console.ReadLine());
    var d = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Расстояние равно {Math.Sqrt(Math.Pow(c - a, 2) + Math.Pow(d - b, 2))}");
}
else if (TripleA == 7)
{
    Console.WriteLine("Номер 7 - найти сумму, разность, произведение и частное. Введите 2 числа");
    var a = Convert.ToInt32(Console.ReadLine());
    var b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"сумма равна {a + b}, разность равна {a - b}, произведение равно {a*b} и частное равно {a/b}");
}
else if (TripleA == 10)
{
    Console.WriteLine("Номер 10 - найти площадь круга, зная длинну окружности. Введите длинну окружности");
    var a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Площадь круга равна {Math.Pow(a/2, 2) / Math.PI}");
}
else if (TripleA == 11)
{
    Console.WriteLine("Номер 11 - найти площадь кольца, зная внутренний и внешний радиусы. Введите сначала внешний, потом внутренний радиус");
    var R = Convert.ToInt32(Console.ReadLine());
    var rm = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Площадь равна {2 * Math.PI * (R - rm)}");
}
else
{
    Console.WriteLine("Нету такого номера!");
}