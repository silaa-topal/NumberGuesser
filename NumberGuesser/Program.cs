using System;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GetAppInfo();

            GreetUser();


            ///string name = "Sıla Topal";
            ///int age = 23;
            //Console.WriteLine(name+ " is "+ age);
            ///Console.WriteLine("{0} is {1}", name, age);
            ///

            //Ask users name
          

            while (true)
            {



                //init correct number
                //int correctNumber = 7;

                //Create a new random object
                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 10);

                //init guess var
                int guess = 0;

                //Ask user for a number
                Console.WriteLine("Guess a number between 1-10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();

                    //Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Pirnt error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //Keep going
                        continue;
                    }
                   

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                       
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!");

        

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Sıla Topal";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message )
        {
            Console.ForegroundColor = color;

            //Tell user it 's not a number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();

            
        }
    }
}
