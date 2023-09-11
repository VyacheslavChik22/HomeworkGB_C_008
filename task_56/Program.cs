/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

//step1
int EnterNumbers(string phrase)
{
    Console.Write(phrase);
    return int.Parse(Console.ReadLine()!);
}

//step2
int[,] CreateArray(int rows, int columns)
{
    int[,] arrayForWork = new int[rows, columns];
    return arrayForWork;
}

//step3
int[,] InitializationArray(int[,] arrayForInitialization)
{
    int rows = arrayForInitialization.GetLength(0);
    int columns = arrayForInitialization.GetLength(1);
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arrayForInitialization[i, j] = rnd.Next(rows * columns + 1);
        }
    }
    return arrayForInitialization;
}

//step4
void printArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j]}\t");
        }
        Console.WriteLine("");
    }
}

//step5
void FindingTheRowWithTheSmallestSumOfElements(int[,] inputArray)
{
    int[] tempArr = new int[inputArray.GetLength(0)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sum += inputArray[i, j];
        }
        tempArr[i] = sum;
    }

    int min = tempArr[1];
    int row = 1;
    for (int i = 0; i < tempArr.Length; i++)
    {
        if (tempArr[i] < min)
        {
            min = tempArr[i];
            row += i;
        }
    }
    Console.Write($"Минимальная сумма {min} найдена в строке №{row}");
}

//***
int rowsEntered = EnterNumbers("Сколько будет строк в массиве? -> ");
int columnsEntered = EnterNumbers("Сколько будет колонок в массиве? -> ");
int[,] theResultingArray = CreateArray(rowsEntered, columnsEntered);
int[,] arrayForTask = InitializationArray(theResultingArray);
Console.WriteLine("Ваш массив: ");
printArray(arrayForTask);
FindingTheRowWithTheSmallestSumOfElements(arrayForTask);