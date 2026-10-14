using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            bool fin = false;

            //Game lpGames = new Game();


            Rankings ranks = new Rankings();
            Players games = new Players();

            Players plas;
            Players pla = null;


            while (!fin)
            {
                Console.Clear();
                Banner();
                op = Menu();

                switch (op)
                {

                    case 1: // To load a previous game:
                        Console.Clear();
                        FileInfo file = new FileInfo("../../previousgames.txt");
                        if (file.Length > 0)
                        {
                            Console.WriteLine("Previous Games");
                            int opgame = games.SelectGameToPlay();
                            games.PlaySelectedGame(opgame);
                            Console.ReadKey();
                            //games.RemoveSelectedLineFromPreviousGames(opgame);
                        }
                        else
                        {
                            // If the list is empty, it prints a message
                            Console.WriteLine("There are no previous games");
                        }
                        Console.ReadKey();
                        break;

                    case 2: //Play a 1 player game
                        pla = new Players(); //by iniciating a new Players() here, for every new game, at the beggining of every game, new objects of boardgame and players will be created

                        Console.Clear();
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("|  CONFIGURATION PHASE  |");
                        Console.WriteLine("-------------------------");
                        pla.playervsui(); //introduces boats to the map
                        Console.Clear();

                        Game game = new Game(ref pla, 1); //play in turns
                        Rankings r1 = new Rankings();
                        Console.WriteLine("--------------");
                        Console.WriteLine("| GAME PHASE |");
                        Console.WriteLine("--------------");
                        r1 = game.playvsUI();
                        if (r1 != null)
                        {
                            ranks.AddGame(r1);
                        }


                        break;

                    case 3: //Play a 2 player game
                        pla = new Players();

                        Console.Clear();
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("|  CONFIGURATION PHASE  |");
                        Console.WriteLine("-------------------------");
                        pla.playervsplayer(); //introduces boats to the map
                        Console.Clear();

                        Game game1 = new Game(ref pla, 1); //play in turns
                        Rankings r2 = new Rankings();
                        Console.WriteLine("--------------");
                        Console.WriteLine("| GAME PHASE |");
                        Console.WriteLine("--------------");
                        r2 = game1.play();
                        if (r2 != null)
                        {
                            ranks.AddGame(r2);
                        }

                        break;

                    case 4: //Rankings:
                        Console.Clear();
                        if (ranks.rankings.Count > 0)
                        {
                            Console.WriteLine("Rankings");
                            ranks.ExtractRanking();
                            ranks.WriteRanking();
                            ranks.FileRanking();
                        }
                        else
                        {
                            // If the list is empty, it prints a message
                            Console.WriteLine("There are no rankings");
                        }
                        Console.ReadKey();


                        break;

                    case 5: //Exit
                        Console.Clear();
                        Console.WriteLine("Exiting the program");
                        Console.ReadKey();
                        fin = true;
                        break;

                    default: //Default Case
                        Console.Clear();
                        Console.WriteLine("Inserted option --> not valid ");
                        break;
                }
            }
        }

        public static int Menu()
        {
            int op = 0;
            Console.WriteLine("   ___________________________________________________________________");
            Console.WriteLine("   |                                                                 |");
            Console.WriteLine("   |     Welcome to the Battleship game, choose an option:           |");
            Console.WriteLine("   |       1.- Load a previous game                                  |");
            Console.WriteLine("   |       2.- Play a 1 player game                                  |");
            Console.WriteLine("   |       3.- Play a 2 player game                                  |");
            Console.WriteLine("   |       4.- Rankings                                              |");
            Console.WriteLine("   |       5.- Exit                                                  |");
            Console.WriteLine("   |_________________________________________________________________|\n");

            while (true)
            {
                Console.Write("Enter your choice: ");
                try
                {
                    op = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            return op;

        }

        public static void Banner()
        {
            Console.WriteLine("  _____  _____  _____  _____  _      ____  _____  _    _  ___  _____    ______   _____  _     _  ____  ");
            Console.WriteLine(" |  _  )|  _  ||_   _||_   _|| |    |   _||   __)| |  | |(_ _)|  _  |  /  ____| |  _  || |   | ||   _| ");
            Console.WriteLine(" | |_|_/| |_| |  | |    | |  | |    |  |_ |_  |_ | |__| | | | | |_| |  | |  ___ | |_| ||  |_|  ||  |_  ");
            Console.WriteLine(" |  _ _ |  _  |  | |    | |  | |    |   _|  |  | |  __  | | | |  ___|  | | |_ _||  _  ||       ||   _| ");
            Console.WriteLine(" | |_| || | | |  | |    | |  | |___ |  |_  __|  || |  | | | | | |      | |__| | | | | || ||_|| ||  |_  ");
            Console.WriteLine(" |_____||_| |_|  |_|    |_|  |_____||____|(_____||_|  |_|(___)|_|      |______| |_| |_||_|   |_||____| ");
            Console.WriteLine("\n");
        }



    }
}

