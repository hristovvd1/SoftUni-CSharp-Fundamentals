namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string keg = "";
            double volume = 0;

            for (int i = 0; i < num; i++)
            {
                string keg1 = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume1 = Math.PI * (radius * radius) * height;

                if (volume1 > volume)
                {
                    volume = volume1;
                    keg = keg1;
                    continue;
                }
            }

            Console.WriteLine(keg);
        }
    }
}
