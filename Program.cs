//  ЧТОЖ я начал свежий файлик :)
// ==========================================================================================================================
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("set how many rows we have: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("set how many columns we have: ");
int cols = Convert.ToInt32(Console.ReadLine());     //  где-то видел сокращение "colunms" до "cols" и мне это понравилось. Кажется вполне лаконичным и интуитивным.
double[,] matrix = GetMatrix(rows, cols, 0, 100);      //  интернет меня учит плохому ?
double[,] GetMatrix(int rows, int cols, double min, double max)
{
    double[,] matrix = new double [rows, cols]; 
    for (int i = 0; i < rows; i++)        //  можно было задать размеры более универсальными matrix.GetLength(0) и (1), как на семинаре... 
    {                                                                                                                                                                                                                                                                               //  Но я не уловил почему бы не опираться на вводимые тут же row и column (??)
        for (int j = 0; j < cols; j++) 
        {
            matrix[i, j] = new Random().NextDouble() * 100;
        }
    }
    return matrix;
}
PrintMatrix(matrix);
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < cols; j++) 
        {
            Console.Write($"{matrix[i,j]:F3} \t");
        }
        Console.WriteLine();
        Console.WriteLine();     //   так красиво :)
    }
}
// =========================================================================================================================