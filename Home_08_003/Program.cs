//Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
void PrintArray_matr1(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray_matr1(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray_matr2(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray_matr2(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(10, 21);
        }
    }
}

void NewArray(int[,] array_1, int[,] array_2)
{
    int row_1 = array_1.GetLength(0);
    int column_1 = array_1.GetLength(1);
    int row_2 = array_2.GetLength(0);
    int column_2 = array_2.GetLength(1);
    int sum = 0;
    int u = 0;
    int l = 0;
    for (int i = 0; i < row_1; i++)
    {
        for (int j = 0; j < column_1; j++)
        {
            for (int n = 0; n < column_2; n++)
            {
                for (int m = 0; m < row_2; m++)
                {
                    sum = sum + array_1[i, u] * array_2[l, n];
                    u++;
                    l++;
                }
                Console.Write($"{sum} ");
                sum = 0;
                u = 0;
                l = 0;
            }
            break;
        }
        Console.WriteLine();
    }
}

int[,] array_1 = new int[2, 3];
int[,] array_2 = new int[3, 4];
FillArray_matr1(array_1);
PrintArray_matr1(array_1);
Console.WriteLine();
FillArray_matr2(array_2);
PrintArray_matr2(array_2);
Console.WriteLine();
NewArray(array_1, array_2);

