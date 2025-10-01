using System.Xml.Serialization;

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
            string choice = "";
            double accBalance = 150;
            double deposit;
            double withDrawal;
            double fee = 0.75;
            

            while (choice != "q")
            {

                Console.WriteLine("Welcome to the Bank of Blorb, enter in one of the available transactions: ");
                Console.WriteLine();
                Console.WriteLine("1 - Deposit");
                Console.WriteLine("2 - Withdrawal");
                Console.WriteLine("3 - Bull Payment");
                Console.WriteLine("4 - Account Balance");
                Console.WriteLine(".................");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower();
                Console.WriteLine();
            
                if (choice == "1")
                {
                    Console.WriteLine("Enter an amount of money to deposit.");

                    while (!double.TryParse(Console.ReadLine(), out deposit))
                    {
                        Console.WriteLine("Enter an amount of money to deposit.");
                    }
                    Console.WriteLine("You have $" + (deposit + accBalance - fee) + " left in your balance.");
                    Console.WriteLine();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Enter how much money you're withdrawal.");

                    while (!double.TryParse(Console.ReadLine(), out withDrawal))
                    {
                        Console.WriteLine("Enter how much money you're withdrawal.");
                    }

                    if (withDrawal > 0 || withDrawal > accBalance)
                    {
                        Console.WriteLine("Invalid input.");
                    }
                 Console.WriteLine("You've withdrawaled $" + (accBalance - withDrawal - fee) + " from your balance.");

                }
                //else if (choice == "3")
                //{

                //}
                //else if (choice == "4") 
                //{

                //}
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                
                }











            }



            

















        }
    }
}
