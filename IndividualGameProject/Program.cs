using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualGameProject
{
    /// <summary>
    /// 
    /// </summary>
    // Map
    class Program
    {
        // Bool variable for later in the game
        bool TreasureMapInPossession = false;
        int inventory = 0;
        int score = 0;

        public static void Play()
        {
            // Start the game
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}", name);

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\tYou play as a knight named, {0}", name);
            Console.WriteLine("\tYou are in the middle of a dark and dangerous forest");
            Console.WriteLine("\tYou have left defending a village from evil, and now");
            Console.Write("\tyou have lost your map.");
            Console.WriteLine("\tWhich way do you go?");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Left, right, up, or down: ");
            string direction = Console.ReadLine().ToLower();
            if (direction == "left" || direction == "l")
            {
                Console.WriteLine("Going left");
                Gold2();
            }
            else if (direction == "right" || direction == "r")
            {
                Console.WriteLine("Going right");
                Map1();
            }
            else if (direction == "up" || direction == "u")
            {
                Console.WriteLine("Going forward");
                Map4();
            }
            else if (direction == "down" || direction == "d")
            {
                Console.WriteLine("Going down");
                Map2();
            }
            else
            {
                Console.WriteLine("That's not a command.");
                Console.WriteLine("Please try again.");
                Map0();
            }
        }

        // Map functions 
        public static void Map0()
        {
            Console.WriteLine("");
            Console.WriteLine("***0***");
            Console.WriteLine("Inventory: 0");
            Console.WriteLine("Score: 0");
            Console.Write("Left, Right, Up, or Down: ");
            string direction = Console.ReadLine().ToLower();
            if (direction == "left" || direction == "l")
            {
                Console.WriteLine("Going left");
                Gold2();
            }
            else if (direction == "right" || direction == "r")
            {
                Console.WriteLine("Going right");
                Map1();
            }
            else if (direction == "up" || direction == "u")
            {
                Console.WriteLine("Going forward");
                Map3();
            }
            else if (direction == "down" || direction == "d")
            {
                Console.WriteLine("Going down");
                Map2();
            }
            else
            {
                Console.WriteLine("That's not a command.");
                Console.WriteLine("Please try again.");
                Map0();
            }

        }

        public static void Map1()
        {
            Console.WriteLine("");
            Console.WriteLine("***1***");
            Console.Write("Left, Up, or Down: ");
            string direction = Console.ReadLine().ToLower();
            if (direction == "left" || direction == "l")
            {
                Console.WriteLine("Going left");
                Map0();
            }
            else if (direction == "up" || direction == "u")
            {
                Console.WriteLine("Going forward");
                Enemy1();
            }
            else if (direction == "down" || direction == "d")
            {
                Console.WriteLine("Going down");
                Enemy4();
            }
            else
            {
                Console.WriteLine("That's not a command");
                Console.WriteLine("Please try again.");
                Map1();
            }
        }

        public static void Map2()
        {
            Console.WriteLine("");
            Console.WriteLine("***2***");
            Console.Write("Right or Up: ");
            string direction = Console.ReadLine().ToLower();
            if (direction == "right" || direction == "r")
            {
                Console.WriteLine("Going right");
                Enemy4();
            }
            else if (direction == "up" || direction == "u")
            {
                Console.WriteLine("Going up");
                Map0();
            }
            else
            {
                Console.WriteLine("That's not a command.");
                Console.WriteLine("Please try again.");
                Map2();
            }
        }

        public static void Map3()
        {
            Console.WriteLine("");
            Console.WriteLine("***3***");
            Console.Write("Left, Right, Up, or Down: ");
            string direction = Console.ReadLine().ToLower();
            if (direction == "left" || direction == "l")
            {
                Console.WriteLine("Going left");
                Enemy2();
            }
            else if (direction == "right" || direction == "r")
            {
                Console.WriteLine("Going right");
                Enemy1();
            }
            else if (direction == "up" || direction == "u")
            {
                Console.WriteLine("Going up");
                Enemy3();
            }
            else if (direction == "down" || direction == "d")
            {
                Console.WriteLine("Going down");
                Map0();
            }
            else
            {
                Console.WriteLine("That's not a command");
                Console.WriteLine("Please try again.");
                Map3();
            }
        }

        public static void Map4()
        {
            Console.WriteLine("");
            Console.WriteLine("***4***");
            Console.Write("Left or Down: ");
            string direction = Console.ReadLine().ToLower();
            if (direction == "left" || direction == "l")
            {
                Console.WriteLine("Going Left");
                Enemy4();
            }
            else if (direction == "down" || direction == "d")
            {
                Console.WriteLine("Going Down");
                Gold1();
            }
            else
            {
                Console.WriteLine("That's not a command");
                Console.WriteLine("Please try again.");
                Map4();
            }
        }

        public static void Map5()
        {
            Console.WriteLine("");
            Console.WriteLine("***5***");
            Console.Write("Right, Up, or Down: ");
            string direction = Console.ReadLine().ToLower();
            if (direction == "right" || direction == "r")
            {
                Console.WriteLine("Going Right");
                Enemy3();
            }
            else if (direction == "up" || direction == "u")
            {
                Console.WriteLine("Going Up");
                TreasureMap();
            }
            else if (direction == "down" || direction == "d")
            {
                Console.WriteLine("Going Down");
                Enemy2();
            }
            else
            {
                Console.WriteLine("That's not a command");
                Console.WriteLine("Please try again.");
                Map5();
            }
        }

        public static void Map6()
        {
            Console.WriteLine("");
            Console.WriteLine("***6***");
            Console.Write("Left, Up, or Down: ");
            string direction = Console.ReadLine().ToLower();
            if (direction == "left" || direction == "l")
            {
                Console.WriteLine("Going Left");
                Gold5();
            }
            else if (direction == "up" || direction == "u")
            {
                Console.WriteLine("Going Up");
                Enemy5();
            }
            else if (direction == "down" || direction == "d")
            {
                Console.WriteLine("Going Down");
                TreasureMap();
            }
            else
            {
                Console.WriteLine("That's not a command");
                Console.WriteLine("Please try again.");
                Map6();
            }
        }

        public static void Map7()
        {
            Console.WriteLine("");
            Console.WriteLine("***7***");
            Console.Write("Right, Up, or Down: ");
            string direction = Console.ReadLine().ToLower();
            if (direction == "right" || direction == "r")
            {
                Console.WriteLine("Going Right");
                Enemy5();
            }
            else if (direction == "up" || direction == "u")
            {
                Console.WriteLine("Going Up");
                Castle();
            }
            else if (direction == "down" || direction == "d")
            {
                Console.WriteLine("Going Down");
                Gold5();
            }
            else
            {
                Console.WriteLine("That's not a command");
                Console.WriteLine("Please try again.");
                Map7();
            }
        }

        // Gold functions
        // Gold1() takes you straight to the treasure map
        public static void Gold1()
        {
            Console.WriteLine("");
            Console.WriteLine("***Gold 1***");
            Console.WriteLine("You have found treasure!");
            Console.WriteLine("100 gold gained!!");
            Console.WriteLine("");
            Console.WriteLine("Do you still want to find the treasure map? ");
            string input = Console.ReadLine().ToLower();
            if (input == "yes" || input == "y")
            {
                Console.WriteLine("");
                TreasureMap();
            }
            else if (input == "no" || input == "n")
            {
                Console.WriteLine("No? NO!!!??? Goodbye...");
            }
            else
            {
                Console.WriteLine("Not a correct input.  Try again");
                Console.WriteLine("Do you still want to find the treasure map? ");
                Console.ReadLine().ToLower();
            }
        }

        public static void Gold2()
        {
            Console.WriteLine("");
            Console.WriteLine("***Gold 2***");
            Console.WriteLine("You have found treasure!");
            Console.WriteLine("100 gold gained!!");
            Console.WriteLine("");
            Console.WriteLine("Right or Up: ");
            string direction = Console.ReadLine().ToLower();
            if (direction == "right" || direction == "r")
            {
                Console.WriteLine("Going Right");
                Map0();
            }
            else if (direction == "up" || direction == "u")
            {
                Console.WriteLine("Going Up");
                Enemy2();
            }
            else
            {
                Console.WriteLine("That's not a command");
                Console.ReadLine().ToLower();
            }
        }

        public static void Gold3()
        {
            Console.WriteLine("");
            Console.WriteLine("***Gold 3***");
            Console.WriteLine("You have found treasure!");
            Console.WriteLine("100 gold gained!!");
            Console.WriteLine("");
            Console.WriteLine("Left or Down: ");
            string direction = Console.ReadLine().ToLower();
            if (direction == "left" || direction == "l")
            {
                Console.WriteLine("Going Left");
                Enemy3();
            }
            else if (direction == "down" || direction == "d")
            {
                Console.WriteLine("Going Down");
                Enemy1();
            }
            else
            {
                Console.WriteLine("That's not a command");
                Console.ReadLine().ToLower();
            }
        }

        public static void Gold4()
        {
            Console.WriteLine("");
            Console.WriteLine("***Gold 4***");
            Console.WriteLine("You have found treasure!");
            Console.WriteLine("100 gold gained!!");
            Console.WriteLine("");
            Console.WriteLine("Left or Down: ");
            string direction = Console.ReadLine().ToLower();
            if (direction == "left" || direction == "l")
            {
                Console.WriteLine("Going Left");
                TreasureMap();
            }
            else if (direction == "down" || direction == "d")
            {
                Console.WriteLine("Going Down");
                Enemy3();
            }
            else
            {
                Console.WriteLine("That's not a command");
                Console.ReadLine().ToLower();
            }
        }

        public static void Gold5()
        {
            Console.WriteLine("");
            Console.WriteLine("***Gold 5***");
            Console.WriteLine("You have found treasure!");
            Console.WriteLine("100 gold gained!!");
            Console.WriteLine("");
            Console.WriteLine("Right or Up: ");
            string direction = Console.ReadLine().ToLower();
            if (direction == "right" || direction == "r")
            {
                Console.WriteLine("Going Right");
                Map6();
            }
            else if (direction == "up" || direction == "u")
            {
                Console.WriteLine("Going Up");
                Map7();
            }
            else
            {
                Console.WriteLine("That's not a command");
                Console.ReadLine().ToLower();
            }
        }

        // Enemy functions
        public static void Enemy1()
        {
            Console.WriteLine("");
            Console.WriteLine("***Enemy 1***");
            Console.WriteLine("You have encountered a monster in the forest!");
            Console.WriteLine("20 health lost!!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Attack or retreat: ");
            string input = Console.ReadLine().ToLower();
            if (input == "attack" || input == "a")
            {
                Console.WriteLine("Damage dealt!");
                Console.WriteLine("Enemy defeated!!");

                // if the enemy is defeated, go straight to Gold3()
                Gold3();
            }
            else if (input == "retreat" || input == "r")
            {
                Console.WriteLine("Retreating...");
                Map3();
            }
            else
            {
                Console.WriteLine("That's not a command.");
                Console.ReadLine().ToLower();
            }
        }

        public static void Enemy2()
        {
            Console.WriteLine("");
            Console.WriteLine("***Enemy 2***");
            Console.WriteLine("You have encountered a monster in the forest!");
            Console.WriteLine("20 health lost!!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Attack or retreat: ");
            string input = Console.ReadLine().ToLower();
            if (input == "attack" || input == "a")
            {
                Console.WriteLine("Damage dealt!");
                Console.WriteLine("Enemy defeated!!");

                // if the enemy is defeated, go straight to Gold2()
                Gold2();
            }
            else if (input == "retreat" || input == "r")
            {
                Console.WriteLine("Retreating...");
                Map3();
            }
            else
            {
                Console.WriteLine("That's not a command.");
                Console.ReadLine().ToLower();
            }
        }

        public static void Enemy3()
        {
            Console.WriteLine("");
            Console.WriteLine("***Enemy 3***");
            Console.WriteLine("You have encountered a monster in the forest!");
            Console.WriteLine("20 health lost!!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Attack or retreat: ");
            string input = Console.ReadLine().ToLower();
            if (input == "attack" || input == "a")
            {
                Console.WriteLine("Damage dealt!");
                Console.WriteLine("Enemy defeated!!");

                // if the enemy is defeated, go straight to Gold4()
                Gold4();
            }
            else if (input == "retreat" || input == "r")
            {
                Console.WriteLine("Retreating...");
                Map3();
            }
            else
            {
                Console.WriteLine("That's not a command.");
                Console.ReadLine().ToLower();
            }
        }

        public static void Enemy4()
        {
            Console.WriteLine("");
            Console.WriteLine("***Enemy 4***");
            Console.WriteLine("You have encountered a monster in the forest!");
            Console.WriteLine("70 health lost!!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Attack or retreat: ");
            string input = Console.ReadLine().ToLower();
            if (input == "attack" || input == "a")
            {
                Console.WriteLine("Damage dealt!");
                Console.WriteLine("Enemy defeated!!");

                // if the enemy is defeated, go straight to Map4()
                Map4();
            }
            else if (input == "retreat" || input == "r")
            {
                Map2();
            }
        }

        public static void Enemy5()
        {
            Console.WriteLine("");
            Console.WriteLine("***Enemy 5***");
            Console.WriteLine("You have encountered a monster in the forest!");
            Console.WriteLine("55 health lost!!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Attack or retreat: ");
            string input = Console.ReadLine().ToLower();
            if (input == "attack" || input == "a")
            {
                Console.WriteLine("Damage dealt!");
                Console.WriteLine("Enemy defeated!!");

                // if the enemy is defeated, go straight to Map7()
                Map7();
            }
            else if (input == "retreat" || input == "r")
            {
                Map6();
            }
        }

        // Special map functions
        public static void TreasureMap()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("You have found the treasure map!!!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("The castle is up ahead!");
            DrawingaMap();
            Console.Write("Right, Up, or Down: ");
            string direction = Console.ReadLine().ToLower();
            if (direction == "right" || direction == "r")
            {
                Console.WriteLine("Going Right");
                Gold4();
            }
            else if (direction == "up" || direction == "u")
            {
                Console.WriteLine("Going Up");
                Map6();
            }
            else if (direction == "down" || direction == "d")
            {
                Console.WriteLine("Going Down");
                Map5();
            }
            else
            {
                Console.WriteLine("That's not a command.");
                Console.ReadLine().ToLower();
            }
        }

        public static void DrawingaMap()
        {
            Console.WriteLine(" _ _  ");
            Console.WriteLine("|_^_|_ _");
            Console.WriteLine("|_7_|_!!_|");
            Console.WriteLine("|_x_|_6_|_ _");
            Console.WriteLine("    |_?_|_x_|_ _");
            Console.WriteLine("    |_5_|_!_|_x_|");
            Console.WriteLine("    |_!_|_3_|_!_|");
            Console.WriteLine("    |_x_|_0_|_1_| _ _ ");
            Console.WriteLine("        |_2_|_!!_|_4_|");
            Console.WriteLine("                 |_x_|");
            Console.WriteLine("^ Castle, ! !! Enemy, x Gold, ? Treasure Map");
            Console.WriteLine("Press any key");
            Console.ReadLine();
            
        }

        //Special function for displaying the treasure map once it is in the player's possession
        /*public bool MapInInventory()
        {
            return !this.TreasureMapInPossession && this.inventory > 0;
            DrawingaMap();
            bool TreasureMapInPossession = true;
            int score = 1;
            if (TreasureMapInPossession && score == 1)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "b")
                {
                    DrawingaMap();
                }
                //else if (input == "b")
                else
                {
                    Console.WriteLine("Wrong input!  Try again!");
                }
            }
        } */

        // Final function for the video game
        public static void Castle()
        {
            Console.WriteLine("***Congratulations!!!  You have finally reached the castle!");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t\t A Game By Deangelo Williams");
            Console.WriteLine("\n"); ///A        K          N        I       G         H        T      '      S
            Console.WriteLine("\t\t _ _ _      _   _    _ _ _   _    _    _ _ _ _    _   _    _ _ _    _    _ _ _");
            Console.WriteLine("\t\t/  _  /    | | / /  /  _  | | |  | |  |  _ _ _|  | | | |  |_   _|  | |  /  _ _|");
            Console.WriteLine("\t\t| |_| |    | |/ /   | | | | | |  | |  | |  _ _   | |_| |    | |    | /  | |_ _   ");
            Console.WriteLine("\t\t|  _  |    |   |    | | | | | |  | |  | | |_  |  |  _  |    | |         |_ _  |");
            Console.WriteLine("\t\t| | | |    | |\\ \\   | | | |_| |  | |  | |_ _| |  | | | |    | |          _ _| |");
            Console.WriteLine("\t\t|_| |_|    |_| \\_\\  |_| |_ _ /   |_|  |_ _ _ _|  |_| |_|    |_|         |_ _ _/    ");
            Console.WriteLine("");
            Console.WriteLine("\t\t _ _ _    _    _         _ _ _    _ _ _ _ _    _ _ _ _ _    _ _ _     ");
            Console.WriteLine("\t\t|  _  |  | |  | |       |  _ _|  |  _   _  |  |  _   _  |  /  _  /    ");
            Console.WriteLine("\t\t| | | |  | |  | |       | |_ _   | | | | | |  | | | | | |  | |_| |   ");
            Console.WriteLine("\t\t| | | |  | |  | |       |  _ _|  | | |_| | |  | | |_| | |  |  _  |    ");
            Console.WriteLine("\t\t| |_| |  | |  | |_ _ _  | |_ _   | |     | |  | |     | |  | | | |     ");
            Console.WriteLine("\t\t|_ _ /   |_|  |_ _ _ /  |_ _ _|  |_|     |_|  |_|     |_|  |_| |_|     ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press any key to start the game");
            Console.ReadLine();
            Play();

        }
    }
}
