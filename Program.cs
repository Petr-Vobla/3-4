 using System;
class Program
{
    internal class Program
    {
        public static void Main()
        {
            IPrinter[] printer = new IPrinter[4];
            IGenerator<int> GeneratorInt = new GenInt();
            IGenerator<string> GeneratorString = new GenString();
            IGenerator<double> GeneratorDouble = new GenDouble();
            IGenerator<bool> GeneratorBool = new GenBool();

            printer[0] = new Arr1<double>(false, GeneratorInt);
            printer[1] = new Arr1<string>(true, GeneratorString);
            printer[2] = new Arr2<int>(false, GeneratorDouble);
            printer[3] = new Arr2<bool>(true, GeneratorBool);

            for (int i = 0; i < printer.Length; i++)
            {
                printer[i].Print();
            }
        }
    }
}