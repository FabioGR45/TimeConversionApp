using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minutes_To_Seconds
{
    public class Minutes {

        string userInputValue;

        public void MinutesTo(string desiredConvertionType)
        {

            double minutes = 0;
            double desiredTimeConversion = 0;

            switch (desiredConvertionType.ToLower())
            {
                case "seconds":
                    Console.Write($"Write the number of minutes you want to convert to {desiredConvertionType}: ");

                    userInputValue = Console.ReadLine();

                    if (!double.TryParse(userInputValue, out minutes))
                    {
                        //throw new Exception("only numbers are valid");
                        Console.WriteLine("\nonly numbers are valid!");
                        break;
                    }

                    desiredTimeConversion = minutes * 60;

                    if (minutes == 0.0166666 || minutes == 0.0166667)
                        Console.WriteLine($"\n{minutes} minute equals {desiredTimeConversion} second");
                    else if (minutes >= -1 && minutes <= 1)
                        Console.WriteLine($"\n{minutes} minute equals {desiredTimeConversion} seconds");
                    else
                        Console.WriteLine($"\n{minutes} minutes equals {desiredTimeConversion} seconds");

                    break;


                case "hours":

                    Console.Write($"Write the number of minutes you want to convert to {desiredConvertionType}: ");

                    userInputValue = Console.ReadLine();

                    if (!double.TryParse(userInputValue, out minutes))
                    {
                        //throw new Exception("only numbers are valid");
                        Console.WriteLine("\nonly numbers are valid!");
                        break;
                    }

                    desiredTimeConversion = minutes / 60;

                    if (minutes <= 60)
                        Console.WriteLine($"\n{minutes} minutes equals {desiredTimeConversion} hour");
                    else if (minutes >= -1 && minutes <= 1)
                        Console.WriteLine($"\n{minutes} minute equals {desiredTimeConversion} hour");
                    else
                        Console.WriteLine($"\n{minutes} minutes equals {desiredTimeConversion} hours");

                    break;

                case "days":

                    Console.Write($"Write the number of minutes you want to convert to {desiredConvertionType}: ");

                    userInputValue = Console.ReadLine();

                    if (!double.TryParse(userInputValue, out minutes))
                    {
                        //throw new Exception("only numbers are valid");
                        Console.WriteLine("\nonly numbers are valid!");
                        break;
                    }

                    desiredTimeConversion = minutes / 1440;

                    if (minutes <= 1440)
                        Console.WriteLine($"\n{minutes} minutes equals {desiredTimeConversion} day");
                    else if (minutes >= -1 && minutes <= 1)
                        Console.WriteLine($"\n{minutes} minute equals {desiredTimeConversion} day");
                    else
                        Console.WriteLine($"\n{minutes} minutes equals {desiredTimeConversion} days");

                    break;

                default:

                    Console.WriteLine("Incorrect value! Please type again...");

                    break;

            }

        }

    }
}
