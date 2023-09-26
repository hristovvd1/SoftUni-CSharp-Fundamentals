namespace DataTypesandVariables_Exercise_21._09._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            decimal thirdNumber = decimal.Parse(Console.ReadLine());
            decimal fourthNumber = decimal.Parse(Console.ReadLine());

            decimal sum = firstNumber + secondNumber;
            decimal devide = sum / thirdNumber;
            decimal multiply = devide * fourthNumber;

            Console.WriteLine(multiply);
        }
    }
}
