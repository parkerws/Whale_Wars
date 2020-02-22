using System;
using System.Media;


namespace WhaleWars
{
    class Program

    {
       public static void Main()
        {
            NetCoreAudio.Player WWTheme = new NetCoreAudio.Player();            
                WWTheme.Play("WW_Background.wav");            

            Management.Title();

            Game.startGame();

            string name = Game.PlayerName();

            Whale Player = Game.nameCharacter(name);

            Game.Choice(Player);

            Game.preBlowholiaDialog(Player);

            Game.BlowholiaDialog(Player);

            Game.postBlowholiaDialog(Player);

            ConsoleInterface.Ship(Player);

            Game.AtlantisDialog(Player);

            Game.postAtlantisDialog(Player);

            ConsoleInterface.Ship(Player);

            Game.CoraltonDialog(Player);

            Game.postCoraltondialog(Player);
            
            ConsoleInterface.Ship(Player);

        }

    }
}
