namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Npower = int.Parse(Console.ReadLine());
            int Mdistance = int.Parse(Console.ReadLine());
            int Yexhaust = int.Parse(Console.ReadLine());

            int pokedTarget = 0;
            double originalNpower = Npower;

            while (Npower >= Mdistance)
            {
                Npower -= Mdistance;
                pokedTarget++;

                if (originalNpower / 2 == Npower && Yexhaust != 0)
                {
                    Npower /= Yexhaust;
                }
            }

            Console.WriteLine($"{Npower}\n{pokedTarget}");
        }
    }
}
