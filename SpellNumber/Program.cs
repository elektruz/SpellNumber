using System;

namespace SpellNumber
{
    class Program
    {
        static void Main(string[] args)
        {             
            while (true)
            {
                Console.WriteLine("Enter the number");
                var userInput = Convert.ToInt64(Console.ReadLine());
                var words = ConvertNumberTowords(userInput);

                Console.WriteLine(words);                

            }
        }

        public static string ConvertNumberTowords(Int64 i)
        {
            if (i < 20)
            {
                return ApplicationConstants.digitUnits[i];
            }
            if (i < 100)
            {
                return ApplicationConstants.tenPositions[i / 10] + ((i % 10 > 0) ? " " + ConvertNumberTowords(i % 10) : "");
            }
            if (i < 1000)
            {
                return ApplicationConstants.tenPositions[i / 100] + " Hundred"
                        + ((i % 100 > 0) ? " And " + ConvertNumberTowords(i % 100) : "");
            }
            if (i < 100000)
            {
                return ConvertNumberTowords(i / 1000) + " Thousand "
                + ((i % 1000 > 0) ? " " + ConvertNumberTowords(i % 1000) : "");
            }
            if (i < 10000000)
            {
                return ConvertNumberTowords(i / 100000) + " Lakh "
                        + ((i % 100000 > 0) ? " " + ConvertNumberTowords(i % 100000) : "");
            }
            return ConvertNumberTowords(i / 10000000) + " Crore "
                        + ((i % 10000000 > 0) ? " " + ConvertNumberTowords(i % 10000000) : "");
        }
    }
}
