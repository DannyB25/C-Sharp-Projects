using System;

namespace BranchingSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            string packageWeight = Console.ReadLine();
            double totalWeight = Convert.ToDouble(packageWeight);

            if (totalWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

            }
            else
            {
                Console.WriteLine("Please enter the package width:");
            }
            string packageWidth = Console.ReadLine();
            double totalWidth = Convert.ToDouble(packageWidth);

            Console.WriteLine("Please enter the package height:");
            string packageHeight = Console.ReadLine();
            double totalHeight = Convert.ToDouble(packageHeight);

            Console.WriteLine("Please enter the package length:");
            string packageLength = Console.ReadLine();
            double totalLength = Convert.ToDouble(packageLength);

            double totalDimension = totalWidth + totalHeight + totalLength;

            if (totalDimension > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                double Quote = ((totalHeight * totalWidth * totalLength) * totalWeight) / 100;
                Console.WriteLine("Your estimated total for shipping this package is: " + Quote.ToString("C2"));
                Console.ReadLine();

            }


        }
    }
}
