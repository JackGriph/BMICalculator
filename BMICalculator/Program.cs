using System.Formats.Asn1;

namespace BMICalculator
{
    internal class Program
    {
        static double CalculateBMI(double weight, double height, string unit = "metric")
        {
            if ( unit == "metric"  )
            {
                return weight / (height * height);
            }
            else if ( unit == "imperial" )
            {
                return (weight / (height * height)) * 703;
            }
            else
            {
                Console.WriteLine("Okänd enhet, returnerar 0");
                return 0;

            }
        }
        static void Main(string[] args)
        {
            // Vanligt anrop (metric, default)
            double bmi1 = CalculateBMI(70, 1.78);
            Console.WriteLine($"BMI (metric, default): {bmi1:F2}");

            // Namngivna i ordning
            double bmi2 = CalculateBMI(height: 1.78, weight: 70);

        }
    }
}
