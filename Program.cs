//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользовател

// Console.WriteLine("Введите элементы через пробел");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int number = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i]>0)
//     {
//         number++;
//     }
// }
// Console.WriteLine($"Количетво положительных {number}");

// программа, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите коэффициент k первого уравнения y=kx+b ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b первого уравнения y=kx+b ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k второго уравнения y=kx+b ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b второго уравнения y=kx+b ");
double b2 = Convert.ToInt32(Console.ReadLine());

if(k1 == k2 & b1 == b2)
{
    Console.WriteLine("Прямые совпадают, точек пересечения бесконечное множество");
}
 else if(k1 == k2)
{
    Console.WriteLine("Прямые параллельны, точек пересечения нет");
}
else
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения x = {x}, y = {y}");
}