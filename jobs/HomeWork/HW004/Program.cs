// Выяснить является ли число чётным
int n;
Console.WriteLine("введите число: ");
n = int.Parse(Console.ReadLine());

if(n % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}