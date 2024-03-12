public sealed class Matrix<T> : IBaseArray
{
    private T[,] twoDArray;
    private IGenerator<T> _Generator;

    public Matrix(bool fillByUser = false, IGenerator<T> ElGenerator)
    {
        _Generator = ElGenerator;
    }


    public void Initialize(bool fillByUser = false)
    {
        Console.WriteLine("Создание матрицы:");
        Console.Write("Введите количество рядов: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введите количество строчек: ");
        int columns = int.Parse(Console.ReadLine());
        twoDArray = new T[rows, columns];

        if (fillByUser)
        {
            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    Console.Write($"Введите элемент под номером: [{i + 1}, {j + 1}]: ");
                    twoDArray[i, j] = _Generator.GenUser();
                }
            }
        }
        else
        {
            Random random = new Random();

            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    twoDArray[i, j] = _Generator.GenRandom();
                }
            }
        }
    }
    public void Print()
    {
        Console.WriteLine("Вывод матрицы:");
        for (int i = 0; i < twoDArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDArray.GetLength(1); j++)
            {
                Console.Write(twoDArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}