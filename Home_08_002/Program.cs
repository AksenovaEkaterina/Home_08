// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    if (row_size == column_size)
    {
        Console.WriteLine("Задайте прямоугольный массив ");
    }
    else
    {
        for (int i = 0; i < row_size; i++)
        {
            for (int j = 0; j < column_size; j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,] MassNum(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];


    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;

}

int MatrRowSumm(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int Summ = 0;
    int max = 0;
    int RowSumMax = 0;

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Summ += arr[i, j];

        }
        if (Summ > max)
        {
            max = Summ;
            RowSumMax = i+1;
        }
        Summ = 0;
    }

     Console.Write($"Максимальная сумма элементов в стоке № {RowSumMax}" );
    return Summ;
}


Console.Write("введите количество строк прямоугольного массива ");
int row = int.Parse(Console.ReadLine());
Console.Write("введите количество столбцов прямоугольного массива ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNum(row, column, 0, 11);
Print(arr_1);
Console.WriteLine();
MatrRowSumm(arr_1);