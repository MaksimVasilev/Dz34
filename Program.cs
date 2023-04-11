// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// Console.WriteLine("Введите натуральное число");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(NumberCounter(i));




// string NumberCounter (int i)
// {
//     if (i == 1) return Convert.ToString("" + i);
//     return i + "," + NumberCounter (i - 1);   
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Ввудите значение M");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввудите значение N");
// int n = Convert.ToInt32(Console.ReadLine());
// if(m<n)
// Console.WriteLine(PrintNum(m , n));
// if(m>n)
// Console.WriteLine(PrintNum1(m , n));




// int PrintNum(int m, int n)
// {
//     if(m==n) return m;
//     return m + PrintNum(m + 1, n);
// }
// int PrintNum1(int m, int n)
// {
//     if(m==n) return m;
//     return m + PrintNum(m - 1, n);
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("Ввудите значение M");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввудите значение N");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(AkkermanRec( m, n));

// int AkkermanRec( int m, int n)
// {
//     if ( m==0 ) return n + 1;
//     else if (n==0) return AkkermanRec( m-1, 1 );
//     else return AkkermanRec( m-1, AkkermanRec( m , n-1 ));
// }