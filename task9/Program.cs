// Console.WriteLine("Hello, World!");
Console.Clear();
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// Console.Write("Input number 1: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number 2: ");
// int m = Convert.ToInt32(Console.ReadLine());

// if (m>n)
// for (int i = n; i <= m; i++)
// {
//     Console.Write($" {i}");
// }
// else
//     for (int i = m; i <= n; i++)
//     {
//         Console.Write($" {i}");
//     }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.WriteLine("Input number 1:");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("Input number 2:");
// int n = int.Parse(Console.ReadLine());
// if (m>n)
//  for (int i = n; i <= m; i++)
//  {
//     Console.Write($" {i}");
//  }
//   else
//     for (int i = m; i <= n; i++)
//     {
//         Console.Write($" {i}");
//     }

// void Sum (int m, int n, int sum)
// {
//     if (m> n) 
//     {
//         Console.WriteLine($" -> The sum of elements from m to n = {sum}"); 
//         return;
//     }
//     sum = sum + (m++);
//     Sum(m, n, sum);
// }

// Sum(m, n, 0);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.WriteLine("Input positive number 1: ");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("Input positive number 2: ");
// int n = int.Parse(Console.ReadLine());

// int Function (int m, int n)
// {
//     if (m == 0)
//     return n + 1;
//         if (m != 0 && n == 0)
//         return Function(m - 1, 1);
//             if (m > 0 && n > 0) 
//             return Function(m - 1, Function(m, n - 1));
// return Function(m, n);
// }

// Console.WriteLine($"Accreman's function for A({m},{n}) = {Function(m, n)}");