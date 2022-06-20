// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

void PrintArray(int[,] matr)
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

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void NewArray(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int n = 0; n < column-j-1; n++)
            {
                if (array[i, n] < array[i, n + 1])
                {
                    (array[i, n], array[i, n + 1]) = (array[i, n + 1], array[i, n]);
                }
            }
            Console.Write($"{array[i, j]} ");
        }
           Console.WriteLine();

    }
    
}


int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
NewArray(array);


