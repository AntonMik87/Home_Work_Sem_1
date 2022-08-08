// // Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("введите числа: ");
int x = int.Parse(Console.ReadLine());Console.WriteLine("Делимое: " + x);
 
int y = int.Parse(Console.ReadLine());Console.WriteLine("Делитель: " + y);
 
//x; Делимое
//y; Делитель
int z;
if (x % y == 0) 
{
     Console.Write("Кратно");
}
 
else
{
     z = x%y;
     Console.WriteLine("остаток: " + z);
}