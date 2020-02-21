using System;
using System.Media;


namespace WhaleWars
{
    class Program

    {
        public static void Main()
        {


            SoundPlayer WWTheme = new SoundPlayer("WW_Background.wav");
            WWTheme.Play();


            Management.Title();

            Game.startGame();

            string name = Game.PlayerName();

            Whale Player = Game.nameCharacter(name);

            Game.Choice(Player);

            Game.preBlowholiaDialog(Player);

            Game.BlowholiaDialog(Player);

            ConsoleInterface.Ship(Player);

        }

    }
}
