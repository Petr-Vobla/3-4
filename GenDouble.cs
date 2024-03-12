class GenDouble : IGenerator<double>
{
    public double GenRandom()
    {
        int rnd = new Random();
        return rnd.NextDouble();
    }

    public double GenUser()
    {
        return double.Parse(Console.ReadLine());
    }
}