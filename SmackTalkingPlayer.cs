using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; } = "Yall might as well fold! I already know im gonna win";

        public override void Play(Player other)
        {
            Console.WriteLine(Taunt);
        }

    }
}