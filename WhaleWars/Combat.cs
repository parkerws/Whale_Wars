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

                Thread.Sleep(2500);
                if (user.Health <= 0) { ConsoleInterface.PlayerDied(user, target); }
                if (target.Health <= 0) { ConsoleInterface.WinArt(target); return; }
                ConsoleInterface.HUD(user); 

                Enemies.EnemyAI(user, target);
                Thread.Sleep(2500);
                if (user.Health <= 0) { ConsoleInterface.PlayerDied(user, target); }
                if (target.Health <= 0) { ConsoleInterface.WinArt(target); return; }
            }                                                                                             
           
        }                            
    }
}

