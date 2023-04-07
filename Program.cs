
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




