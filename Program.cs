// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void FillArray( int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//       for (int j = 0; j < array.GetLength(1); j++)
//          array[i,j] = new Random().Next(1,10); 
// }
// void PrintArray( int [,] array)
// {
//     for ( int i = 0; i< array.GetLength(0); i++)
//     {
//     for (int j = 0; j < array.GetLength(1); j++)
//     Console.Write($"{array[i,j],3}\t");
//     Console.WriteLine();
//     }
   
// }

// void Sum(int[,] array)
// { 
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum =0 ;
//         for ( int i = 0; i< array.GetLength(0); i++)
//         {
//             sum+= array[i,j];
//         }
//         Console.Write($"{ sum / array.GetLength(0),3} ;");
//     }
    

// }
    

// int [,] array = new int [4,4];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine("Среднее арифметическое элементов в каждом столбце равно:");
// Sum(array);

// -----------------------------------------------------------------


// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// int rows = ReadInt("Введите индекс строки: ");
// int colums = ReadInt("Введите индекс столбца: ");
// int[,] numbers = new int[3, 3];
// FillArray(numbers);
// PrintArray(numbers);

// if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
// else Console.WriteLine($"{rows} -> такого числа в массиве нет");



// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }