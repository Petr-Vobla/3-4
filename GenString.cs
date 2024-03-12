class GenString : IGenerator<string>
{
    public string GenRandom()
    {
        int rnd = new Random();
        string letters = "abcdefghijklmnopqrstuvwxyz";
        string word = "";
        for (int i = 0; i < rnd.Next(1, 10); i++)
        {
            word += letters[rnd.Next(letters.Length)];
        }
        return word;
    }
    public string GenUser()
    {
        return Console.ReadLine();
    }
}