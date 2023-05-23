// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello");
var sorok = File.ReadAllLines("Datas\\Kutyak.csv");

foreach (var sor in sorok)
{
    Console.WriteLine(sor);
}
Console.WriteLine();