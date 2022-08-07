// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int y = b*b;
int result = y;
Console.WriteLine( "Квадрат числа (b) равен: " + y );

Console.WriteLine("Сравним квадрат числа (b) c числом (a)");


if( y == a )
{
    Console.WriteLine( (y == a) + " число (a) является квадратом числа (b)");
}

if(y != a)
{
    Console.WriteLine("Не верно!");
}
