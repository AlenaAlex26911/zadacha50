// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1,7 -> такого числа в массиве нет (1 строчка, 7 столбец)


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[3, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();

}
if (rows <= matrix.GetLength(0) && columns <= matrix.GetLength(1))
{
    Console.WriteLine($"Число в {rows} строке и {columns} столбце равно {matrix[rows - 1, columns - 1]}");
}
else Console.WriteLine($"Числа в {rows} строке и {columns} столбце нет");
