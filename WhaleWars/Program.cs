using System;

namespace WhaleWars
{
    class Program
    {
        public static void Main()
        {
            Management.Title();

            string name = Management.PlayerName();
            
            Whale Player = Management.Mgmt(name);

            ConsoleInterface.Ship(Player);

        }
    }
}