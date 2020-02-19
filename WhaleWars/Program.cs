using System;

namespace WhaleWars
{
    class Program
    {
        public static void Main()
        {
            Management.Title();

            Game.startGame();

            string name = Game.PlayerName();

            Whale Player = Game.nameCharacter(name);

            Game.Choice(Player);

            ConsoleInterface.Ship(Player);

        }
    }
}