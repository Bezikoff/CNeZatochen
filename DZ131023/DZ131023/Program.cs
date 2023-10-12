Console.WriteLine("при а = 1.1");
for (var i = Convert.ToDouble(0); i < 10; i+= 0.5)
{
    Console.WriteLine(((i * 1.1) + Math.Log(1 + (i * 1), 10)) / (1 + Math.Pow(i * 1.1, 2)));
}
Console.WriteLine("при а = 1.6");
for (var i = Convert.ToDouble(0); i < 10; i += 0.5)
{
    Console.WriteLine(((i * 1.6) + Math.Log(1 + (i * 1), 10)) / (1 + Math.Pow(i * 1.6, 2)));
}
