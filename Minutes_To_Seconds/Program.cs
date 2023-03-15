using Minutes_To_Seconds;

namespace Minutes_To_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userInputValue = "a";
            string desiredTimeTypeResult = "a";
            Seconds secondsConvertion = new Seconds();
            Minutes minutesConvertion = new Minutes();
            Hours hoursConvertion = new Hours();
            Days daysConvertion = new Days();

            while (userInputValue != "exit")
            {
                Console.Clear();

                Console.Write("Choose an time type to convert! \n - Seconds \n - Minutes \n - Hours \n - Days \n - Exit - to close the program \n\n");
                userInputValue = Console.ReadLine().ToLower();

                if(userInputValue == "exit")
                {
                    Console.WriteLine("\nGoodbye!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                Console.Write("\nWrite the type of time you want to receive converted: ");
                desiredTimeTypeResult = Console.ReadLine().ToLower();

                switch (userInputValue)
                {

                    case "seconds":
                        secondsConvertion.SecondsTo(desiredTimeTypeResult);
                        break;

                    case "minutes":
                        minutesConvertion.MinutesTo(desiredTimeTypeResult);
                        break;

                    case "hours":
                            hoursConvertion.HoursTo(desiredTimeTypeResult);
                        break;

                    case "days":
                            daysConvertion.DaysTo(desiredTimeTypeResult);
                        break;

                    default:
                        Console.WriteLine("Incorrect value! Please type again...");
                        Console.ReadLine();
                        break;

                }

                

                Console.ReadLine();

            }
        }
    }
}