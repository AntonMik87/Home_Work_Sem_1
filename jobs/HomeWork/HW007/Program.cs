// Показать вторую цифру трёхзначного числа
int n;
Console.WriteLine("введите трехзначное число: ");
n = int.Parse(Console.ReadLine());
int x = n/10;
x = x%10;

Console.Write("вторая цифра: " + x);