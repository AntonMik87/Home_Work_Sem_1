// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int n = new Random().Next(10, 99); // 1 2 3 4 ... 98
Console.WriteLine("Случайное число число: " + n);

int x = n%10;
Console.WriteLine(x);
int y = n/10;
Console.WriteLine(y);
int max = x;
if ( x > y ) max = x;
if ( y > x ) max = y;
Console.Write("Max: " + max);