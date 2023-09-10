/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int EnterNumbers(string phrase)
{
    Console.Write(phrase);
    return int.Parse(Console.ReadLine()!);
}

//*
int[,] CreateAddInitializationArray(int rows, int columns)
{
    int[,] createdArray = new int[rows, columns];
    int amountElements = rows * columns;
    int temp = 1;
    int count = 0;
    for (int i = 0; i < createdArray.GetLength(0); i++)
    {
        for (int j = 0; j < createdArray.GetLength(1); j++)
        {
            createdArray[i, j] += temp;
            count++;
            temp += count;

        }
    }
    return createdArray;
}

//**
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

//***
void ReversRowsArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(1) - 1; k++)
            {
                if (inputArray[i, k] < inputArray[i, k + 1])
                {
                    int temp = inputArray[i, k + 1];

                    inputArray[i, k + 1] = inputArray[i, k];
                    inputArray[i, k] = temp;
                }
            }
        }
    }
}
int rowsEntered = EnterNumbers("Сколько будет строк в массиве? -> ");
int columnsEntered = EnterNumbers("Сколько будет колонок в массиве? -> ");
int[,] arrayForTask = CreateAddInitializationArray(rowsEntered, columnsEntered);
Console.WriteLine();
Console.WriteLine("Вот, массив по вашим параметрам готов!\n");
PrintArray(arrayForTask);
ReversRowsArray(arrayForTask);
Console.WriteLine();
Console.WriteLine("Вот, массив с упорядоченными по убыванию строками!\n");
PrintArray(arrayForTask);