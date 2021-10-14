using System;

/*
Author: J-Zach Loke
Class: CMPS-378
Due Date: 10/14/2021
Description:
    This program uses switch statements and arrays to give some information based on the user's birthday
*/

namespace Assignment3
{
    class MainClass
    {
        /* The root / driver of the program */
        static int getInput(string question)
        {
            int response = -1;
            while (response <= 0) {
                Console.Write(question);
                try {
                    response = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException) {
                    Console.WriteLine("You have entered an incorrect response. Please try again.");
                }
            }
            return response;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Birthday Date Meaning Generator!");
            while (true) {
                // collect inputs of the user
                int[] info = new int[3];
                string[] MONTHS = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
                info[0] = getInput("Please enter the month of your birthday: ");
                info[1] = getInput("Please enter the day of your birthday: ");
                info[2] = getInput("Please enter the year of your birthday: ");

                // display info about the month
                Console.Write($"\nThe month of {MONTHS[info[0]-1]} means ");
                switch (info[0]) {
                    case 1:
                        Console.WriteLine("means Janus");
                        break;
                    case 2:
                        Console.WriteLine("means februalia");
                        break;
                    case 3:
                        Console.WriteLine("means Mars");
                        break;
                    case 4:
                        Console.WriteLine("means aperire");
                        break;
                    case 5:
                        Console.WriteLine("means Maia");
                        break;
                    case 6:
                        Console.WriteLine("means youth");
                        break;
                    case 7:
                        Console.WriteLine("means Julius Caesar");
                        break;
                    case 8:
                        Console.WriteLine("means Augustus Caesar");
                        break;
                    case 9:
                        Console.WriteLine("means seven");
                        break;
                    case 10:
                        Console.WriteLine("means eight");
                        break;
                    case 11:
                        Console.WriteLine("means nine");
                        break;
                    case 12:
                        Console.WriteLine("means ten");
                        break;
                }

                // display info about the day
                switch (info[1]) {
                    case 1:
                        Console.WriteLine($"The 1st of {MONTHS[info[0]-1]} means Self-Started");
                        break;
                    case 2:
                        Console.WriteLine($"The 2nd of {MONTHS[info[0]-1]} means Solution Finder");
                        break;
                    case 3:
                        Console.WriteLine($"The 3rd of {MONTHS[info[0]-1]} means Communicator");
                        break;
                    case 4:
                        Console.WriteLine($"The 4th of {MONTHS[info[0]-1]} means Stability & Rationality");
                        break;
                    case 5:
                        Console.WriteLine($"The 5th of {MONTHS[info[0]-1]} means Flexibility");
                        break;
                    case 6:
                        Console.WriteLine($"The 6th of {MONTHS[info[0]-1]} means Heart");
                        break;
                    case 7:
                        Console.WriteLine($"The 7th of {MONTHS[info[0]-1]} means Mind");
                        break;
                    case 8:
                        Console.WriteLine($"The 8th of {MONTHS[info[0]-1]} means Success");
                        break;
                    case 9:
                        Console.WriteLine($"The 9th of {MONTHS[info[0]-1]} means Compassion");
                        break;
                    case 10:
                        Console.WriteLine($"The 10th of {MONTHS[info[0]-1]} means Leadership");
                        break;
                    case 11:
                        Console.WriteLine($"The 11th of {MONTHS[info[0]-1]} means Awareness");
                        break;
                    case 12:
                        Console.WriteLine($"The 12th of {MONTHS[info[0]-1]} means Creativity");
                        break;
                    case 13:
                        Console.WriteLine($"The 13th of {MONTHS[info[0]-1]} means Conscientious");
                        break;
                    case 14:
                        Console.WriteLine($"The 14th of {MONTHS[info[0]-1]} means Open-Minded");
                        break;
                    case 15:
                        Console.WriteLine($"The 15th of {MONTHS[info[0]-1]} means Love");
                        break;
                    case 16:
                        Console.WriteLine($"The 16th of {MONTHS[info[0]-1]} means Inquisitive");
                        break;
                    case 17:
                        Console.WriteLine($"The 17th of {MONTHS[info[0]-1]} means Quality");
                        break;
                    case 18:
                        Console.WriteLine($"The 18th of {MONTHS[info[0]-1]} means Ambition");
                        break;
                    case 19:
                        Console.WriteLine($"The 19th of {MONTHS[info[0]-1]} means Independence");
                        break;
                    case 20:
                        Console.WriteLine($"The 20th of {MONTHS[info[0]-1]} means Cooperative");
                        break;
                    case 21:
                        Console.WriteLine($"The 21st of {MONTHS[info[0]-1]} means Socially Active");
                        break;
                    case 22:
                        Console.WriteLine($"The 22nd of {MONTHS[info[0]-1]} means Creator");
                        break;
                    case 23:
                        Console.WriteLine($"The 23rd of {MONTHS[info[0]-1]} means Experience");
                        break;
                    case 24:
                        Console.WriteLine($"The 24th of {MONTHS[info[0]-1]} means Stable Relationship");
                        break;
                    case 25:
                        Console.WriteLine($"The 25th of {MONTHS[info[0]-1]} means Curiosity");
                        break;
                    case 26:
                        Console.WriteLine($"The 26th of {MONTHS[info[0]-1]} means Success");
                        break;
                    case 27:
                        Console.WriteLine($"The 27th of {MONTHS[info[0]-1]} means Compassion");
                        break;
                    case 28:
                        Console.WriteLine($"The 28th of {MONTHS[info[0]-1]} means Compassionate Leader");
                        break;
                    case 29:
                        Console.WriteLine($"The 29th of {MONTHS[info[0]-1]} means Insight");
                        break;
                    case 30:
                        Console.WriteLine($"The 30th of {MONTHS[info[0]-1]} means Original");
                        break;
                    case 31:
                        Console.WriteLine($"The 31st of {MONTHS[info[0]-1]} means Practical & Immaginative");
                        break;
                }

                Console.WriteLine($"The year of {info[2]} means that you are a millenial");

                Console.Write("Would you like to try another one? ");
                var cont = Console.ReadLine();
                Console.WriteLine("\n\n");
                if (cont == "N") {
                    Console.WriteLine("Thanks for paying!");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}