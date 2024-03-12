class GenBool : IGenerator<bool>
{
    private static Random _random = new Random();
    public bool GenRandom()
    {
        bool input = false;
        int flag = _random.Next(0, 2);
        if (flag == 1)
        {
            input = true;
        }
        return input;
    }

    public bool GenUser()
    {
        bool flag = Convert.ToBoolean(Console.ReadLine());
        return flag;
    }
}
