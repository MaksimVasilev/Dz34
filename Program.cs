
// Задача 54. Упорядочить по убыванию элемент каждой строки двухмерного массива.

// int[,] array = new int[3, 4];
// FillArray(array);
// PrintArray(array);
// Sort(array);
// Console.WriteLine();
// PrintArray(array);


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


// void Sort(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int m = 0; m < array.GetLength(1) - 1; m++)
//             {
//                 if (array[i, m] < array[i, m + 1])
//                 {
//                     int temp = array[i, m + 1];
//                     array[i, m + 1] = array[i, m];
//                     array[i, m] = temp;
//                 }
//             }
//         }
//     }
// }


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }





// Задача 56. Прямоугольный массив. Найти строку с наименьшей суммой элементов.


// Console.WriteLine("Введите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m ");
// int n = InputNumbers("Введите n ");


// int[,] array = new int[m, n];
// FillArray(array);
// PrintArray(array);

// int minSum = 0;
// int sum = SumElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSum = SumElements(array, i);
//   if (sum > tempSum)
//   {
//     sum = tempSum;
//     minSum = i;
//   }
// }

// Console.WriteLine($"\n{minSum+1} - строкa с наименьшей суммой ({sum}) элементов ");


// int SumElements(int[,] array, int i)
// {
//   int sum = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sum += array[i,j];
//   }
//   return sum;
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void FillArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(1,10);
//     }
//   }
// }

// void PrintArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int rows = ReadInt("Введите количество строк: ");
// int columns = ReadInt("Введите количество столбцов: ");
// int[,] array = new int[rows, columns];
// int[,] secondArray = new int[rows, columns];
// int[,] resultArray = new int[rows, columns];

// FillArray(array);
// PrintArray(array);

// Console.WriteLine();

// FillArray(secondArray);
// PrintArray(secondArray);

// Console.WriteLine();

// if (array.GetLength(0) != secondArray.GetLength(1))
// {
//     Console.WriteLine(" ОШИБКА ");
//     return;
// }
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < secondArray.GetLength(1); j++)
//     {
//         resultArray[i, j] = 0;
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             resultArray[i, j] += array[i, k] * secondArray[k, j];
//         }
//     }
// }

// PrintArray(resultArray);



// // Функция ввода
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


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
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


