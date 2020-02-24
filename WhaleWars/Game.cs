using System;
using System.Collections.Generic;
using System.Text;

namespace WhaleWars
{
    class Game
    {

        //Character name
        //static string characterName = "";
        //Print out game title and setup

        public static Planet Blowholia = new Planet("Blowholia Prime", PlanetType.ocean, 1, 2, Sector.Blowholia);
        public static Planet Atlantis = new Planet("Atlantis", PlanetType.storm, 3, 4, Sector.DeegosBogeySphere);
        public static Planet Coralton = new Planet("Coralton", PlanetType.barren, 4, 5, Sector.Krupula);
        public static Planet Blubbernot = new Planet("Blubbernot", PlanetType.lava, 1, 5, Sector.Morhann);
        public static Planet Trench = new Planet("Marianna Trench", PlanetType.ice, 3, 4, Sector.Morhann);

        public static void startGame()
        {
            //Fastwrite("Whale Wars!", "blue\n");
          //  Console.WriteLine("\nPress Space to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Typewrite("\nWelcome to the console based adventure game!", "dialog");
            Fastwrite("\nYou wake up floating through space...", "dialog");
            Console.WriteLine("\nPress the Spacebar to continue...");
            Console.ReadKey();
           // nameCharacter();

        }

        public static string PlayerName()
        {
            Console.Clear();
            Typewrite("\nWhat is thy name?", "self");
            Fastwrite("\nType in your name: ", "dialog\n");
            string name = ConsoleInterface.Input();
            return name;
        }

        //ask plaer for a name and save it
        public static Whale nameCharacter(string name)
        {
            Console.Clear();            
            
            Whale Player = new Whale(name, CharClass.fighter, 1, 1, 1, 1);
            Player = Whale.WhaleSelect(Player, name);

            Whale.StartItems(Player);

            ConsoleInterface.HUD(Player);

            Typewrite($"\n{Player.Name}", "yellow");
            Typewrite("...ya, It's all coming back to me now", "self");
            Typewrite("\n... What happened?", "self");
            Typewrite("\n... Where am I?", "self");
            Console.WriteLine("\nPress Space to continue...");
            Console.ReadKey();
            Console.Clear();

            ConsoleInterface.HUD(Player);

            Fastwrite("\nYou look around... You see thousands of stars...", "dialog");
            Typewrite("\n...I must have blacked out...", "self");
            Typewrite("\n...I don't remember anything.", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();

            ConsoleInterface.HUD(Player);

            Fastwrite("\nYou see a small planet off in the distance...", "dialog");
            Typewrite("\nThat looks like Blowholia Prime... wait...", "self");
            Typewrite("\nBlowholia... I think I was there... something bad happened...", "self");
            Typewrite("\nI can't remember... maybe they'll have some answers", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            return Player;
        }

        public static void Choice(Whale Player)
        {
            ConsoleInterface.HUD(Player);

            string input = "";
            Typewrite($"\n{Player.Name}", "yellow");
            Fastwrite(", Do you want to go too Blowholia Prime?", "dialog");
            Console.WriteLine("\nY) Yes" +
                "\nN) No");            
            input = Console.ReadLine();
            input = input.ToUpper();
            if (input == "Y")
            {
                Fastwrite("\n You point the ship towards Blowholia Prime\n", "dialog");
                Console.WriteLine("Press Space to continue.");
                Console.ReadKey();
            }
            else
            {
                ConsoleInterface.ShipIntro(Player);
            }

        }

        public static void preBlowholiaDialog(Whale Player)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);

            Typewrite("\nMeanwhie on Blowholia...", "dialog");
            Fastwrite("\nThe sounds of exploading space cannons and dolphin's laugh tear through the thin Blowholia morning air","red");
            Typewrite("\nBrave Blowholian solders are trudging through the mud of the battle field.","dialog");
            Typewrite("\n\"Is the day lost sir?\"", "friend");
            Typewrite("one Blowholian sergeant says to", "dialog");
            Typewrite(" Captain Whalord-Hookfin", "friend");
            Typewrite("\nCpt.Hookfin: \"For today.. But hope is not\"", "friend");
            Typewrite("\nHe say's with a grin, as he watches your ship enter the atmosphere.\n", "dialog");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();

        }

        public static void BlowholiaDialog(Whale Player)
        {
            Player.currentPlanet = Blowholia;
            ConsoleInterface.HUD(Player);
            Enemies enemy = Enemies.EnemyGenerator();
 
            Fastwrite("\nYour ship comes to a halt on the outskirts of Blowholia's capital city: ", "dialog");
            Typewrite("Pier-182", "location");
            Typewrite("\nTime to get some answers.", "self");
            Fastwrite("\n\"Arrived: Blowholia Prime\"", "friend");
            Typewrite(" the ships AI says over the inter-com.", "dialog");
            Fastwrite("\n\"Population: 5\"", "friend");
            Typewrite("\n 5!? How can that be?", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nYou quickly exit your ship and gaze upon the ruins of ", "dialog");
            Typewrite("Pier-182.", "location");
            Typewrite("\nWhat happened here?", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nAll of a sudden, you hear the cackle of a dolphin!", "dialog");
            Typewrite("\nOut of the fog steps the notorious", "dialog");
            Fastwrite(" Dolph Lundphin!", "enemy");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nLundphin! ", "enemy");
             Fastwrite("I should've known this was your doing!", "self");
            Typewrite("\nLundphin: You've made a big mistake comming back here, ", "enemy");
            Typewrite($"{Player.Name}!", "self");
            Fastwrite("\nMy cronies will rip you to sheds!", "enemy");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nNow you're going to die by the hand of my minion, ","enemy");
            Fastwrite($"{enemy.Name}!", "yellow");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Combat.Battle(Player, enemy);

        }

        public static void postBlowholiaDialog(Whale Player)
        {
            ConsoleInterface.HUD(Player);
            Typewrite("\nVery good, ", "enemy");
            Typewrite($"{Player.Name},", "self");
            Typewrite(" You've only defeated my weakest minion!","enemy");
            Fastwrite("\nNEXT TIME IT WONT BE SO EASY!", "enemy");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nLundfin's ", "enemy");
            Typewrite("ship descends from the sky and lands behind him.", "dialog");
            Typewrite("\nHe and his gang climb abord and take off.", "dialog");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nI knew you'd return, ", "friend");
            Typewrite($"Admiral {Player.Name} Whaleworth.","self");
            Typewrite("\nAdmiral?", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nCpt. Whalord-Hookfin", "friend");
            Typewrite(" steps into view.", "dialog");
            Typewrite("\nCpt. Hookfin: Yes, sir! you lead the defence of Blowholia.", "friend");
            Typewrite("\nYou look around at the world in ruins.", "dialog");
            Typewrite("\nWell, what a bang up job I did...", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nYou shouldn't be so hard on yourself, sir. After all you were TAKEN!", "friend");
            Typewrite("\nTaken?", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nYes, sir. About halfway through the battle. They loaded you up on that ship there.", "friend");
            Typewrite("\nHe gestures to the ship you arrived on.", "dialog");
            Typewrite("\nI wasn't worried though, sir. I knew youd make it back. Just a matter of time.","friend");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nWell I guess that explains that. I need to go after ", "self");
            Fastwrite("Lundfin.", "enemy");
            Typewrite("\nWell, He's probably halfway to ", "friend");
            Fastwrite("Atlantis", "location");
            Typewrite(" by now!", "friend");
            Typewrite("\nAtlantis", "location");
            Typewrite("? Whats that?", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nThat's the next planet he planned to take on his path to conquer the Galaxy!", "friend");
            Typewrite("\nThen thats where I'm headed, thanks for your help, ", "self");
            Typewrite("Cpt.Hookfin.", "friend");
            Typewrite("\nYou start to walk towards the ship.", "dialog");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nI'd, make an upgrade while you travel if you can afford it!", "friend");
            Typewrite("\nThe next ", "friend");
            Fastwrite("Henchmen", "yellow");
            Typewrite(" you face will propably be tougher than the one you just killed!","friend");
            Typewrite("\nThanks for the tip, Cpt.", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);

        }

        public static void AtlantisDialog(Whale Player)
        {
            Player.currentPlanet = Atlantis;
            Enemies enemy = Enemies.EnemyGenerator();
            ConsoleInterface.HUD(Player);
            Typewrite("\nYour ship lands on ","dialog");
            Typewrite("Atlantis.", "location");
            Typewrite("\n Alright ", "self");
            Fastwrite("Lundphin,", "enemy");
            Typewrite(" lets see what you've got next,", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nAs you exit the ship you can hear the sounds of screaming Atlanteans", "dialog");
            Fastwrite("\nLundfin!", "enemy");
            Typewrite(" I've got to stop him!", "self");
            Typewrite("\nYou charge into the city of ", "dialog");
            Typewrite("Atlantis.", "location");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nYou see ", "dialog");
            Fastwrite("Dolph Lunphin", "enemy");
            Typewrite(" and his ", "dialog");
            Fastwrite("Henchmen", "yellow");
            Typewrite(" attacking civilian Atlanteans.", "dialog");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nENOUGH ", "self");
            Fastwrite("LUNPHIN!", "enemy");
            Typewrite("\nLundphin: Come back for more, ", "enemy");
            Typewrite($"{Player.Name}?", "self");
            Fastwrite($"\n{enemy.Name}, ", "yellow");
            Fastwrite("DESTROY HIM!", "enemy");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Combat.Battle(Player, enemy);
        }

        public static void postAtlantisDialog(Whale Player)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nYOU FOOL! I just needed him to buy me time to escape!","enemy");
            Typewrite("\nLundphin", "enemy");
            Typewrite(" shouts from atop his ship.", "dialog");
            Fastwrite("\nSee you at the next one, ", "enemy");
            Fastwrite($"{Player.Name}!", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nHis ship takes off and disapears into the nights sky.", "dialog");
            Typewrite("\nWell great! I wonder where hes going now.", "self");
            Typewrite("\nCoralton,", "location");
            Fastwrite(" a voice says from behind you.", "dialog");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nYou turn to see a small Atlantean girl standing in the road.", "dialog");
            Typewrite("\nCome again, little one?", "self");
            Typewrite("\nCoralton,", "location");
            Typewrite(" he said he was going to ","friend");
            Typewrite("Coralton.", "location");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nWell thank you", "self");
            Typewrite("\nNo, thank you, Mr.", "friend");
            Typewrite("\nThe little girl runs away and into the arms of he parents.","dialog");
            Typewrite("\nShe was safe. For now.","dialog");
            Typewrite("\nI've got to stop him...", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nYou climb aboard your ship and depart for ","dialog");
            Typewrite("Coralton.", "location");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);

        }

        public static void CoraltonDialog(Whale Player)
        {
            Player.currentPlanet = Coralton;
            Enemies enemy = Enemies.EnemyGenerator();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nYour ship lands on ", "dialog");
            Typewrite("Coralton.", "location");
            Typewrite("\n I wonder where ", "self");
            Fastwrite("Lundphin's,", "enemy");
            Typewrite(" run off to this time.", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nYou exit your ship and see Coraltonians fleeing the City", "dialog");
            Fastwrite("\nLundfin!", "enemy");
            Typewrite(" Theres no doubt in my mind!", "self");
            Typewrite("\nYou charge into the city of ", "dialog");
            Typewrite("Coraltundon.", "location");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nYou see ", "dialog");
            Fastwrite("Dolph Lunphin", "enemy");
            Typewrite(" and his ", "dialog");
            Fastwrite("Henchmen", "yellow");
            Typewrite(" destroying everything in sight.", "dialog");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nALRIGHT ", "self");
            Fastwrite("LUNPHIN!", "enemy");
            Typewrite("\nLundphin: It's about time you showed up, ", "enemy");
            Typewrite($"{Player.Name}!", "self");
            Fastwrite($"\n{enemy.Name}, ", "yellow");
            Fastwrite("MAKE HIM WISH HE WAS NEVER BORN!", "enemy");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Combat.Battle(Player, enemy);
        }

        public static void postCoraltonDialog(Whale Player)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nNOW YOU'RE STARTING TO ANGER ME!", "enemy");
            Typewrite("\nLundphin", "enemy");
            Typewrite(" shouts as he runs to his ship.", "dialog");
            Fastwrite("\nYOU CAN'T STOP ME ", "enemy");
            Fastwrite($"{Player.Name}!", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nHis ship takes off and disapears into the Atmosphere.", "dialog");
            Typewrite("\nI think he's starting to get scared.", "self");
            Typewrite("\nHe's just hopping from planet to closest planet.", "self");
            Typewrite("\nI bet he goes to ", "self");
            Typewrite("Blubbernot-6", "location");
            Typewrite(" next.","self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nYou turn to get back on your ship feeling confident that you've solved ", "dialog");
            Typewrite("LundPhin's ", "enemy");
            Typewrite("little ruse", "dialog");
            Typewrite("\nI've got him on the ropes now.", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nYou climb aboard your ship and depart for ", "dialog");
            Typewrite("Blubbernot-6.", "location");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            
        }

        public static void BlubbernotDialog(Whale Player)
        {
            Player.currentPlanet = Blubbernot;
            Enemies enemy = Enemies.EnemyGenerator();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nYour ship lands on ", "dialog");
            Typewrite("Blubbernot-6.", "location");
            Typewrite("\nNO MORE MESSING AROUND", "self");
            Fastwrite(" LUNDPHIN,", "enemy");
            Typewrite(" I'M FINISHING YOU THIS TIME!", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nYou exit your ship and immediately charge into the city ", "dialog");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nLundfin!", "enemy");
            Typewrite(" come out here and face me like a man!", "self");
            Typewrite("\nYou here a dolphin cackle.", "dialog");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nPeople of ", "enemy");
            Typewrite("Blubbernot-6!", "location");
            Typewrite("Your \"hero\" has arrived!", "enemy");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nYou see ", "dialog");
            Fastwrite("Dolph Lunphin", "enemy");
            Typewrite(" float down from the top of a building on his hover board.", "dialog");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nI'd love to stick around and chat but I've got one last", "enemy");
            Fastwrite(" Henchmen", "yellow");
            Typewrite(" to do that for me.", "enemy");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("It was nice knowing you, ", "enemy");
            Typewrite($"{Player.Name}!", "self");
            Fastwrite($"\n{enemy.Name}, ", "yellow");
            Fastwrite("FINISH HIM ONCE AND FOR ALL!", "enemy");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Combat.Battle(Player, enemy);
        }

        public static void postBlubbernotDialog(Whale Player)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nYou look around and ", "dialog");
            Fastwrite("Lundphin", "enemy");
            Typewrite("is nowhere in sight.", "dialog");
            Fastwrite("\nDang it! he got away again!","self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nThe people of ", "dialog");
            Typewrite("Blubbernot-6", "location");
            Fastwrite(", seeing that the coast is clear, begin chearing and chanting your name.", "dialog");
            Typewrite($"\n{Player.Name}! {Player.Name}! {Player.Name}! {Player.Name}!", "friend");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nDon't they realize? He's still out there", "self");
            Typewrite("\nYou run back to your ship","dialog");
            Fastwrite("\nGet me the hell out of here", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nYou get back inside your ship.", "dialog");
            Typewrite("\nLundPhin,", "enemy");
            Typewrite(" theres only one place you could've gone... your home, the", "self");
            Typewrite("Marinara Trench.", "location");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nYou depart for the ", "dialog");
            Typewrite("Marinara Trench.", "location");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
        }

        public static void trenchDialog(Whale Player)
        {
            Player.currentPlanet = Trench;
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nYour ship arrives at the", "dialog");
            Typewrite("Marriana Trench", "location");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nI would've thought it to be harder to land here...", "self");
            Typewrite("\nWhat sort of trick is ", "self");
            Fastwrite("Lundphin ", "enemy");
            Typewrite("trying to pull here?", "self");
            Typewrite("\nI better make sure I'm prepared.","self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);

        }

        public static void PreTrenchChoice(Whale Player)
        {

            
            Typewrite($"\n{Player.Name}", "yellow");
            Typewrite("do you want to visit the shop?","dialog");
            Console.WriteLine("\nY) Yes" +
                "\nN) No");
            string input = Console.ReadLine();
            input = input.ToUpper();
            if (input == "Y")
            {
                ConsoleInterface.Cousin(Player);
                ConsoleInterface.Shop4(Player);
            }
            else
            {
                trenchDialog1(Player);
            }
        }
        public static void trenchDialog1(Whale Player)
        {
            Enemies enemy = Enemies.EnemyGenerator();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nYou exit your ship", "dialog");
            Fastwrite("\nI've been waiting for you ", "enemy");
            Typewrite($"{Player.Name}.", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nLundphin", "enemy");
            Fastwrite("It's over! I'm here to stop you once and for all!", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nIn your dreams ", "enemy");
            Typewrite($"{Player.Name}!","self");
            Fastwrite("\nIt is I who will be stopping you!", "enemy");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);

            enemy = new Enemies("Dolf Lundfin", CharClass.fighter, 40, 5, 9, 10);

            Combat.EndBattle(Player, enemy);

        }
        public static void posttrenchDialog(Whale Player)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nYou emerge triumphant over ", "dialog");
            Fastwrite("Lundphin", "enemy");
            Typewrite("\n. The galaxy is once again at peace.", "dialog");
            Fastwrite("\nI think I will get something to drink.", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nThe the boot trodden peoples of ", "dialog");
            Typewrite($"{Player.currentPlanet}", "location");
            Fastwrite(" realize that their dictator has be vanquished", "dialog");
            Typewrite("\nHail Dorthy! The wicked witch is dead!!!!", "friend");
            Typewrite($"\nI mean, Hail {Player.Name}, we are free from Lundfin's tyranical reign! ", "friend");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.EndGameWin();

        }
        private static void Typewrite(string message, string color)
        {
            if (color == "enemy")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == "friend")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (color == "yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (color == "self")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (color == "dialog")
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == "blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (color == "location")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(30);

            }
            Console.ResetColor();

        }
        private static void Fastwrite(string message, string color)
        {
            if (color == "enemy")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == "friend")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (color == "yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (color == "self")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (color == "dialog")
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == "blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (color == "location")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(15);

            }
            Console.ResetColor();

        }
    }

}
