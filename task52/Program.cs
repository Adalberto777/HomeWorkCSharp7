// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

int[,] GetMatrix(int lines, int columns, int minValue, int maxValue) //функция GetArray с параметрами: размер, мин элемент, макс элемент создает массив 
{                                                    //заполненный случайными числами
  int[,] result = new int[lines, columns];

  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
        result[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return result;
}


void PrintMatrix (int[,] matrix1)  //вывод двумерного массива, заполненного случайными цифрами
{
    for (int i = 0; i < matrix1.GetLength(0); i++)  // matrix.GetLength(0) конструкция выдает количество строк или столбцов 
    {                                              // в зависимости 0 или 1 (0- строки, 1 столбцы)
        for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        Console.Write(matrix1[i, j] + "\t");
    }
    Console.WriteLine();
    }
}

int[,] matrix = GetMatrix(5, 6, -10, 10); //1-строки 2-столбцы 3-минимальное число 4-максимальное число
PrintMatrix(matrix);

void FindAverageColumn(int[,] array) //вычисление и вывод среднего арифметического каждого столбца
{
    for (int j = 0; j < array.GetLength(1); j++)  // matrix.GetLength(0) конструкция выдает количество строк или столбцов 
    {                                              // в зависимости 0 или 1 (0- строки, 1 столбцы)
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += (double)array[i, j] / array.GetLength(0);            
        }    
        Console.Write($"среднее арифметическое {j}-го столбца = ");   
        Console.WriteLine($"{Math.Round(average, 1)}      ");
    }
}

FindAverageColumn(matrix); 

