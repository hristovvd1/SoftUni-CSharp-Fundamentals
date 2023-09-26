namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int litersAdded = 0;

            for (int i = 0; i < lines; i++)
            {
                int quantity = int.Parse(Console.ReadLine());

                if (litersAdded + quantity > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }

                else
                {
                    litersAdded += quantity;
                }
            }

            Console.WriteLine(litersAdded);
        }
    }
}
