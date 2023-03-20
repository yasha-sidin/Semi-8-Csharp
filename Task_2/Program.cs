// Задача 2: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


void PrintIntTableArray(int[,] tableArray)
{
    int rows = tableArray.GetLength(0);
    int columns = tableArray.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            if(j == tableArray.GetLength(1) - 1)
            {
                Console.WriteLine($"{tableArray[i, j]}\t");
                break;
            }
            Console.Write($"{tableArray[i, j]}, ");
        }
    }
}

// -----------------------------------------------------------------------------------------

// Заполнить двумерный массив случайными числами
int[,] CreateAndFillIntTableArray(int countRows, int countColumns, int startRange, int endRange)
{
    int[,] tableArray = new int[countRows, countColumns];
    for(int i = 0; i < countRows; i++)
    {
        for(int j = 0; j < countColumns; j++)
        {
            tableArray[i, j] = new Random().Next(startRange, endRange + 1);
        }
    }

    return tableArray;
}

// -----------------------------------------------------------------------------------------

// Транспонируем
int[,] Transponation(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int shift = 0;
    for(int i = 0; i < rows; i++)
    {
        for(int j = shift; j < columns; j++)
        {
            int temporary = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temporary;
        }
        shift++;
    }

    return matrix;
}

Console.Clear();
Console.Write("Количество строк массива (m): ");
int m = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов массива (m): ");
int n = int.Parse(Console.ReadLine());

int[,] tableArray = CreateAndFillIntTableArray(m, n, 0, 9);
PrintIntTableArray(tableArray);
Console.WriteLine();
Transponation(tableArray);
PrintIntTableArray(tableArray);

