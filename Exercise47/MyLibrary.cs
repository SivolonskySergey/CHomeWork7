namespace MyLib
{
    class ArrayMethods
    {
        public static void fillMultiArray(double[,] numbers)
        {
            Random random = new Random();
            int rows = numbers.GetLength(0);
            int cols = numbers.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double value = random.NextDouble() * 20 - 10;
                    numbers[i, j] = Math.Round(value, 1);
                }
            }
        }

        public static void PrintMultiArray(double[,] arr)
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