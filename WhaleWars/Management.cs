using System;
using System.Collections.Generic;

namespace WhaleWars
{
    public class Management
    {

        const int TYPESPEED = 30;


        public static void mgmt()
        {
            title();
            List<Weapon> Inventory = new List<Weapon>();
            Whale UserChoice = new Whale("name", CharClass.fighter, 1, 1, 1, Inventory);
            { UserChoice = Whale.WhaleSelect(UserChoice); }

            ConsoleInterface.HUD(UserChoice.Name, "Planet", 0, UserChoice.Health, UserChoice.Offense, UserChoice.Defense);
            
           UserChoice.Armory.Add(Weapon.WeaponGen());
           Whale.FD(UserChoice);
            

            Combat.Battle(UserChoice,Enemies.EnemyGenerator());
        }
        public static void title()
        {
            //Console.SetWindowSize(100, 50);
            //Console.BufferHeight = 100;
            //Console.BufferWidth = 150;

            Typewrite("A long time ago...\n", TYPESPEED);
            Typewrite("In an ocean of space....\n", TYPESPEED);
            Typewrite("Far Far away...\n", TYPESPEED);
            Typewrite("There was a whale...\n", TYPESPEED);
            Typewrite("Floating aimlessly through the void...\n", TYPESPEED);
            Typewrite("", TYPESPEED);
            printTitle();
            Welcome();
            Console.ReadKey();
        }
        static void Typewrite(string message, int speed)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(speed);
            }
        }
        static void printTitle()
        {
            Console.Title = "ASCII Art";
            string title = @"
 __      __ __            __            __      __                      
/  \    /  \  |__ _____  |  |   ____   /  \    /  \_____ _______  ______
\   \/\/   /  |  \\__  \ |  | _/ __ \  \   \/\/   /\__  \\_  __ \/  ___/
 \        /|   Y  \/ __ \|  |_\  ___/   \        /  / __ \|  | \/\___ \ 
  \__/\  / |___|  (____  /____/\___  >   \__/\  /  (____  /__|  /____  >
       \/       \/     \/          \/         \/        \/           \/                                  
                                                                 ";
            Typewrite(title, 5);
        }
        
        static void Welcome()
        {
            Typewrite("A Group-One production.\n\t\t\t\t\t\t\t\t A Chartreuse Dysentery Amoeba Game.\n", TYPESPEED);
        }
    }
}