﻿//  ЧТОЖ я начал свежий файлик :)
// ==========================================================================================================================
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write("set how many rows we have: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("set how many columns we have: ");
// int cols = Convert.ToInt32(Console.ReadLine());     //  где-то видел сокращение "colunms" до "cols" и мне это понравилось. Кажется вполне лаконичным и интуитивным.
// double[,] matrix = GetMatrix(rows, cols, 0, 100);      //  интернет меня учит плохому ?
// double[,] GetMatrix(int rows, int cols, double min, double max)
// {
//     double[,] matrix = new double [rows, cols]; 
//     for (int i = 0; i < rows; i++)        //  можно было задать размеры более универсальными matrix.GetLength(0) и (1), как на семинаре... 
//     {                                                                                                                                                                                                                                                                               //  Но я не уловил почему бы не опираться на вводимые тут же row и column (??)
//         for (int j = 0; j < cols; j++) 
//         {
//             matrix[i, j] = new Random().NextDouble() * 100;
//         }
//     }
//     return matrix;
// }
// PrintMatrix(matrix);
// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < rows; i++) 
//     {
//         for (int j = 0; j < cols; j++) 
//         {
//             Console.Write($"{matrix[i,j]:F3} \t");
//         }
//         Console.WriteLine();
//         Console.WriteLine();     //   так красиво :)
//     }
// }
// =========================================================================================================================
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int rows = 10;                                   
// int cols = 10;                                   
// int[,] matrix = new int[rows, cols]; 

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < cols; j++)
//     {
//         matrix[i, j] = new Random().Next(100);
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
//     Console.WriteLine();
// }
// Console.Write("what row we look at: ");
// int rowIndex = Convert.ToInt32(Console.ReadLine());
// Console.Write("what col we look at: ");
// int colIndex = Convert.ToInt32(Console.ReadLine());
// Console.Write("whait! What method of counting do you prefer? We begin from 0 or from 1? Type '0' or '1' please: ");
// int tradition  = Convert.ToInt32(Console.ReadLine());
// if (tradition == 1)
// {
//     if (rowIndex > rows || rowIndex < 1 || colIndex > cols || colIndex < 1)
//     {
//         Console.Write("The matrix is 10x10 only, from 1 to 10");
//     }
//     else
//     {
//         Console.Write(matrix[rowIndex - 1, colIndex - 1]);
//     }
// }
// else if (tradition == 0)
// {    
//     if (rowIndex > rows-1 || rowIndex < 0 || colIndex > cols-1 || colIndex < 0)
//     {
//         Console.Write("The matrix is 10x10 only, from 0 to 9");
//     }
//     else
//     {
//         Console.Write(matrix[rowIndex, colIndex]);
//     }
// }
// else
// {
//     Console.WriteLine("omg, are u kiddin' man? Retry with ONE or ZERO, m'kay?");
// }
//     =======      =======          =======       =======        =======            =======       =======          =====================================
//  На всякий случай... если я понял неверно условие - вот по другому. Мы задаём одно число и ищем его по матрице, а вот если нет его - то говорим "неть"
//  попробую:
// int rows = 10;                                   
// int cols = 10; 
// int i = 0;                              //  тут я вынес введение i и j в начало, чтобы можно было к ним обратиться за пределами первого цикла.
// int j = 0;                              //  и меня приятно удивило, что это прокатило :))    
// int[,] matrix = new int[rows, cols];
// for (i = 0; i < rows; i++)
// {
//     for (j = 0; j < cols; j++)
//     {
//         matrix[i, j] = new Random().Next(100);
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
//     Console.WriteLine();
// }
// Console.Write("where is this number: ");
// int insertedNumber = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// for (i = 0; i < rows; i++)
// {
//     for (j = 0; j < cols; j++)
//     {
//         if (insertedNumber == matrix[i, j])
//         {
//             Console.WriteLine($"{insertedNumber} is here: {i+1}:{j+1} and repeats {count+1} times");   //  добавил +1 к координатам, чтобы сделать их человеческими :)
//             count++; 
//         }
//     }
// } 
// if (count <= 0)                                                        //  а вот эту прикольную штуку пришлось достать аж сюда, а могло бы быть else'ом в цикле счётчика.
// {
//     Console.WriteLine($"nope, there is no '{insertedNumber}'");
// }
// =========================================================================================================================
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int rows = 10;                                  
// int cols = 10;
// int i = 0;
// int j = 0;                       
// int[,] matrix = new int[rows, cols]; 
// for (i = 0; i < rows; i++)
// {
//     for (j = 0; j < cols; j++)
//     {
//         matrix[i, j] = new Random().Next(100);
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
//     Console.WriteLine();
// }
// double[] averageInCols = new double[matrix.GetLength(1)];
// double sumCol = 0;                                              //  пришлось за каким-то чёртом делать sumCol даблом, хотя он состоит по умолчанию только их целых чисел  
//     for (j = 0; j < matrix.GetLength(1); j++)                   //  но только так на выходе возникли дроби. Я ожидал вообще-то их от деления целой суммы на высоту матрицы
//     {
//         sumCol = 0;                                             // вот эта фигулька обнуляет сумму столбцов на каждой итерации j -> j+1, чорт я две ночи думал как это сделать!
//         for (i = 0; i < matrix.GetLength(0); i++)
//         {
//             sumCol = sumCol + matrix[i, j];
//         }
//         averageInCols[j] = sumCol / matrix.GetLength(0);
//     }
// Console.WriteLine($"Our averages are: [{String.Join<double>("; ", averageInCols)}]");
// =========================================================================================================================
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
