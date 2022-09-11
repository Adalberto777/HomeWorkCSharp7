//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет


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

int[,] matrix = GetMatrix(5, 5, -99, 99); //1-строки 2-столбцы 3-минимальное число 4-максимальное число
PrintMatrix(matrix);

Console.WriteLine("Введите строку искомого элемента");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите столбец искомого элемента");
int y = int.Parse(Console.ReadLine());

void FindElement(int[,] array, int x1, int y1) // поиск в случайном массиве числа по введенным пользователем индексам
{
   if(x1 > array.GetLength(0) - 1 | y1 > array.GetLength(1) - 1 | x1 < 0 | y1 <0)
   {
        Console.WriteLine("в массиве нет элемента с такими параметрами");
   }

   else
   {
        Console.WriteLine(array[x, y]);
   }
}



Console.WriteLine(); 
FindElement(matrix, x, y);
