using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minutes_To_Seconds
{
    public class Hours {

        string userInputValue;

        public void HoursTo(string desiredConvertionType)
        {

            double hours = 0;
            double desiredTimeConversion = 0;

            switch (desiredConvertionType.ToLower())
            {
                case "seconds":
                    Console.Write($"Write the number of hours you want to convert to {desiredConvertionType}: ");

                    userInputValue = Console.ReadLine();

                    if (!double.TryParse(userInputValue, out hours))
                    {
                        //throw new Exception("only numbers are valid");
                        Console.WriteLine("\nonly numbers are valid!");
                        break;
                    }

                    desiredTimeConversion = hours * 3600;

                    if (hours == 0.00027777 || hours == 0.000277778)
                        Console.WriteLine($"\n{hours} hours equals {desiredTimeConversion} second");
                    else
                        Console.WriteLine($"\n{hours} hours equals {desiredTimeConversion} seconds");

                    break;


                case "minutes":

                    Console.Write($"Write the number of hours you want to convert to {desiredConvertionType}: ");

                    userInputValue = Console.ReadLine();

                    if (!double.TryParse(userInputValue, out hours))
                    {
                        //throw new Exception("only numbers are valid");
                        Console.WriteLine("\nonly numbers are valid!");
                        break;
                    }

                    desiredTimeConversion = hours * 60;

                    if (hours <= 1)
                        Console.WriteLine($"\n{hours} hour equals {desiredTimeConversion} minutes");
                    else if (hours == 0.0166666 || hours == 0.0166667) { 
                        Console.WriteLine($"\n{hours} hour equals {desiredTimeConversion} minute");
                    }
                    else
                        Console.WriteLine($"\n{hours} hours equals {desiredTimeConversion} minutes");

                    break;

                case "days":

                    Console.Write($"Write the number of minutes you want to convert to {desiredConvertionType}: ");

                    userInputValue = Console.ReadLine();

                    if (!double.TryParse(userInputValue, out hours))
                    {
                        //throw new Exception("only numbers are valid");
                        Console.WriteLine("\nonly numbers are valid!");
                        break;
                    }

                    desiredTimeConversion = hours / 24;

                    if (hours <= 24)
                        Console.WriteLine($"\n{hours} hours equals {desiredTimeConversion} day");
                    else
                        Console.WriteLine($"\n{hours} hours equals {desiredTimeConversion} days");

                    break;

                default:

                    Console.WriteLine("Incorrect value! Please type again...");

                    break;

            }

        }

    }
}
