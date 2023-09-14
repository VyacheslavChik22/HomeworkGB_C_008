// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Массив 4 на 4 заполняется спирально: ");

int n = 4;
int[,] spiralFilledArray = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;

//step1
while (temp <= spiralFilledArray.GetLength(0) * spiralFilledArray.GetLength(1))
{
    spiralFilledArray[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < spiralFilledArray.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= spiralFilledArray.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > spiralFilledArray.GetLength(1) - 1)
        j--;
    else
        i--;
}

//step2
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($"0{array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//step3
PrintArray(spiralFilledArray);