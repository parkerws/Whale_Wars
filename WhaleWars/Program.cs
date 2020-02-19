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
            
            
           // Whale Player = Management.Mgmt(name);

            ConsoleInterface.Ship(Player);

        }
    }
}