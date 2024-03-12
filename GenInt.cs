class GenInt : IGenerator<int>
{
    public int GenRandom()
    {
        int rnd = new Random();
        return rnd.Next(1, 10);
    }

    public int GenUser()
    {
        return int.Parse(Console.ReadLine());
    }
}