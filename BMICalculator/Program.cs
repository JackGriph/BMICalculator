using System.Formats.Asn1;

namespace BMICalculator
{
    internal class Program
    {
        static double CalculateBMI(double weight, double height, string unit = "metric")
        {

            if (height <= 0)
            {
                Console.WriteLine("Höjden måste vara större än 0");
                return 0;
            }

            if (unit == "metric")
            {
                return weight / (height * height);
            }
            else if (unit == "imperial")
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

            // Egna inmatningar

            Console.Write("Ange vikt: ");
            if (!double.TryParse(Console.ReadLine(), out double userWeight))
            {
                Console.WriteLine("Felaktig vikt.");
                return;
            }

            Console.Write("Ange längd: ");
            if (!double.TryParse(Console.ReadLine(), out double userHeight))
            {
                Console.WriteLine("Felaktig längd.");
                return;
            }

            Console.Write("Ange enhet (metric/imperial): ");
            string userUnit = Console.ReadLine()?.Trim().ToLower();
            if (string.IsNullOrEmpty(userUnit))
            {
                userUnit = "metric";
            }

            double userBmi = CalculateBMI(userWeight, userHeight, userUnit);
            Console.WriteLine($"Ditt BMI: {userBmi:F2}");

            double userBmi2 = CalculateBMI(userHeight, userWeight);
            Console.WriteLine($"Ditt BMI (omvänd ordning): {userBmi2:F2}"); 

        }
    }
    }

