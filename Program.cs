namespace Topic_6___Looping_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
         // #1 - Prompter

        int min;
        int max;


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

         Console.WriteLine("Range from "+ min + " and " + max);
          

            // How could I make the user enter a number that's in between the min and max number?
            // That's in a loop?

            //if ()
            //{

            //}

        }
    }
}
