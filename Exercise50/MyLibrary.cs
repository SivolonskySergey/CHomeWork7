namespace MyLib
{
    class ArrayMethods
    {
        public static int [,] fillMultiArray(int[,] numbers, int minValue, int maxValue)
        {
            maxValue++;
            Random random = new Random();
            int rows = numbers.GetLength(0);
            int cols = numbers.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    numbers[i, j] = random.Next(minValue, maxValue);
                }
            }
            return numbers;
        }

        public static void PrintMultiArray(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    };
};