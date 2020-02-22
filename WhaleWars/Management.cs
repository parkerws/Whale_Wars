using System;
using System.Collections.Generic;

namespace WhaleWars
{
    public class Management
    {

        const int TYPESPEED = 15;


       
        public static void Title()
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
            PrintTitle();
            Welcome();
            Console.WriteLine("Press Enter To continue");
            ConsoleInterface.Input();
        }
        private static void Typewrite(string message, int speed)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(5);
            }
        }
        static void PrintTitle()
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
            Console.WriteLine(title, 5);
        }
        
        static void Welcome()
        {
            Typewrite("A Group-One Production.\n\t\t\t\t\t\t\t\t A Chartreuse Dysentery Amoeba Game.\n", TYPESPEED);
        }

      
    }
}