using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            int secretNum = new Random().Next(1, 100);

            Console.WriteLine("choose your difficulty level! CHEATER - EASY - MEDIUM - HARD");
            string levelInput = Console.ReadLine().ToLower();
            int numOfChances = 4;

            while (levelInput != "easy" && levelInput != "medium" && levelInput != "hard" && levelInput != "cheater")
            {
                Console.WriteLine("choose your difficulty level! CHEATER - EASY - MEDIUM - HARD");
                levelInput = Console.ReadLine().ToLower();
            }


            if (levelInput == "easy")
            {
                numOfChances = 8;
            }
            else if (levelInput == "medium")
            {
                numOfChances = 6;
            }
            else if (levelInput == "hard")
            {
                numOfChances = 4;
            }

            else if (levelInput == "cheater")
            {
                numOfChances = 100;
            }

            for (int i = 0; i < numOfChances; i++)
            {


                Console.WriteLine($"Thers a secret number.... can you guess it?! (try {i + 1})");
                Console.WriteLine("...whats your guess??");
                string userAnswer = Console.ReadLine();
                int UserAnswer = int.Parse(userAnswer);


                if (UserAnswer == secretNum)
                {
                    Console.WriteLine("Youre Right!! CONGRATS!!!");
                    break;

                }
                else
                {
                    if (UserAnswer > secretNum)
                    {
                        Console.WriteLine("noooo.. TOO HIGH! try agian :(");
                    }
                    else
                    {
                        Console.WriteLine("noooo.. TOO LOW! try agian :(");

                    }
                }
            }





        }


    }

}

