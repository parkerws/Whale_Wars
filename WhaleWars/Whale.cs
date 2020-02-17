using System;
using System.Collections.Generic;
using System.Linq;
using System;

namespace WhaleWars
{
    public class Whale
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Offense { get; set; }
        public CharClass CC { get; set; }
        public int Wallet { get; set; }

        public Planet currentPlanet { get; set; }

        public Whale(string _name, CharClass cc, int _health, int _defense, int _offense)
        {
            Name = _name;
            CC = cc;
            Health = _health;
            Defense = _defense;
            Offense = _offense;
            Wallet = 5;
            currentPlanet = new Planet();
        } //Creates an easily referenced initializer so you dont have to type out each property of the given Whale

        public static Whale WhaleSelect(Whale Player, string name)
        {          
            Console.WriteLine("Please chose a class\n" +
                "1.) Fighter\n" +
                "2.) Ranger\n" +
                "3.) Mage\n");
            string pick = Console.ReadLine();           

            switch (pick)
            {
                case "1": { Player = new Whale(name, CharClass.fighter, 10, ArmoryDefense(Player), ArmoryOffense(Player)); return Player; }
                case "2": { Player = new Whale(name, CharClass.ranger, 10, ArmoryDefense(Player), ArmoryOffense(Player)); return Player; }
                case "3": { Player = new Whale(name, CharClass.mage, 10, ArmoryDefense(Player), ArmoryOffense(Player)); return Player; }
                default: return null;
            }

        }

        private List<Item> inventory = new List<Item>();
        public List<Weapon> EquipedWeapon = new List<Weapon>();
        public List<Armor> EquipedArmor = new List<Armor>();

        //public void SetWeapon(WeaponList weapon) // equip weapon if in inventory
        //{
        //    EquipedWeapon.Add(Weapon.CreateWeapon(weapon));
        //    Offense += EquipedWeapon.Last().Damage;
        //    //Defense += Armory.Last().Defense;
        //}

        public string GetWeapons()
        {
            string outString = "";
            foreach (Weapon ouchie in EquipedWeapon)
            {
                outString += ouchie.Name + "\n";
            }

            return outString;
        }

        public void SetArmor(Whale Player)
        {
            if (Player.CC == CharClass.fighter)
            {
                Plating plate = new Plating();
                EquipedArmor.Add(plate);                
            }

            if (Player.CC == CharClass.ranger)
            { 
                Chainmail chainmail = new Chainmail();
                EquipedArmor.Add(chainmail);                
            }

            if (Player.CC == CharClass.mage)
            {
                Cloth shirt = new Cloth();
                EquipedArmor.Add(shirt);
            }
            
        }

        public string GetInventory()
        {
            string outString = "";
            foreach (Item item in inventory)
            {
                outString += item.Name + "\n";
            }
            return outString;
        }

        public void AddItem(Item item)
        {
            inventory.Add(item);
        }

        public void RemoveItem(Item item) // to remove one-time use items..
        {
            inventory.Remove(item);
        }
        //public void BuyWeapon(int money, WeaponList weap)
        //{
        //    int cost;
        //    switch (weap)
        //    {
        //        case WeaponList.Sword:
        //            cost = 3;
        //            if (Wallet >= cost)
        //            {
        //                Wallet -= cost;
        //                SetWeapon(weap);
        //            }
        //            else Console.WriteLine("Not enough money!");
        //            break;

        //        case WeaponList.Wand:
        //            cost = 3;
        //            if (Wallet >= cost)
        //            {
        //                Wallet -= cost;
        //                SetWeapon(weap);
        //            }
        //            else Console.WriteLine("Not enough money!");
        //            break;

        //        case WeaponList.Bow:
        //            cost = 3;
        //            if (Wallet >= cost)
        //            {
        //                Wallet -= cost;
        //                SetWeapon(weap);
        //            }
        //            else Console.WriteLine("Not enough money!");
        //            break;

        //        case WeaponList.Knife:
        //            cost = 4;
        //            if (Wallet >= cost)
        //            {
        //                Wallet -= cost;
        //                SetWeapon(weap);
        //            }
        //            else Console.WriteLine("Not enough money!");
        //            break;

        //        case WeaponList.Chimichanga:
        //            cost = 6;
        //            if (Wallet >= cost)
        //            {
        //                Wallet -= cost;
        //                SetWeapon(weap);
        //            }
        //            else Console.WriteLine("Not enough money!");
        //            break;

        //        case WeaponList.Blowhole:
        //            cost = 6;
        //            if (Wallet >= cost)
        //            {
        //                Wallet -= cost;
        //                SetWeapon(weap);
        //            }
        //            else Console.WriteLine("Not enough money!");
        //            break;

        //        case WeaponList.UltraBoof:
        //            cost = 20;
        //            if (Wallet >= cost)
        //            {
        //                Wallet -= cost;
        //                SetWeapon(weap);
        //            }
        //            else Console.WriteLine("Not enough money!");
        //            break;
        //    }
        //} //Need to bind the cost to weapon?

        public static int ArmoryOffense(Whale Player)
        {
            int damage;
            try
            {
                int itemoffense = Player.EquipedWeapon.Last().Damage;
            }
            catch (Exception) { damage = 2; return damage; }

            Player.Offense = Player.EquipedWeapon.Last().Damage + 2;

            return Player.Offense;
        } //Please dont delete, it is used to add damage to the players offense in the HUD.
        public static int ArmoryDefense(Whale Player)
        {
            int defense;
            try
            {
                int itemdeffense = Player.EquipedArmor.Last().defenseModifier;
            }
            catch (Exception) { defense = 5; return defense; }

            Player.Defense = (Player.EquipedArmor.Last().defenseModifier + 5);

            return Player.Defense;
        } //Please dont delete, it is used to add the armor defense to the HUD\
 
    }
}