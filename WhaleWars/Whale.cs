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
        public List<Weapon> Armory { get; set; }

        public Whale(string _name, CharClass cc, int _health, int _defense, int _offense, List<Weapon> _armory)
        {
            Name = _name;
            CC = cc;
            Health = _health;
            Defense = _defense;
            Offense = _offense;
            Armory = _armory;
        } //Creates an easily referenced intializer so you dont have to type out each property of the given Whale

        public static Whale WhaleSelect(Whale UserChoice)
        {
            Console.WriteLine("Please input a name\n");
            string name = Console.ReadLine();
            Console.WriteLine("Please chose a class\n" +
                "1.) Fighter\n" +
                "2.) Ranger\n" +
                "3.) Mage\n");
            string pick = Console.ReadLine();

            switch (pick)
            {
                case "1": { UserChoice = new Whale(name, CharClass.fighter, 10, 5, FD(UserChoice), UserChoice.Armory); return UserChoice;}
                case "2": { UserChoice = new Whale(name, CharClass.ranger, 10, 4, RD(UserChoice), UserChoice.Armory); return UserChoice; }
                case "3": { UserChoice = new Whale(name, CharClass.mage, 10, 2, MD(UserChoice), UserChoice.Armory); return UserChoice; }
                default: return null;
            }

        }

        private List<Item> inventory = new List<Item>();
        //private List<Weapon> Armory = new List<Weapon>();

        public static int ArmOff(Whale user)
        {
           int damage;
            try
            {
                int itemoffense = user.Armory.Last().Damage;
            }
            catch (Exception){ damage = 0; return damage; }
            
            damage = user.Armory.Last().Damage;             
            
            return damage;
        }//gets the offense of the items in the Armory inventory
        public static int FD(Whale user)
        {
            int damage = ArmOff(user);
            user.Offense += damage + 2;

            return user.Offense;
        }//Adds the weapons damage to the base damage of the UserChoice Fighter Whale.
        public static int RD(Whale user)
        {
            user.Offense += (Whale.ArmOff(user) + 3);
            return user.Offense;
        }//Adds the weapons damage to the base damage of the UserChoice Ranger Whale.
        public static int MD(Whale user)
        {
            user.Offense += (Whale.ArmOff(user) + 4);
            return user.Offense;
        }//Adds the weapons damage to the base damage of the UserChoice Mage Whale.

        public void SetWeapon(WeaponList weapon) // equip weapon if in inventory
        {
            Armory.Add(Weapon.CreateWeapon(weapon));
            Offense += Armory.Last().Damage;
            Defense += Armory.Last().Defense;
        }

        public string GetWeapons()
        {
            string outString = "";
            foreach (Weapon ouchie in Armory)
            {
                outString += ouchie.Name + "\n";
            }

            return outString;
        }

        public void SetArmor(CharClass cc)
        {
            switch (cc)
            {
                case CharClass.fighter:
                    Plating plate = new Plating();
                    Defense += plate.defenseModifier;
                    break;

                case CharClass.ranger:
                    Chainmail chainmail = new Chainmail();
                    Defense += chainmail.defenseModifier;
                    break;

                case CharClass.mage:
                    Cloth shirt = new Cloth();
                    Defense += shirt.defenseModifier;
                    break;

            }
        }

        public void GetStats() { }

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

        public void RemoveItem(Item item) // to remove on-time use items..
        {
            inventory.Remove(item);
        }
    }
}