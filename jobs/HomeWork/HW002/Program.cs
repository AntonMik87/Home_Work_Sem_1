// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите число от 1 до 7");
int a = int.Parse(Console.ReadLine());

string m = "Понедельник";
string t = "Вторник";
string w = "Среда";
string th = "Четверг";
string f = "Пятница";
string sa = "Суббота";
string su = "Воскресенье";

if (a == 1)
{
   Console.WriteLine(m);
}
if (a == 2)
{
   Console.WriteLine(t);
}
if (a == 3)
{
   Console.WriteLine(w);
}
if (a == 4)
{
   Console.WriteLine(th);
}
if (a == 5)
{
   Console.WriteLine(f);
}
if (a == 6)
{
   Console.WriteLine(sa);
}
if (a == 7)
{
   Console.WriteLine(su);
}