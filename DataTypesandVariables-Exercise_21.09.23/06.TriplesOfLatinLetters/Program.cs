namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int start = 97;
            int end = start + n;

            for (int i = start; i < end; i++)
            {
                for (int j = start; j < end; j++)
                {
                    for (int k = start; k < end; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
