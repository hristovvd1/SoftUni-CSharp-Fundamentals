namespace _05.PrintPartOfAsciiTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int symbol = int.Parse(Console.ReadLine());
            int symbolEnd = int.Parse(Console.ReadLine());

            for (int i = symbol; i <= symbolEnd; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
