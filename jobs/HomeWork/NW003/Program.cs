// Найти максимальное из трех чисел
int a = 1;
int b = 5;
int c = 8;

int max=a;

if (a>max)max=a;
if (b>max)max=b;
if (c>max)max=c;

Console.Write("max= ");
Console.WriteLine(max);