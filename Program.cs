


/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
 значение этого элемента или же указание, что такого элемента нет. */

// Console.Clear();
// Console.Write("Введите строку: ");
// int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите столбец: ");
// int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
// int n = 5; 
// int m = 7; 
// Random random = new Random();
// int[,] arr = new int[n, m];
// Console.WriteLine("Массив: ");
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
// {
//     arr[i, j] = random.Next(10, 99);
// Console.Write("{0} ", arr[i, j]);
// }
// Console.WriteLine();
// }
//     if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
// {
// Console.WriteLine("Такого элемента нет  ");
// }
//     else
// {
//     Console.WriteLine("Значение = {0}", arr[pos1, pos2]);
// }
// Console.ReadLine();


/////////////////////////////////////////////////////////



//   Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.



// using System;

// class Program
// {
//     static void Main()
//     {
//         // Пример двумерного масси
//         int[,] myArray = {
//             {1, 2, 3},
//             {4, 5, 6},
//             {7, 8, 9}
//         };

//         Console.WriteLine("Mассив:");
//         PrintArray(myArray);

//         SwapFirstAndLastRow(myArray);

//         Console.WriteLine("Массив:");
//         PrintArray(myArray);
//     }

//     static void SwapFirstAndLastRow(int[,] array)
//     {

//         int rows = array.GetLength(0);
//         if (rows >= 2)
//         {
//             for (int i = 0; i < array.GetLength(1); i++)
//             {
//                 int temp = array[0, i];
//                 array[0, i] = array[rows - 1, i];
//                 array[rows - 1, i] = temp;
//             }
//         }
//     }

//     static void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//      }
//             }

// =================================================================================

/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/


// using System;

// class Program
// {
//     static void Main()
//     {
    
//         int[,] myArray = {
//             {1, 2, 3},
//             {4, 5, 6},
//             {7, 8, 9},
//             {10, 11, 12}
//         };

    
//         Console.WriteLine("Исходный массив:");
//         PrintArray(myArray);

    
//         int minRow = FindRowWithMinSum(myArray);

    
//         Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minRow + 1}");
//     }

//     static int FindRowWithMinSum(int[,] array)
//     {
//         int minSum = int.MaxValue;
//         int minRow = -1;

//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             int currentSum = 0;
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 currentSum += array[i, j];
//             }

//             if (currentSum < minSum)
//             {
//                 minSum = currentSum;
//                 minRow = i;
//             }
//         }

//         return minRow;
//     }

//     static void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }
