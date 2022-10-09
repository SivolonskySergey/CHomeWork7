// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами, 
// округлёнными до одного знака.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using MyLib;

void MakeDoubleArray(int m, int n) 
{
    double[,] numbers = new double[m, n];
    MyLib.ArrayMethods.fillMultiArray(numbers);
    MyLib.ArrayMethods.PrintMultiArray(numbers);
}
MakeDoubleArray(3,4);