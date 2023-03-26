// Задача 34. Задайте массив заполненный случайными положительными трехзначными числами
// Напишите программу, которая покажет количство четных чисел в массиве

void FillArray( int [] array)
{
    for ( int i = 0; i<array.Length; i++)
    array[i] = new Random().Next(100,1000);
}

void PrintArray( int [] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

int Count(int [] array)
{  

   
    int count = 0;
    for ( int i = 0; i<array.Length; i++)
       if(array[i]%2==0)
       {
        count++;
        
       }
    return count;
    
}




int [] array = new int [4];
FillArray(array);
PrintArray(array);
Console.WriteLine(Count(array));


// Задача 26. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму эллементов, стоящих нанечетных позициях.

// void FillArray( int [] array)
// {
//     for ( int i = 0; i<array.Length; i++)
//     array[i] = new Random().Next(1,20);
// }

// void PrintArray( int [] array)
// {
//     foreach (var item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

// int Count(int [] array)
// {
//     int sum = int array[1] + int array[3];
    
//     int count = 0;
//     int sum = 0;
//     for ( int i = 0; i<array.Length; i++)
//     if (int i = 1)
//     int sum = array[1] + array[3];
//     count++;
//     Console.Write(count);
//     return count;

// }




// int [] array = new int [4];
// FillArray(array);
// PrintArray(array);
// Count(array);
