/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4*/

/*ПЕРВЫЙ СПОСОБ РЕШЕНИЯ ДАННОГО УСЛОВИЯ*/

Console.Write("\nВведите числа через пробел: ");
string number = Console.ReadLine();
string[] temporary = number.Split(' ');

int[] myArray = new int[temporary.Length];
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = int.Parse(temporary[i]);
}

Console.Write("\nПользователь ввел числа ");
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i]);
    if (i != myArray.Length - 1)
        Console.Write(", ");
}
int amountOfNumbers = 0;

for (int i = 0; i < myArray.Length; i++)
{

    if (myArray[i] > 0)
    {
        amountOfNumbers++;
    }
}

Console.Write($" в которых {amountOfNumbers} положительных числа\n");
Console.WriteLine();


/*ВТОРОЙ СПОСОБ РЕШЕНИЯ ДАННОГО УСЛОВИЯ*/


/*
// Ввод числа, которое задает размерность массива и проверка на корректность
int EnteringNumbers(string message)
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

//Печать рандомного массива
void PrintMyArray(int[] myArray)
{
    Console.Write("Случайные рандомные числа [от -100 до 100]: ");

    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i]);
        if (i != myArray.Length - 1)
            Console.Write(", ");
    }

    Console.WriteLine();
}

//Создание/инициализация массива
int[] InitMyArray(int value)
{
    int[] myArray = new int[value];
    Random rnd = new Random();

    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = rnd.Next(-100, 101);
    }

    return myArray;
}

//Подсчет количества чисел больших 0
int PositiveNumbers(int[] myArray)
{
    int numbers = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > 0)
            numbers++;
    }
    return numbers;
}

int value = EnteringNumbers("\nВведите число, задающее количество случайных чисел: ");
int[] array = InitMyArray(value);
PrintMyArray(array);

int positiveNumb = PositiveNumbers(array);
Console.WriteLine($"\nКоличество четных чисел в массиве: {positiveNumb}\n");

*/
