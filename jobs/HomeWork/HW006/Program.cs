// Показать последнюю цифру трёхзначного числа
int n;
Console.WriteLine("введите трехзначное число: ");
n = int.Parse(Console.ReadLine());
int x = n % 10;

Console.Write("последняя цифра: " + x);

