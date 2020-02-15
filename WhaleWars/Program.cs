using System;

namespace WhaleWars
{
    class Program
    {
        public static void Main()
        {
            
            Whale dave = new Whale("steve", CharClass.fighter,10,10,10,ConsoleInterface.ShopList());
            ConsoleInterface.DisplayInventory(dave, ConsoleInterface.ShopList());
            //Management.mgmt();


        }
    }
}