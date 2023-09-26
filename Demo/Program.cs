namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            if (command == "boring") { 
                Console.WriteLine("Error: Never get bored");
                continue; }
            while (command != "boring") {
                Console.WriteLine("Keep coding"); }
        }
    }
}
