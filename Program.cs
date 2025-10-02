using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Die_Class;

namespace Topic_6___Looping_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #1 - Prompter

            //int min;
            //int max;
            //int guess;
            //int answer;
            //bool done = false;
            //bool vaildInput = false;

            //Random generator = new Random();



            //        Console.WriteLine("Enter in a minimum:");


            //        while (!Int32.TryParse(Console.ReadLine(), out min))
            //        {
            //            Console.WriteLine("Invaild input, try again.");
            //        }

            //        Console.WriteLine();

            //        Console.WriteLine("Enter in a maximum: ");

            //        while (!Int32.TryParse(Console.ReadLine(), out max))
            //        {
            //            Console.WriteLine("Invaild input, try again.");
            //        }

            //        Console.WriteLine();

            //        if (min < max)
            //        {
            //            vaildInput = true;
            //        }
            //    while (!done)
            //    {
            //        Console.WriteLine("Enter a number between " + min + " and " + max);

            //        Console.WriteLine();

            //        while (int.TryParse(Console.ReadLine(), out guess))
            //        {


            //            if (guess > min && guess < max)
            //            {
            //                Console.WriteLine("You guessed the number " + guess);
            //                done = true;
            //            }


            //        }


            //    }


            // #2 - Simple Banking Machine
            //string choice = "";
            //double accBalance = 150;
            //double deposit;
            //double withDrawal;
            //double fee = 0.75;


            //while (choice != "q")
            //{

            //    Console.WriteLine("Welcome to the Bank of Blorb, enter in one of the available transactions: ");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Deposit");
            //    Console.WriteLine("2 - Withdrawal");
            //    Console.WriteLine("3 - Bill Payment");
            //    Console.WriteLine("4 - Account Balance");
            //    Console.WriteLine(".................");
            //    Console.WriteLine("Q - Quit");
            //    Console.WriteLine();
            //    choice = Console.ReadLine().ToLower();
            //    Console.WriteLine();

            //    if (choice == "1")
            //    {
            //        Console.WriteLine("Enter an amount of money to deposit.");

            //        Console.WriteLine();

            //        while (!double.TryParse(Console.ReadLine(), out deposit))
            //        {
            //            Console.WriteLine("Enter an amount of money to deposit.");

            //            Console.WriteLine();
            //        }
            //        Console.WriteLine("You have $ " + (deposit + accBalance - fee) + " left in your balance.");

            //        Console.WriteLine();
            //    }
            //    else if (choice == "2")
            //    {
            //        Console.WriteLine("Enter how much money you're withdrawal.");

            //        Console.WriteLine();

            //        while (!double.TryParse(Console.ReadLine(), out withDrawal))
            //        {
            //            Console.WriteLine("Enter how much money you're withdrawal.");

            //            Console.WriteLine();
            //        }

            //        if (withDrawal < 0)
            //        {
            //            Console.WriteLine("Invalid input.");
            //         }

            //     Console.WriteLine("You've withdrawaled $ " + (accBalance - withDrawal - fee) + " from your balance.");

            //     Console.WriteLine();

            //    }
            //    else if (choice == "3")
            //    {

            //        Console.WriteLine("The total cost of the bill payment is $"+ (accBalance - fee));
            //        Console.WriteLine();

            //    }
            //    else if (choice == "4")
            //    {

            //        Console.WriteLine("Your account balance is $ " + (accBalance - fee));
            //        Console.WriteLine();

            //    }
            //    else
            //    {
            //       choice = "q";
            //       Console.WriteLine("Thank you for using the Bank of Blorb, have a nice day!");

            //    }


            //}

            // #3 - Double Roller

            Die die1, die2;

            bool done = false;

            die1 = new Die();
            die2 = new Die(ConsoleColor.DarkRed);

            Console.WriteLine("Die 1 is a " + die1);
            die1.DrawRoll();
             
            Console.WriteLine();
           
            Console.WriteLine("Die 2 is a " + die2);
            die2.DrawRoll();

            Console.WriteLine();

            if (die1.Roll == die2.Roll)
            {
                Console.WriteLine("You rolled Doubles.");
            }

            Console.WriteLine();

            Console.WriteLine("Press ENTER to continue rolling the dice.");

            while (!done)
            {

                if (die1.Roll == die2.Roll)
                {
                    Console.WriteLine("You rolled Doubles.");
                    done = true;
                }
            }
  

        }
    }
}
