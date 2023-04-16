//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите k1"); 
bool isParsedk1 = double.TryParse(Console.ReadLine(), out double k1); 

Console.WriteLine("Введите b1");
bool isParsedk2 = double.TryParse(Console.ReadLine(), out double b1);

Console.WriteLine("Введите k2");
bool isParsedb1 = double.TryParse(Console.ReadLine(), out double k2);

Console.WriteLine("Введите b2");
bool isParsedb2 = double.TryParse(Console.ReadLine(), out double b2);

if (!isParsedk1 || !isParsedk2 || !isParsedb1 || !isParsedb2) 
{
    Console.WriteLine("Ошибка ввода значений"); 
    return; 
}

string str = FindIntersectionPoint(k1, k2, b1, b2); 

Console.WriteLine(str);



string FindIntersectionPoint(double k1, double k2, double b1, double b2)
{
    
    string str = string.Empty; 

    double x = 0; 
    double y = 0; 

    if (k1 - k2 == 0) 
    {
        str = $"Ошибка метода - на ноль делить нельзя"; 
        return str; 
    }
    
    x = -(b1 - b2) / (k1 - k2); 
    y = k1 * x + b1; 

    str = $"Точка пересечения двух прямых находится в координате [{x}, {y}]"; 
    
    return str; 

}