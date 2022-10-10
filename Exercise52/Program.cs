
using MyLib;

int[,] MakeDoubleArray(int m, int n)
{
    int[,] numbers = new int[m, n];
    return ArrayMethods.fillMultiArray(numbers, 1, 10);
}

int[,] newArr = MakeDoubleArray(3, 5);
ArrayMethods.PrintMultiArray(newArr);

void getAvgOfCols(int[,] arr)
{
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    Console.WriteLine($"Массив {rows} x {cols}");
    double summ = 0;
    string result = "";
    for(int i = 0; i < cols; i++)
    {
        for(int j = 0; j < rows; j++)
        {
            summ += arr[j, i];
        }
        double avg = Math.Round((summ / rows), 1, MidpointRounding.ToZero);
        result = result + $"{avg}; ";
        summ = 0;
    }
    Console.WriteLine($"Среднее арифметическое каждого столбца: {result}.");
}

getAvgOfCols(newArr);