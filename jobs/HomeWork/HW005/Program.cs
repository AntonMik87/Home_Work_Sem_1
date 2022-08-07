// Показать числа от -N до N
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
int a = (-n - 1 );

while (a < n - 1)
{
 a = a + 1;
 Console.Write( a  +  ",");

}
Console.Write(n);