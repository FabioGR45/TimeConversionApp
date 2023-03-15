using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minutes_To_Seconds
{
    public class Seconds
    {

        string userInputValue;

        public void SecondsTo(string desiredConvertionType)
        {
            double seconds = 0;
            double desiredTimeConversion = 0;

            switch (desiredConvertionType.ToLower())
            {
                case "minutes":
                    Console.Write($"Write the number of seconds you want to convert to {desiredConvertionType}: ");

                    userInputValue = Console.ReadLine();

                    if (!double.TryParse(userInputValue, out seconds))
                    {
                        //throw new Exception("only numbers are valid");
                        Console.WriteLine("\nonly numbers are valid!");
                        break;
                    }

                    desiredTimeConversion = seconds / 60;

                    if (seconds <= 60)
                        Console.WriteLine($"\n{seconds} seconds equals {desiredTimeConversion} minute");
                    else if (seconds >= -1 && seconds <= 1)
                        Console.WriteLine($"\n{seconds} second equals {desiredTimeConversion} minute");
                    else
                        Console.WriteLine($"\n{seconds} seconds equals {desiredTimeConversion} minutes");

                    break;


                case "hours":

                    Console.Write($"Write the number of seconds you want to convert to {desiredConvertionType}: ");

                    userInputValue = Console.ReadLine();

                    if (!double.TryParse(userInputValue, out seconds))
                    {
                        //throw new Exception("only numbers are valid");
                        Console.WriteLine("\nonly numbers are valid!");
                        break;
                    }

                    desiredTimeConversion = seconds / 3600;

                    if(seconds <= 3600)
                        Console.WriteLine($"\n{seconds} seconds equals {desiredTimeConversion} hour");
                    else if (seconds >= -1 && seconds <= 1)
                        Console.WriteLine($"\n{seconds} second equals {desiredTimeConversion} hour");
                    else
                        Console.WriteLine($"\n{seconds} seconds equals {desiredTimeConversion} hours");

                    break;

                case "days":

                    Console.Write($"Write the number of seconds you want to convert to {desiredConvertionType}: ");

                    userInputValue = Console.ReadLine();

                    if (!double.TryParse(userInputValue, out seconds))
                    {
                        //throw new Exception("only numbers are valid");
                        Console.WriteLine("\nonly numbers are valid!");
                        break;
                    }

                    desiredTimeConversion = seconds / 86400;

                    if(seconds <= 86400)
                        Console.WriteLine($"\n{seconds} seconds equals {desiredTimeConversion} day");
                    else if (seconds >= -1 && seconds <= 1)
                        Console.WriteLine($"\n{seconds} second equals {desiredTimeConversion} day");
                    else
                        Console.WriteLine($"\n{seconds} seconds equals {desiredTimeConversion} days");

                    break;

                default:

                    Console.WriteLine("Incorrect value! Please type again...");

                    break;

            }
        }

    }
}
