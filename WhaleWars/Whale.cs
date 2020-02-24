using System;
using System.Collections.Generic;
using System.Linq;

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
        public int MagicPoints { get; set; }
        public Planet currentPlanet { get; set; }

        public Whale(string _name, CharClass cc, int _health, int _defense, int _offense, int magicpoints)
        {
            Name = _name;
            CC = cc;
            Health = _health;
            Defense = _defense;
            Offense = _offense;
            Wallet = 5;
            MagicPoints = magicpoints;
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
                case "1": { Player = new Whale(name, CharClass.fighter, 10, ArmoryDefense(Player), ArmoryOffense(Player), 10); return Player; }
                case "2": { Player = new Whale(name, CharClass.ranger, 10, ArmoryDefense(Player), ArmoryOffense(Player), 10); return Player; }
                case "3": { Player = new Whale(name, CharClass.mage, 10, ArmoryDefense(Player), ArmoryOffense(Player), 10); return Player; }
                default: return null;
            }

        }

        public List<Item> inventory = new List<Item>();
        public List<Weapon> EquipedWeapon = new List<Weapon>();
        public List<Armor> EquipedArmor = new List<Armor>();

        public string GetWeapons()
        {
            string outString = "";
            foreach (Weapon ouchie in EquipedWeapon)
            {
                outString += ouchie.Name + "\n";
            }

            return outString;
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

        public static int ArmoryOffense(Whale Player)
        {
            if (Player.CC == CharClass.fighter)
            {
                int damage;
                try
                {
                    int itemoffense = Player.EquipedWeapon.Last().Damage;
                }
                catch (Exception) { damage = 2; return damage; }

                Player.Offense = Player.EquipedWeapon.Last().Damage + 2;

                return Player.Offense;
            }
            if (Player.CC == CharClass.mage)
            {
                int damage;
                try
                {
                    int itemoffense = Player.EquipedWeapon.Last().Damage;
                }
                catch (Exception) { damage = 6; return damage; }

                Player.Offense = Player.EquipedWeapon.Last().Damage + 6;

                return Player.Offense;
            }
            if (Player.CC == CharClass.ranger)
            {
                int damage;
                try
                {
                    int itemoffense = Player.EquipedWeapon.Last().Damage;
                }
                catch (Exception) { damage = 4; return damage; }

                Player.Offense = Player.EquipedWeapon.Last().Damage + 4;

                return Player.Offense;
            }
            return 0;
        } //This is used to add base damage to the players offense based off of they CharClass.
        public static int ArmoryDefense(Whale Player)
        {
            if (Player.CC == CharClass.fighter)
            {
                int defense;
                try
                {
                    int itemdeffense = Player.EquipedArmor.Last().defense;
                }
                catch (Exception) { defense = 6; return defense; }

                Player.Defense = (Player.EquipedArmor.Last().defense + 6);

                return Player.Defense;
            }
            if (Player.CC == CharClass.mage)
            {
                int defense;
                try
                {
                    int itemdeffense = Player.EquipedArmor.Last().defense;
                }
                catch (Exception) { defense = 2; return defense; }

                Player.Defense = (Player.EquipedArmor.Last().defense + 2);

                return Player.Defense;
            }
            if (Player.CC == CharClass.ranger)
            {
                int defense;
                try
                {
                    int itemdeffense = Player.EquipedArmor.Last().defense;
                }
                catch (Exception) { defense = 4; return defense; }

                Player.Defense = (Player.EquipedArmor.Last().defense + 4);

                return Player.Defense;
            }
            return 0;
        } //Please dont delete, it is used to add the armor defense to the HUD\
        public static void StartItems(Whale Player)
        {
            SetArmor(Player);
            SetWeapon(Player);
            SetItems(Player);

        } // assignes the starting items to the player to help expand the inventory.
        public static void SetWeapon(Whale Player)
        {
            if (Player.CC == CharClass.fighter)
            {
                Sword sword = new Sword();
                Player.EquipedWeapon.Add(sword);

            }

            if (Player.CC == CharClass.ranger)
            {
                Bow bow = new Bow();
                Player.EquipedWeapon.Add(bow);
            }

            if (Player.CC == CharClass.mage)
            {
                Wand wand = new Wand();
                Player.EquipedWeapon.Add(wand);
            }
        } //used to add a starting Weapon bassed off of starting class.
        public static void SetArmor(Whale Player)
        {
            if (Player.CC == CharClass.fighter)
            {
                Plating plate = new Plating();
                Player.EquipedArmor.Add(plate);

            }

            if (Player.CC == CharClass.ranger)
            {
                Chainmail chainmail = new Chainmail();
                Player.EquipedArmor.Add(chainmail);
            }

            if (Player.CC == CharClass.mage)
            {
                Cloth shirt = new Cloth();
                Player.EquipedArmor.Add(shirt);
            }
        } //used to add a starting Armor bassed off of starting class.
        public static void SetItems(Whale Player)
        {
            if (Player.CC == CharClass.fighter) 
            {
                Player.inventory.Add(Item.ItemGen("health"));
                Player.inventory.Add(Item.ItemGen("health"));
                Player.inventory.Add(Item.ItemGen("health"));
            }
            if (Player.CC == CharClass.mage)
            {
                Player.inventory.Add(Item.ItemGen("magic"));
                Player.inventory.Add(Item.ItemGen("magic"));
                Player.inventory.Add(Item.ItemGen("magic"));
            }
            if (Player.CC == CharClass.ranger)
            {
                Player.inventory.Add(Item.ItemGen("health"));
                Player.inventory.Add(Item.ItemGen("health"));
                Player.inventory.Add(Item.ItemGen("magic"));
            }
        }

        public static void UpgradeWeapon(Whale Player, Weapon newWeap) 
        {
            Weapon oldWeapon = Player.EquipedWeapon.Last();
            Player.EquipedWeapon.Remove(oldWeapon);
            Player.inventory.Add(oldWeapon);
            Player.EquipedWeapon.Add(newWeap);
        }

        public static void UpgradeArmor(Whale Player, Armor newArmor)
        {
            Armor oldArmor = Player.EquipedArmor.Last();
            Player.inventory.Add(oldArmor);
            Player.EquipedArmor.Remove(oldArmor);
            Player.EquipedArmor.Add(newArmor);
        }

        //public static void changeWeapon(Whale player)
        //{
        //    int counter = 1;
        //    int weapSelection;
        //    List<Weapon> weapList = new List<Weapon>();
        //    Console.WriteLine();
        //    foreach(Weapon weap in player.inventory)
        //    {
        //        Console.WriteLine($"{counter}. {weap}");
        //        weapList.Add(weap);
        //        counter++;
        //    }
        //    Console.WriteLine("Select which weapon you wish to equip.");
        //    if (int.TryParse(Console.ReadLine(), out weapSelection))
        //    {
        //        weapSelection -= 1;
        //    }
        //    else Console.WriteLine("Invalid input. Please select from the above list.");

        //    UpgradeWeapon(player, weapList.ElementAt(weapSelection));
        //    player.RemoveItem(weapList.ElementAt(weapSelection));
        //}

        public static void UseItem(Whale Player)
        {
            int counter = 1;
            int itemSelection;
            Console.WriteLine("Which item would you like to use?");
            foreach (var i in Player.inventory)
            {
                Console.WriteLine($"{counter++}: {i.Name}");
            }

            if (int.TryParse(Console.ReadLine(), out itemSelection))
            {
                if (Player.inventory.ElementAt(itemSelection - 1) is HealthPotion)
                {
                    Player.Health += Player.inventory[itemSelection - 1].attributeIncrease;
                    Player.inventory.Remove(Player.inventory.ElementAt(itemSelection - 1));
                }

                else if (Player.inventory.ElementAt(itemSelection - 1) is ArmorPotion)
                {
                    Player.Offense += Player.inventory[itemSelection - 1].attributeIncrease;
                    Player.inventory.Remove(Player.inventory.ElementAt(itemSelection - 1));
                }

                else if (Player.inventory.ElementAt(itemSelection - 1) is MagicPotion)
                {
                    Player.MagicPoints += Player.inventory[itemSelection - 1].attributeIncrease;
                    Player.inventory.Remove(Player.inventory.ElementAt(itemSelection - 1));
                }
            }

        }
    }
}