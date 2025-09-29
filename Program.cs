namespace Topic_6___Looping_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
         // #1 - Prompter

        int min;
        int max;
        int guess;
        int answer;
        bool done = false;
        bool vaildInput = false;
               
        Random generator = new Random();


            
                Console.WriteLine("Enter in a minimum:");


                while (!Int32.TryParse(Console.ReadLine(), out min))
                {
                    Console.WriteLine("Invaild input, try again.");
                }

                Console.WriteLine();

                Console.WriteLine("Enter in a maximum: ");

                while (!Int32.TryParse(Console.ReadLine(), out max))
                {
                    Console.WriteLine("Invaild input, try again.");
                }

                Console.WriteLine();

                if (min < max)
                {
                    vaildInput = true;
                }
            while (!done)
            {
                Console.WriteLine("Enter a number between " + min + " and " + max);

                Console.WriteLine();

                while (int.TryParse(Console.ReadLine(), out guess))
                {


                    if (guess > min && guess < max)
                    {
                        Console.WriteLine("You guessed the number " + guess);
                        done = true;
                    }


                }


            }


        }
    }
}
