// По двум заданным числам проверять является ли первое квадратом второго
int a = 4;
int b = 2;
Console.WriteLine("Даны два числа a = 4 и b = 2. Найдем квадрат чтсла (b): ");
int y = b*b;
int result = y;
Console.WriteLine("Квадрат числа (b) равен: ");
Console.WriteLine(y);

Console.WriteLine("Сравним квадрат числа (b) c числом (a)");


if( y == a )
{
    Console.WriteLine("Ура! (y = a) Квадрат число (a) является квадратом числа (b)");
}

if(y != a)
{
    Console.WriteLine("Не верно!");
}
