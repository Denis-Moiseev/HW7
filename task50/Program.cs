void PrintNumPosition(int[,] array, int num)
{
    bool notFound = true;
    int positionI = 0;
    int positionJ = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                notFound = false;
                positionI = i;
                positionJ = j;
                Console.WriteLine($"{num} -> array[{positionI},{positionJ}]");
            }
        }
    }
    if (notFound) Console.WriteLine($"{num} -> такого числа в массиве нет");
}

void Print2DArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}\t", -1);
            }
            Console.WriteLine();
        }
    }

    int[,] Create2DArray(int rows, int columns, int startValue, int finishValue)
    {
        int[,] matrix = new int[rows, columns];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(startValue, finishValue + 1);
            }
        }
        return matrix;
    }

    int GetInput(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    int m = GetInput("Введите количество строк массива: ");
    int n = GetInput("Введите количество столбцов массива: ");
    int num = GetInput("Введите искомое число: ");
    int[,] array = Create2DArray(m, n, 1, 9);
    Print2DArray(array);
    PrintNumPosition(array, num);