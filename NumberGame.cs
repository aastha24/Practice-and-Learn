using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("~~ WELCOME TO GUESS NUMBER GAME! ~~");
            int guessednumber = 0;
            int count = 0;
            while (count==0)
            {
                Console.WriteLine("Enter your number guess between 1 and 100! Best of luck!:");
                guessednumber = int.Parse(Console.ReadLine());
				int correctNumber = new Random().Next(1, 101);
                Console.WriteLine($"Generated number {correctNumber} and Guessed number is {guessednumber}");
                if (guessednumber == correctNumber)
                {
                    Console.WriteLine("Congratulations You won the game! :D ");
                    count = 1;
                }
                else
                    Console.WriteLine("Sorry! :( Try again! ");
            }
        }
    }

}
