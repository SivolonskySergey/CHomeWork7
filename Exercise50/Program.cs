using MyLib;

int[,] MakeDoubleArray(int m, int n)
{
    int[,] numbers = new int[m, n];
    return ArrayMethods.fillMultiArray(numbers, -10, 10);
}

int[,] newArr = MakeDoubleArray(5, 7);
ArrayMethods.PrintMultiArray(newArr);

void getValue(int[,] arr, int firstIndex, int secondIndex)
{
    if(firstIndex > arr.GetLength(0) - 1 || secondIndex > arr.GetLength(1) - 1)
    {
        Console.WriteLine($"Элемента с индексами [{firstIndex},{secondIndex}] - в данном массиве нет");
    }
    else 
    {
        Console.WriteLine($"Число с индексами [{firstIndex},{secondIndex}] - {arr[firstIndex, secondIndex]}");
    }
}

getValue(newArr, 1, 2);
getValue(newArr, 2, 6);