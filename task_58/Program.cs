/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
//Произведение значений элементов двух матриц возможно лишь в случае, равенства количества строк и столбцов этих матриц.
//step1
int EnterNumbers(string phrase)
{
    Console.Write(phrase);
    return int.Parse(Console.ReadLine()!);
}

//step2
int[,] CreateMatrixOne(int rows, int columns)
{
    int[,] matrixOne = new int[rows, columns];
    return matrixOne;
}

int[,] CreateMatrixTwo(int rows, int columns)
{
    int[,] matrixTwo = new int[rows, columns];
    return matrixTwo;
}

//step3
int[,] InitializationMatrixOne(int[,] matrixOne)
{
    Random rnd = new Random();
    for (var i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (var j = 0; j < matrixOne.GetLength(1); j++)
        {
            matrixOne[i, j] = rnd.Next(1, 10);
        }
    }

    return matrixOne;
}

int[,] InitializationMatrixTwo(int[,] matrixTwo)
{
    Random rnd = new Random();
    for (var i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (var j = 0; j < matrixTwo.GetLength(1); j++)
        {
            matrixTwo[i, j] = rnd.Next(1, 10);
        }
    }
    return matrixTwo;
}

//step4
void PrintMatrixes(int[,] matrixOne, int[,] matrixTwo)
{
    for (var i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (var j = 0; j < matrixOne.GetLength(1); j++)
        {
            Console.Write(matrixOne[i, j] + " ");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
    for (var i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (var j = 0; j < matrixTwo.GetLength(1); j++)
        {
            Console.Write(matrixTwo[i, j] + " ");
        }

        Console.WriteLine();
    }
}

//step5
int[,] MatrixMultiplication(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] resultMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    if (matrixOne.GetLength(0) != matrixTwo.GetLength(1))
    {
        Console.WriteLine("Количество строк первой матрицы не равно количеству столбцов второй матрицы!");
    }
    else
    {
        for (int i = 0; i < matrixOne.GetLength(0); i++)
        {
            for (int j = 0; j < matrixTwo.GetLength(1); j++)
            {
                resultMatrix[i, j] = 0;

                for (int k = 0; k < matrixOne.GetLength(0); k++)
                {
                    resultMatrix[i, j] += matrixOne[i, k] * matrixTwo[k, j];
                }
            }
        }
    }
    return resultMatrix;
}

//step6
void PrintText(int[,] matrixMultiply)
{
    bool flag = false;
    for (var i = 0; i < matrixMultiply.GetLength(0); i++)
    {
        for (var j = 0; j < matrixMultiply.GetLength(1); j++)
        {
            if (matrixMultiply[i, j] != 0) flag = true;
        }
    }
    if (flag == true) Console.WriteLine("Результат произведения матриц: ");
}

//step7
void PrintResult(int[,] matrixMultiply)
{
    for (var i = 0; i < matrixMultiply.GetLength(0); i++)
    {
        for (var j = 0; j < matrixMultiply.GetLength(1); j++)
        {
            if (matrixMultiply[i, j] != 0) Console.Write($"{matrixMultiply[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Произведение значений элементов двух матриц возможно лишь в случае равенства количества строк одной и столбцов другой матриц.");
int EnteredRowForFirstMatrix = EnterNumbers("Сколько будет строк в первой матрице? -> ");
int EnteredColumnsForFirstMatrix = EnterNumbers("Сколько будет колонок в первой матрице? -> ");
int EnteredRowForSecondMatrix = EnterNumbers("Сколько будет строк во второй матрице? -> ");
int EnteredColumnsForSecondMatrix = EnterNumbers("Сколько будет колонок в первой матрице? -> ");
int[,] createMatrixOne = CreateMatrixOne(EnteredRowForFirstMatrix, EnteredColumnsForFirstMatrix);
int[,] createMatrixTwo = CreateMatrixTwo(EnteredRowForSecondMatrix, EnteredColumnsForSecondMatrix);
int[,] initMatrixOne = InitializationMatrixOne(createMatrixOne);
int[,] initMatrixTwo = InitializationMatrixTwo(createMatrixTwo);
PrintMatrixes(initMatrixOne, initMatrixTwo);
int[,] resultMatrixMultiplication = MatrixMultiplication(initMatrixOne, initMatrixTwo);
PrintText(resultMatrixMultiplication);
PrintResult(resultMatrixMultiplication);
