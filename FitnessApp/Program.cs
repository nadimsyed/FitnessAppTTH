using System;

namespace FitnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double runningTotal = 0;

            while (true)
            {
                // Prompt the user for minutes exercised
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit : ");

                string response = Console.ReadLine();

                if (response.ToLower() == "quit")
                {
                    break;
                }
                
                try
                {
                    double minutes = double.Parse(response);

                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + " is not an acceptable value.");
                        continue;
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing, am I right?");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go hot stuff!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("You must be a ninja warrior in training!");
                    }
                    else
                    {
                        Console.WriteLine("Okay, now you're just showing off!");
                    }
                    runningTotal += minutes;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not valid input. Please try again!");
                    continue;
                }
                    

                    // Add minutes exercised to total
                    // Display total minutes exercised to the screen
                    Console.WriteLine("You've exercised " + runningTotal + " minutes.");
                    //Console.WriteLine("You've exercised {0} minutes", response);
                    // Repeat until the user quits
                

                
               
            }
            Console.WriteLine("Goodbye User!");


        }
    }
}
