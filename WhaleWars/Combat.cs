using System;
using System.Threading;

namespace WhaleWars
{
	public class Combat
	{
        //Used as a test battle between two entities.
        public static void Battle(Whale user, Enemies target)
        {
            //While loop used to simulate a fight.
            while (user.Health > 0 || target.Health > 0)                                                  
            {                                                                                             
                ConsoleInterface.HUD(user);
                if (user.CC == CharClass.mage) { Mage.MageMoves(user, target); }
                if (user.CC == CharClass.fighter) { Fighter.FighterMoves(user, target); }
                if (user.CC == CharClass.ranger) { Ranger.RangerMoves(user, target); }

                Thread.Sleep(2900);
                if (user.Health <= 0) { ConsoleInterface.PlayerDied(user, target); }
                if (target.Health <= 0) { user.Wallet += 3; ConsoleInterface.WinArt(user, target); return; }
                ConsoleInterface.HUD(user); 

                Enemies.EnemyAI(user, target);
                Thread.Sleep(2900);
                if (user.Health <= 0) { ConsoleInterface.PlayerDied(user, target); }
                if (target.Health <= 0) { user.Wallet = +3; ConsoleInterface.WinArt(user, target); return; }
            }
            
            
        }

        public static void Battle(Whale Player, Enemies target, Enemies target2)
        {
            //While loop used to simulate a fight.
            while (Player.Health > 0 || target.Health > 0 && target2.Health > 0)
            {
                ConsoleInterface.HUD(Player);
                if (Player.CC == CharClass.mage) { Mage.MageMoves(Player, target); }
                if (Player.CC == CharClass.fighter) { Fighter.FighterMoves(Player, target); }
                if (Player.CC == CharClass.ranger) { Ranger.RangerMoves(Player, target); }

                Thread.Sleep(2900);
                if (target.Health <= 0) { Player.Wallet += 3; Battle(Player, target2); return; }
                if (target2.Health <= 0) { Player.Wallet += 3; Battle(Player, target); return; }
                ConsoleInterface.HUD(Player);

                Enemies.EnemyAI(Player, target);
                Thread.Sleep(2900);
                if (Player.Health <= 0) { ConsoleInterface.PlayerDied(Player, target); }
                if (target.Health <= 0) { Player.Wallet = +3; Battle(Player, target2); return; }
                if (target2.Health <= 0) { Player.Wallet = +3; Battle(Player, target); return; }

                Enemies.EnemyAI(Player, target2);
                Thread.Sleep(2900);
                if (Player.Health <= 0) { ConsoleInterface.PlayerDied(Player, target); }
                if (target.Health <= 0) { Player.Wallet = +3; Battle(Player, target2); return; }
                if (target2.Health <= 0) { Player.Wallet = +3; Battle(Player, target); return; }
            }


        }
        public static void EndBattle(Whale user, Enemies target)
        {
            //While loop used to simulate a fight.
            while (user.Health > 0 || target.Health > 0)
            {
                ConsoleInterface.HUD(user);
                if (user.CC == CharClass.mage) { Mage.MageMoves(user, target); }
                if (user.CC == CharClass.fighter) { Fighter.FighterMoves(user, target); }
                if (user.CC == CharClass.ranger) { Ranger.RangerMoves(user, target); }

                Thread.Sleep(2900);
                if (user.Health <= 0) { ConsoleInterface.PlayerDied(user, target); }
                if (target.Health <= 0) { user.Wallet += 3; ConsoleInterface.WinArt(user, target); return; }
                ConsoleInterface.HUD(user);

                Enemies.LundfinAI(user, target);
                Thread.Sleep(2900);
                if (user.Health <= 0) { ConsoleInterface.PlayerDied(user, target); }
                if (target.Health <= 0) { user.Wallet = +3; ConsoleInterface.WinArt(user, target); return; }
            }


        }
    }
}

