using System;

namespace WhaleWars
{
    class Program
    {
        public static void Main()
        {

            buildUniverse();
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

        // build universe
        public static void buildUniverse()
        {
            Planet start = new Planet();
            Planet george = new Planet("Titam III", PlanetType.ice, 4, 3, Sector.DeegosBogeySphere);
            Planet augustus = new Planet("BroomHuluia", PlanetType.lava, 5, 5, Sector.Blowholia);
            Planet yourMom = new Planet("Andromeda IV", PlanetType.storm, 3, 1, Sector.Krupula);
            Planet natesMom = new Planet("Demenchia Prime", PlanetType.temperate, 3, 2, Sector.DeegosBogeySphere);
        }
    }
    
}