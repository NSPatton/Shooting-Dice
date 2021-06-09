using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public int myRoll { get; }

        public HumanPlayer()
        {
            Console.Write("Please enter a number > ");

            myRoll = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"You have entered {myRoll}");
        }
    }
}