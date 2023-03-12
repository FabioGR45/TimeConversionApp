using Minutes_To_Seconds;

namespace Minutes_To_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double selectedOption = -1;
            string userInputValue;
            double validInput;
            Convertions convertions = new Convertions();

            while (selectedOption != 3)
            {
                Console.Clear();

                Console.WriteLine("Choose an option: \n\n 1 - Minutes to seconds \n 2 - Seconds to minutes \n 3 - Exit program \n");
                userInputValue = Console.ReadLine();

                if (!double.TryParse(userInputValue, out selectedOption))
                {
                    //throw new Exception("only numbers are valid");
                    Console.WriteLine("\nonly numbers are valid!");
                }

                switch (selectedOption)
                {

                    case 1:
                        Console.Write("\nEnter a value (minutes): ");
                        userInputValue = Console.ReadLine();

                        if (!double.TryParse(userInputValue, out validInput)){
                            //throw new Exception("only numbers are valid");
                            Console.WriteLine("only numbers are valid!");
                            Console.ReadLine();
                            break;
                        }

                        convertions.MinutesToSeconds(validInput);
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Write("\nEnter a value (seconds): ");
                        userInputValue = Console.ReadLine();

                        if (!double.TryParse(userInputValue, out validInput))
                        {
                            //throw new Exception("only numbers are valid");
                            Console.WriteLine("only numbers are valid!");
                            Console.ReadLine();
                            break;
                        }

                        convertions.SecondsToMinutes(validInput);
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("\nGoodbye!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\nInvalid option!");
                        Console.ReadLine();
                        break;
                }

            }

            Console.ReadLine();

        }
    }
}