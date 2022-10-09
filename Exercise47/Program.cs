
using MyLib;

void MakeDoubleArray(int m, int n) 
{
    double[,] numbers = new double[m, n];
    ArrayMethods.fillMultiArray(numbers);
    ArrayMethods.PrintMultiArray(numbers);
}
MakeDoubleArray(3,4);