using System;
using System.Linq;

namespace UnitConverterPOC
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Enter a value, the current unit of measurement, and the desired unit of measurement, all separated by spaces. (Type 'end' to terminate)");
                string userInput = Console.ReadLine().ToUpper();
                if (userInput == "END") // Check for exit
                {
                    break;
                }
                string[] arguments = userInput.Split(' ');
                if (arguments.Length != 3 || !int.TryParse(arguments[0], out var num))
                {
                    Console.WriteLine("Invalid input... Example input: 23 LB KG");
                }
                else
                {
                    double.TryParse(arguments[0], out var valueNumber);

                    if (Enum.GetNames(typeof(WeightAndVolumeEnum)).Contains(arguments[1]) && Enum.GetNames(typeof(WeightAndVolumeEnum)).Contains(arguments[2]))
                    {
                        WeightAndVolumeEnum valueFrom;
                        WeightAndVolumeEnum valueTo;
                        Enum.TryParse(arguments[1], out valueFrom);
                        Enum.TryParse(arguments[2], out valueTo);
                        double updatedNumber = UnitConverter.WeightAndVolumeConvertTo(valueNumber, valueTo, valueFrom);
                        Console.WriteLine(Math.Round(updatedNumber, 2) + " " + valueTo);
                    }
                    else if(Enum.GetNames(typeof(LengthEnum)).Contains(arguments[1]) && Enum.GetNames(typeof(LengthEnum)).Contains(arguments[2]))
                    {
                        LengthEnum valueFrom;
                        LengthEnum valueTo;
                        Enum.TryParse(arguments[1], out valueFrom);
                        Enum.TryParse(arguments[2], out valueTo);
                        double updatedNumber = UnitConverter.LengthConvertTo(valueNumber, valueTo, valueFrom);
                        Math.Round(updatedNumber, 2);
                        Console.WriteLine(Math.Round(updatedNumber, 2) + " " + valueTo);
                    }
                    else
                    {
                        Console.WriteLine("Cannot convert from " +arguments[1]+ " to " +arguments[2]);
                    }                 
                }           
            }            
        }
    }
}
