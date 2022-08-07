// Удалить вторую цифру трёхзначного числа
int n;
Console.WriteLine("введите трехзначное число: ");
n = int.Parse(Console.ReadLine());
int x = n;
x = (x/10)-(x%100/10)+x%10;

Console.Write("Удалено второе число: " + x);


