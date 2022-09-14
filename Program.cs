//Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.



/*Console.WriteLine("Введите кол-во строк");
int userInputRows = Convert.ToInt32(Console.ReadLine());
int rows = userInputRows;    // количество строк

Console.WriteLine("Введите кол-во столбцов");
int userInputColumns = Convert.ToInt32(Console.ReadLine());
int columns = userInputColumns;        // количество столбцов

int[,] array = new int[rows, columns];
Random random = new Random();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = random.Next(100);
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}

int[,] array = new int[3, 3];
Random random = new Random();

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        array[i, j] = random.Next(10);
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите номер элемента в строке");
int userInputRows = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine("Введите номер элемента в столбце");
int userInputcolumns = Convert.ToInt32(Console.ReadLine()) - 1;



if (userInputRows > array.GetLength(0) || userInputcolumns > array.GetLength(1))
{
    Console.WriteLine("Значение искомого элемента лежит за пределами массива");
}
else
{
    Console.WriteLine("Значение искомого элемента");
    Console.WriteLine(array[userInputRows, userInputcolumns]);

}
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] array = new int[3, 3];
Random random = new Random();

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        array[i, j] = random.Next(10);
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}

for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage = (avarage + array[i, j]);
    }
    avarage = avarage / 3;
    Console.Write("{0:0.0}", avarage + "; ");
}

