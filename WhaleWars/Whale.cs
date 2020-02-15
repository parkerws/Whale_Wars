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

        public static Whale WhaleSelect(Whale UserChoice)
        {
            Console.WriteLine("Please input a name\n");
            string name = Console.ReadLine();
            Console.WriteLine("Please chose a class\n" +
                "1.) Fighter\n" +
                "2.) Ranger\n" +
                "3.) Mage\n");
            string pick = Console.ReadLine();
            // int ClassPicker = Convert.ToInt32(pick);
        

            switch (pick)
            {
                case "1": { UserChoice = new Whale(name, CharClass.fighter, 10, 5, 2); return UserChoice; }
                case "2": { UserChoice = new Whale(name, CharClass.ranger, 10, 4, 3); return UserChoice; }
                case "3": { UserChoice = new Whale(name, CharClass.mage, 10, 2, 4); return UserChoice; }
                default: return null;
            }

        }

        private List<Item> inventory = new List<Item>();
        public List<Weapon> Armory = new List<Weapon>();

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
        public void BuyWeapon(int money, WeaponList weap)
        {
            int cost;
            switch (weap)
            {
                case WeaponList.Sword:
                    cost = 3;
                    if (Wallet >= cost)
                    {
                        Wallet -= cost;
                        SetWeapon(weap);
                    }
                    else Console.WriteLine("Not enough money!");
                    break;

                case WeaponList.Wand:
                    cost = 3;
                    if (Wallet >= cost)
                    {
                        Wallet -= cost;
                        SetWeapon(weap);
                    }
                    else Console.WriteLine("Not enough money!");
                    break;

                case WeaponList.Bow:
                    cost = 3;
                    if (Wallet >= cost)
                    {
                        Wallet -= cost;
                        SetWeapon(weap);
                    }
                    else Console.WriteLine("Not enough money!");
                    break;

                case WeaponList.Knife:
                    cost = 4;
                    if (Wallet >= cost)
                    {
                        Wallet -= cost;
                        SetWeapon(weap);
                    }
                    else Console.WriteLine("Not enough money!");
                    break;

                case WeaponList.Chimichanga:
                    cost = 6;
                    if (Wallet >= cost)
                    {
                        Wallet -= cost;
                        SetWeapon(weap);
                    }
                    else Console.WriteLine("Not enough money!");
                    break;

                case WeaponList.Blowhole:
                    cost = 6;
                    if (Wallet >= cost)
                    {
                        Wallet -= cost;
                        SetWeapon(weap);
                    }
                    else Console.WriteLine("Not enough money!");
                    break;

                case WeaponList.UltraBoof:
                    cost = 20;
                    if (Wallet >= cost)
                    {
                        Wallet -= cost;
                        SetWeapon(weap);
                    }
                    else Console.WriteLine("Not enough money!");
                    break;
            }
        }
    }
}