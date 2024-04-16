using System;

namespace Deliverable2
{
    public class CoinFlipper
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
            Console.WriteLine("What is your name?");
            string user = Console.ReadLine();

            Console.WriteLine("Welcome " + user + ".  Do you want to do " +
                "the COIN FLIP CHALLENGE? Yes/No");
            string answer = Console.ReadLine();

            if (answer.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                Random coin = new Random();
                int flip;
                int userScore = 0;

                //1 is heads, 0 is tails
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Heads or Tails?: ");
                    string wager = Console.ReadLine();
                    flip = coin.Next(2);

                    if (wager.Equals("Heads", StringComparison.OrdinalIgnoreCase) && flip == 1)
                    {
                        Console.WriteLine("Correct!");
                        userScore++;
                    }
                    else if (wager.Equals("Tails", StringComparison.OrdinalIgnoreCase) && flip == 0)
                    {
                        Console.WriteLine("Correct!");
                        userScore++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong!");
                    }
                }
                Console.WriteLine("Thank you " + user + ". Your score was " + userScore);
            }
            else
            {
                Console.WriteLine("You are a coward " + user);
            }

        }
    }
}