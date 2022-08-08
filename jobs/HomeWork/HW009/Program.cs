// Удалить вторую цифру трёхзначного числа
Console.WriteLine("введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());
int x = n;
x = (x/10)-(x%100/10)+x%10;

Console.WriteLine("Удалено второе число: " + x);


