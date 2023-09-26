using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int snowballSnowValue = 0;
            int snowballTimeValue = 0;
            int snowballQualityValue = 0;

            BigInteger snowballValue = 0;

            for (int i = 0; i < num; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger calculate = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (calculate > snowballValue)
                {
                    snowballValue = calculate;
                    snowballSnowValue = snowballSnow;
                    snowballTimeValue = snowballTime;
                    snowballQualityValue = snowballQuality;
                }
            }

            Console.WriteLine($"{snowballSnowValue} : {snowballTimeValue} = {snowballValue} ({snowballQualityValue})");
        }
    }
}
