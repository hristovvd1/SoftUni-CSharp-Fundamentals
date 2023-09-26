namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            double coursesNeeded = Math.Ceiling((double)people / capacity);

            Console.WriteLine(coursesNeeded);
        }
    }
}

