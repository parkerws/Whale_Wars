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

        public Whale(string _name, CharClass cc, int _health, int _defense, int _offense)
        {
            Name = _name;
            CC = cc;
            Health = _health;
            Defense = _defense;
            Offense = _offense;
        } //Creates an easily referenced intializer so you dont have to type out each property of the given Whale

        private List<Item> inventory = new List<Item>();
        private List<Weapon> Armory = new List<Weapon>();

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