Console.WriteLine("введите номерок");
var TripleA = Convert.ToDouble(Console.ReadLine());
if (TripleA == 4)
{
    string[] ni = { "zero", "one", "two", "three", "четыре", "five", "six", "seven", "eight", "nine" };
    Console.WriteLine("Введите число от 0 до 9");
    Console.WriteLine(ni[Convert.ToInt32(Console.ReadLine())]);
}
else if (TripleA == 5)
{
    string[] ni = { "январь", "февраль", "март", "апрель", "май", "ИЮНЬ!!!!! КАНИКУЛЫ!!!", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь"};
    Console.WriteLine("Введите номер месяца");
    Console.WriteLine(ni[Convert.ToInt32(Console.ReadLine()) - 1]);
}
else if (TripleA == 6)
{
    string[] ni = { "плохо", "неудовлетворительно", "удовлетворительно", "хорошо", "отлично"};
    Console.WriteLine("Введите оценку");
    Console.WriteLine(ni[Convert.ToInt32(Console.ReadLine()) - 1]);
}
