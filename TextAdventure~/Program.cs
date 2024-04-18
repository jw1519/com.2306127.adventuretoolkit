using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace adventureGame
{
    internal class Program
    {
        class Player
        {
            string playerName;
            int playerAge;
            float playerHeight;
            bool playerIsMagicUser;
        }


        static void Main(string[] args)
        {

            bool isRunning = true;
            bool hasStaff = false;
            bool goShop = false;
            bool inBattle = false;
            bool hasShield = true;

            int HP = 100;
            int Stamina = 5;
            int EnemyHP = 50;
            int HpPotions = 5;
            int ShieldHP = 5;
            int Gold = 100;
            string[] inventory = { "Sword", "Shield", "Potion" };

            string playerChoice = "";

            Console.WriteLine("welcome to the adveture game");
            Console.WriteLine("Your choices matter!");

            //character sheet
            Random random = new Random();

            Console.WriteLine("Character sheet creator");
            Console.Write("Enter character name: ");//name
            string characterName = Console.ReadLine();
            

            Console.Write("Enter character Age: "); //age
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter character height: ");//height
            float height = float.Parse(Console.ReadLine());

            Console.Write("Is your character  a magic user? (yes/no): ");//ismagic
            bool isMagicUser = Console.ReadLine().ToLower() == "yes";

            int charisma = random.Next(0, 20) + 1;
            int strength = random.Next(0, 20) + 1;

            // display the character sheet
            Console.WriteLine("\nCharacter Sheet");
            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height:0.00}");
            Console.WriteLine($"Magic user: {isMagicUser}");
            Console.WriteLine($"Charisma: {charisma}");
            Console.WriteLine($"Strength: {strength}");
            Console.WriteLine(" Inventory: ");
            Console.WriteLine($"Wooden Sword, small shield, {HpPotions} health potions");

            Restart();
            void Restart()
            {
                while (isRunning == true)
                {
                    //Story and choices
                    Console.WriteLine("you begin your adventure"); //maybe use keys
                    Console.WriteLine("you find yourself at a fork in the road. Do you go left or right?");
                    playerChoice = Console.ReadLine().ToLower();

                    if (playerChoice == "left")
                    {
                        Console.WriteLine("You see a man infront of you. Are you worthy for this Staff?");
                        Console.WriteLine("do you take the staff? (take/leave)");

                        playerChoice = Console.ReadLine().ToLower();

                        if (playerChoice == "take")
                        {
                            if (isMagicUser == true)
                            {
                                Console.WriteLine("you grab the staff and shoot a bolt at the tree. The wizard congratulates you!");
                                Console.WriteLine("Time to test your power as enemys approach");
                                hasStaff = true;
                                inBattle = true;
                            }
                            else
                            {
                                Console.WriteLine("you grab the staff but nothing happens. The wizard takes it back as you are not worthy");
                                GameOver();
                            }
                        }
                        else if (playerChoice == "leave")
                        {
                            Console.WriteLine("the wizard sighs as you walk away");
                            GameOver();
                        }
                        else
                        {
                            Console.WriteLine("the wizard stares at you and walks away");
                            GameOver();
                        }
                    }
                    else if (playerChoice == "right")
                    {
                        Console.WriteLine("You find a treasure chest at the side of the road");
                        GameOver();
                    }
                    else
                    {
                        Console.WriteLine("you wander aimlessly and get lost. Game over!");
                        GameOver();
                    }

                    while (goShop == true)
                    {
                        Console.WriteLine($"You have {Gold} Gold");
                        Console.WriteLine("Welcome to the shop what can I get for you?");
                        Console.WriteLine("potions, weapons, shields, leave");
                        playerChoice = Console.ReadLine().ToLower();
                        if(playerChoice == "potions")
                        {
                            if (Gold <25)
                            {
                                Console.WriteLine("Looks like your bit short on Gold");
                            }
                            else
                            {
                                Console.WriteLine("Thats 25 Gold. (Take/Leave)");
                                playerChoice = Console.ReadLine().ToLower();
                                if (playerChoice == "take")
                                {
                                    Console.WriteLine("Pleasure doing buissness");
                                    Gold = Gold - 25;
                                }
                            }
                        }
                        if (playerChoice == "leave")
                        {
                            goShop = false;
                        }
                    }

                    while  (inBattle == true)
                    {
                        Console.WriteLine($"Your health is {HP}");
                        Console.WriteLine($"Your Stamina is {Stamina}");
                        Console.WriteLine($"The Enemies health is {EnemyHP}");
                        Console.WriteLine("What will you do?");
                        Console.WriteLine("Attack, inventory, Defend, Run");
                        playerChoice = Console.ReadLine().ToLower();
                        if (playerChoice == "attack")
                        {
                            if (Stamina >0)
                            {
                                EnemyHP = EnemyHP - strength;
                                Console.WriteLine("Enemys Health is " + EnemyHP);
                            }
                            else
                            {
                                Console.WriteLine("Your stamina is 0. You miss the enemy. ");
                                HP = HP - 10;
                            }
                        }
                        if (playerChoice == "run")
                        {
                            Console.WriteLine("The Enemy runs after you loose stamina");
                            Stamina-- ;
                        }
                        if (playerChoice == "defend")
                        {
                            if (hasShield == true && ShieldHP >=1)
                            {
                                Console.WriteLine("You raise up your shield ready for an attack. The enemy does no damage");
                                ShieldHP--;
                                Stamina++;
                            }
                            else
                            {
                                Console.WriteLine("Your shield has broken. The enemy attacks. ");
                                HP = HP - 10;
                            }
                        }
                        if (playerChoice == "inventory")
                        {
                            foreach (string item in inventory)
                            {
                                Console.WriteLine($"You have: {item}");
                            }
                            Console.WriteLine("Do you want to use a potion?");
                            playerChoice = Console.ReadLine().ToLower();
                            if (playerChoice == "yes")
                            {
                                if (HP >=80)
                                {
                                    HP = 100;
                                }
                                else
                                {
                                    HP = HP + 20;
                                }
                            }
                        }
                        if (EnemyHP <= 0)
                        {
                            Console.WriteLine("You won");
                            inBattle = false;
                            Gold = Gold + 10;
                        }
                        if (HP <=0)
                        {
                            Console.WriteLine("GameOver");
                            isRunning = false;
                            inBattle = false;
                            Gold = Gold - 10;
                            GameOver();
                        }
                        
                    }
                }    
            }
            void GameOver()
            {
                //Restart or quit the game
                Console.WriteLine("Do you want to quit or restart (quit/restart)");
                playerChoice = Console.ReadLine().ToLower();
                if (playerChoice == "restart")
                {
                    Restart();
                }
                else
                {
                    isRunning = false;
                }
            }   
        }
    }
}