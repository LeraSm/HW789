// Console.WriteLine("Hello, World!");
Console.Clear();

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.WriteLine("Input number of array's lines: ");
// int linesnum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of array's columns");
// int columnsnum = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[linesnum, columnsnum];
// ArrayRndm(numbers);
// PrintArray(numbers);

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1) - 1; j++)
//     {
//         for (int r = 0; r < numbers.GetLength(1) - 1; r++)
//         {
//             if (numbers[i, r] < numbers[i, r + 1])
//             {
//                 int temp = 0;
//                 temp = numbers[i, r];
//                 numbers[i, r] = numbers[i, r + 1];
//                 numbers[i, r + 1] = temp;
//             }
//         }
//     }
// }
// Console.WriteLine();
// PrintArray(numbers);

// void ArrayRndm(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1,20);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//        for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "  ");
//         }
//         Console.WriteLine("");
//     }
// }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.WriteLine("Input quantity of rectangualr array's elements: ");
// int arrNum = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[arrNum, arrNum];
// ArrayRndm(numbers);
// PrintArray(numbers);
// int minsum =Int32.MaxValue;
// int index = 0;

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         sum = sum + numbers[i, j];        
//     }
//     if (sum < minsum)
//     {
//         minsum = sum;
//         index++;
//     }
// }

// Console.WriteLine($"The line with the smallest sum is {index} with sum of elements {minsum}");

// void ArrayRndm(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 20);
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
//         Console.WriteLine("  ");
//     }
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// void ArrayRndm(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1,10);
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
//         Console.WriteLine("  ");
//     }
// }

// int size = InputInt("Size of matrix: ");
// int[,] matrixNumb1 = new int[size, size];
// int[,] matrixNumb2 = new int[size, size];
// ArrayRndm(matrixNumb1);
// ArrayRndm(matrixNumb2);
// int[,] matrixResult = new int[size, size];

// for (int i = 0; i < size; i++)
// {
//     for (int j = 0; j < size; j++)
//     {
//         for (int k = 0; k < size; k++)
//         {
//             matrixResult[i, j] = matrixResult[i, j] + (matrixNumb1[i, k] * matrixNumb2[k, j]);
//         }
//     }
// }
// Console.WriteLine("Matrix number 1");
// PrintArray(matrixNumb1);
// Console.WriteLine();
// Console.WriteLine("Matrix number 2");
// PrintArray(matrixNumb2);
// Console.WriteLine();
// Console.WriteLine("Product of matrix");
// PrintArray(matrixResult);

// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int Size1 = 2;
// int Size2 = 2;
// int Size3 = 2;
// int minNumber = 10;
// int maxNumber = 100;
// int[,,] ArrayRndm = new int[Size1, Size2, Size3];
// ArrayRndmNumb(ArrayRndm, minNumber, maxNumber);
// PrintArrayInd(ArrayRndm);

// void ArrayRndmNumb(int[,,] array, int minNumber = 0, int maxNumber = 9)
// {
//     Random rand = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 while (array[i, j, k] == 0)
//                 {
//                     int number = rand.Next(minNumber, maxNumber + 1);

//                     if (Array(array, number) == false)
//                     {
//                         array[i, j, k] = number;
//                     }
//                 }

//             }
//         }
//     }
// }

// bool Array(int[,,] array, int number)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if (array[i, j, k] == number) return true;
//             }
//         }
//     }

//     return false;
// }

// void PrintArrayInd(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write(array[i, j, k]);
//                 Console.Write("({0},{1},{2})  ", i, j, k);
//             }

//             Console.WriteLine();
//         }

//         Console.WriteLine();
//     }
// }
