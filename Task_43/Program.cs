/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double FindX(double k1, double k2, double b1, double b2)
{
    double x;
    x = (b2-b1)/(k1-k2);
    return x; 
}

double FindY(double x, double k1, double b1)
{
    double y = k1 *x + b1;
    return y;
}

double k1, k2, b1, b2;
double x, y;
Console.WriteLine("Введите коэффиценты первого уровнения y = k1 * x + b1: ");
Console.Write("k1=");
k1 = double.Parse(Console.ReadLine());
Console.Write("b1=");
b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффиценты второго уровнения y = k2 * x + b2: ");
Console.Write("k2=");
k2 = double.Parse(Console.ReadLine());
Console.Write("b2=");
b2 = double.Parse(Console.ReadLine());
x = FindX(k1, k2, b1, b2);
y = FindY(x, k1, b1);
Console.WriteLine($"Координаты точки пересечения заданных прямых ( {x} , {y} )");