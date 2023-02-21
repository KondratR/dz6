//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

System.Console.WriteLine("Введите число b1 ");
var b1 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Введите число k1 ");
var k1 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Введите число b2 ");
var b2 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Введите число k2 ");
var k2 = Convert.ToDouble(System.Console.ReadLine());

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
System.Console.WriteLine(Convert.ToString(x), Convert.ToString(y));