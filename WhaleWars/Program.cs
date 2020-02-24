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

            ConsoleInterface.Goose1(Player);

            ConsoleInterface.Shop1(Player);

            ConsoleInterface.Ship1(Player);

            Game.AtlantisDialog(Player);

            Game.postAtlantisDialog(Player);

            ConsoleInterface.Ship2(Player);

            Game.CoraltonDialog(Player);

            Game.postCoraltonDialog(Player);

            ConsoleInterface.Ship3(Player);

            Game.BlubbernotDialog(Player);

            Game.postBlubbernotDialog(Player);

            ConsoleInterface.Ship4(Player);

            Game.trenchDialog(Player);

            Game.PreTrenchChoice(Player);

            Game.trenchDialog1(Player);

            Game.posttrenchDialog(Player);




        }

    }
}
