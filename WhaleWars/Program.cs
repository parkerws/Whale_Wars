using System;

namespace WhaleWars
{
    class Program
    {
        public static void Main()
        {
            
            Management.mgmt();     

            Whale Stinky = new Whale("poofie", CharClass.fighter, 10, 10, 10);

            Stinky.SetWeapon(WeaponList.Sword);
            Console.WriteLine(Stinky.Offense);
            Stinky.SetWeapon(WeaponList.Blowhole);
            Console.WriteLine(Stinky.Offense);
            Stinky.SetWeapon(WeaponList.Sword);
            Console.WriteLine(Stinky.Offense);
            Console.WriteLine(Stinky.GetWeapons());


        }
    }
}