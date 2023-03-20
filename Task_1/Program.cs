// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

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

// Меняем первую и последнюю строку местами
int[,] MoveFirstRowToLast(int[,] tableArray)
{
    int rows = tableArray.GetLength(0);
    int columns = tableArray.GetLength(1);
    for(int j = 0; j < columns; j++)
    {
        int temporary = tableArray[0, j];
        tableArray[0, j] = tableArray[rows - 1, j];
        tableArray[rows - 1, j] = temporary;
    }
    
    return tableArray;
}


Console.Clear();
Console.Write("Количество строк массива (m): ");
int m = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов массива (m): ");
int n = int.Parse(Console.ReadLine());

int[,] tableArray = CreateAndFillIntTableArray(m, n, 0, 9);
PrintIntTableArray(tableArray);
Console.WriteLine();
MoveFirstRowToLast(tableArray);
PrintIntTableArray(tableArray);

