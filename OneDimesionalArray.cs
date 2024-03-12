public sealed class OneDimesionalArray<T> : IBaseArray
{
    private T[] oneDArray;
    private IGenerator<T> _Generator;

    public OneDimesionalArray(bool fillByUser = false, IGenerator < T> ElGenerator)
    {
        _Generator = ElGenerator;
    }


    public void Initialize(bool fillByUser = false)
    {
        Console.WriteLine("Создание одномерного массива:");
        Console.Write("Введите длину массива:");
        int length = int.Parse(Console.ReadLine());
        oneDArray = new int[length];

        if (fillByUser)
        {
            for (int i = 0; i < oneDArray.Length; i++)
            {
                T T_Element = (T)Convert.T_Element(oneDArray[i], typeof(T));
                oneDArray[i] = _Generator.GenUser;
            }
        }
        else
        {
            Random random = new Random();

            for (int i = 0; i < oneDArray.Length; i++)
            {
                oneDArray[i] = _Generator.GenRandom();

            }
        }
    }
    public void Print()
    {
        Console.WriteLine("Вывод одномерного массива:");
        foreach (int value in oneDArray)
        {
            Console.Write(value + " ");
        }

        Console.WriteLine();
    }
}