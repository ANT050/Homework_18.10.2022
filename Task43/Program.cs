/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

//Ввод числа с консоли с проверкой на корректность
int PointsOfStraightLines(string message)
{
    int result = 0;
    bool isCorrect = false;

    while (!isCorrect)
    {
        Console.Write(message);
        isCorrect = int.TryParse(Console.ReadLine(), out result);

        if (!isCorrect)
            Console.Write("\nВведите корректное число!\n");
    }

    return result;
}

//Нахождение точки пересечения двух прямых (линейная функция)
//Первый элемент точка X, второй элемент точка Y

(double, double) CoordinatesOfIntersectionPoint(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)

        throw new Exception("\nПоменяйте значения k1 и k2, при использовании линейной функции они не могут быть равны!!!\n");

    double coordinateX = Math.Round(((b2 - b1) / (k1 - k2)), 2);
    double coordinateY = Math.Round((k2 * coordinateX + b2), 2);

    return (coordinateX, coordinateY);
}

try
{
    double b1 = PointsOfStraightLines("\nВведите число b1: ");
    double k1 = PointsOfStraightLines("Введите число k1: ");
    double b2 = PointsOfStraightLines("Введите число b2: ");
    double k2 = PointsOfStraightLines("Введите число k2: ");
    
    (double X, double Y) = CoordinatesOfIntersectionPoint(b1, k1, b2, k2);

    Console.WriteLine($"\nТочка пересечения двух прямых имеет координаты: ({X}; {Y})\n");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
