using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minutes_To_Seconds
{
    public class Days
    {

        string userInputValue;

        public void DaysTo(string desiredConvertionType)
        {

            double days = 0;
            double desiredTimeConversion = 0;

            switch (desiredConvertionType.ToLower())
            {
                case "seconds":
                    Console.Write($"Write the number of days you want to convert to {desiredConvertionType}: ");

                    userInputValue = Console.ReadLine();

                    if (!double.TryParse(userInputValue, out days))
                    {
                        //throw new Exception("only numbers are valid");
                        Console.WriteLine("\nonly numbers are valid!");
                        break;
                    }

                    desiredTimeConversion = days * 86400;

                    if (days >= -1 && days <= 1)
                        Console.WriteLine($"\n{days} day equals {desiredTimeConversion} seconds");
                    else
                        Console.WriteLine($"\n{days} days equals {desiredTimeConversion} seconds");

                    break;


                case "minutes":

                    Console.Write($"Write the number of days you want to convert to {desiredConvertionType}: ");

                    userInputValue = Console.ReadLine();

                    if (!double.TryParse(userInputValue, out days))
                    {
                        //throw new Exception("only numbers are valid");
                        Console.WriteLine("\nonly numbers are valid!");
                        break;
                    }

                    desiredTimeConversion = days * 1440;

                    if (days >= -1 && days <= 1)
                        Console.WriteLine($"\n{days} day equals {desiredTimeConversion} minutes");
                    else
                        Console.WriteLine($"\n{days} days equals {desiredTimeConversion} minutes");

                    break;

                case "hours":

                    Console.Write($"Write the number of days you want to convert to {desiredConvertionType}: ");

                    userInputValue = Console.ReadLine();

                    if (!double.TryParse(userInputValue, out days))
                    {
                        //throw new Exception("only numbers are valid");
                        Console.WriteLine("\nonly numbers are valid!");
                        break;
                    }

                    desiredTimeConversion = days * 24;

                    if (days >= -1 && days <= 1)
                        Console.WriteLine($"\n{days} day equals {desiredTimeConversion} hours");
                    else
                        Console.WriteLine($"\n{days} days equals {desiredTimeConversion} hours");

                    break;

                default:

                    Console.WriteLine("Incorrect value! Please type again...");

                    break;

            }

        }

    }
}
