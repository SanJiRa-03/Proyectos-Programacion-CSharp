using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica2
{
    public class Game
    {
        private Players players = null;
        private int whoseturn;
        private Rankings rank;
        private Players gameToSave;


        public List<object> listgameToSave = new List<object>();

        public Game() { }
        public Game(ref Players players, int whoseturn) //ref es para pasar el mismo objeto sin que haga copia
        {
            this.players = players;
            this.whoseturn = 1; //1º player
        }

        public Rankings play()
        {
            while (players.GetPlayer1().GetWinner() == 0 && players.GetPlayer2().GetWinner() == 0 || whoseturn == 0)
            {
                if (whoseturn == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Players' 1 turn... Click any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Players' 1 BoardGame: ");
                    players.GetBoardGameP1().ViewMap();
                    Console.WriteLine();
                    Console.WriteLine("Opponents boardgame: ");
                    players.ViewMapR1();
                    Console.WriteLine();

                    string resp;
                    bool exits = false;
                    do
                    {
                        Console.WriteLine("Do you want to shoot or to exit? ('s' or 'e')");
                        resp = Console.ReadLine();
                        if (resp.Equals("s"))
                        {
                            int coordx, coordy;
                            bool alreadyShot = false; // variable para indicar si la coordenada ya ha sido disparada

                            do
                            {
                                Console.Write("Coordinate X to shoot: ");
                                coordx = int.Parse(Console.ReadLine()); //between 1 y 12
                                if (coordx < 1 || coordx > 12)
                                {
                                    Console.WriteLine("Please enter a value between 1 and 12 for Coordinate x.");
                                }
                            } while (coordx < 1 || coordx > 12);

                            do
                            {
                                Console.Write("Coordinate Y to shoot: ");
                                coordy = int.Parse(Console.ReadLine()); //between 1 y 12
                                if (coordy < 1 || coordy > 12)
                                {
                                    Console.WriteLine("Please enter a value between 1 and 12 for Coordinate x.");
                                }/*
                                else if (coordx == 1 && coordy == 6 || coordx == 1 && coordy == 7 || coordx == 1 && coordy == 8 || coordx == 2 && coordy == 6 || coordx == 2 && coordy == 7 || coordx == 3 && coordy == 4 || coordx == 3 && coordy == 5 || coordx == 3 && coordy == 6 || coordx == 3 && coordy == 7 || coordx == 3 && coordy == 8 || coordx == 3 && coordy == 9 || coordx == 3 && coordy == 10 || coordx == 4 && coordy == 6 || coordx == 4 && coordy == 7 || coordx == 5 && coordy == 6 || coordx == 5 && coordy == 7 || coordx == 6 && coordy == 5 || coordx == 6 && coordy == 6 || coordx == 6 && coordy == 7 || coordx == 6 && coordy == 8 || coordx == 7 && coordy == 6 || coordx == 7 && coordy == 7 || coordx == 7 && coordy == 8 || coordx == 7 && coordy == 9 || coordx == 8 && coordy == 6 || coordx == 8 && coordy == 7 || coordx == 9 && coordy == 6 || coordx == 9 && coordy == 7 || coordx == 9 && coordy == 8 || coordx == 10 && coordy == 1 || coordx == 11 && coordy == 1 || coordx == 12 && coordy == 1)
                                {
                                    Console.WriteLine("You can't shoot land.");
                                }*/
                                else if (players.GetBoardR1()[coordy - 1, coordx - 1] != null) // si la casilla ya ha sido disparada
                                {
                                    Console.WriteLine("You've already shot at that coordinate. Please enter a different coordinate.");
                                    alreadyShot = true;
                                }
                                else
                                {
                                    alreadyShot = false;
                                }
                            } while (coordy < 1 || coordy > 12 || alreadyShot/* || (coordy < 1 || coordy > 12 || (coordx == 1 && coordy == 6 || coordx == 1 && coordy == 7 || coordx == 1 && coordy == 8 || coordx == 2 && coordy == 6 || coordx == 2 && coordy == 7 || coordx == 3 && coordy == 4 || coordx == 3 && coordy == 5 || coordx == 3 && coordy == 6 || coordx == 3 && coordy == 7 || coordx == 3 && coordy == 8 || coordx == 3 && coordy == 9 || coordx == 3 && coordy == 10 || coordx == 4 && coordy == 6 || coordx == 4 && coordy == 7 || coordx == 5 && coordy == 6 || coordx == 5 && coordy == 7 || coordx == 6 && coordy == 5 || coordx == 6 && coordy == 6 || coordx == 6 && coordy == 7 || coordx == 6 && coordy == 8 || coordx == 7 && coordy == 6 || coordx == 7 && coordy == 7 || coordx == 7 && coordy == 8 || coordx == 7 && coordy == 9 || coordx == 8 && coordy == 6 || coordx == 8 && coordy == 7 || coordx == 9 && coordy == 6 || coordx == 9 && coordy == 7 || coordx == 9 && coordy == 8 || coordx == 10 && coordy == 1 || coordx == 11 && coordy == 1 || coordx == 12 && coordy == 1))*/);

                            coordx = coordx - 1;
                            coordy = coordy - 1;

                            string answer = players.GetBoardGameP2().ShootAnswer(coordx, coordy);

                            players.GetBoardR1()[coordy, coordx] = answer;

                            Console.Clear();
                            Console.WriteLine("Your boardgame: ");
                            players.GetBoardGameP1().ViewMap();
                            Console.WriteLine();
                            Console.WriteLine("Opponents boardgame: ");
                            players.ViewMapR1();

                            if (answer.Equals(" X "))
                            {
                                Console.WriteLine("Ship Hit!");
                            }
                            else
                            {
                                Console.WriteLine(" Water! ");
                            }   
                            Console.ReadKey();

                            whoseturn = 2;

                            if (players.GetBoardGameP2().IsLooser() == true)
                            {
                                players.Winner = 1;
                                players.GetPlayer1().SetWinner(1);
                                players.GetPlayer1().GetNumMovements();

                                Console.WriteLine("  **********************************************************");
                                Console.WriteLine("******                    YOU HAVE WON!                 ******");
                                Console.WriteLine("  **********************************************************");

                            }

                            players.GetPlayer1().SetNumMovements(players.GetPlayer1().GetNumMovements() + 1);
                            break;

                        }
                        else if (resp.Equals("e"))
                        {
                            
                            // Crear un nuevo objeto Players con los datos de la partida
                            string player1 = players.GetPlayer1().GetFileSaveString();
                            string playerui = players.GetPlayer2().GetFileSaveString();
                            string boardp1 = players.GetBoardGameP1().GetBoardSaveString();
                            string boardp2 = players.GetBoardGameP2().GetBoardSaveString();
                            string boardR1 = players.GetBoardRSaveString(players.GetBoardR1());
                            string boardR2 = players.GetBoardRSaveString(players.GetBoardR2());

                            // Agregar los elementos a la lista
                            listgameToSave.Add(player1);
                            listgameToSave.Add(playerui);
                            listgameToSave.Add(boardp1);
                            listgameToSave.Add(boardp2);
                            listgameToSave.Add(boardR1);
                            listgameToSave.Add(boardR2);
    
                            
                            // Guardar la lista en el archivo de texto
                            players.SavePreviousGamesToFile(listgameToSave);
                            
                            //ahora, para yo ver qué se ha guardado en la lista
                            //Console.WriteLine("Previous games:");
                            //Console.WriteLine(string.Join(";", listgameToSave));
                            Console.WriteLine("Previous game saved to file \n Click anywhere to continue");
                            Console.ReadKey();

                            // Salir del juego
                            whoseturn = 0;
                            return null;
                        }
                        else
                        {
                            Console.WriteLine("Choose 's' to continue shooting or 'e' to exit");
                        }
                    } while (resp != "s" || resp != "e");


                    Console.ReadKey();
                    Console.Clear();

                }
                else if (whoseturn == 2 && players.GetPlayer1().GetWinner() == 0)
                {

                    Console.Clear();
                    Console.WriteLine("Players' 2 turn... Click any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Players' 2 BoardGame: ");
                    players.GetBoardGameP2().ViewMap();
                    Console.WriteLine();
                    Console.WriteLine("Opponents boardgame: ");
                    players.ViewMapR2();
                    Console.WriteLine();

                    string resp;
                    bool exits = false;
                    do
                    {
                        Console.WriteLine("Do you want to shoot or to exit? ('s' or 'e')");
                        resp = Console.ReadLine();
                        if (resp.Equals("s"))
                        {
                            int coordx, coordy;
                            bool alreadyShot = false; // variable para indicar si la coordenada ya ha sido disparada
                            do
                            {
                                Console.Write("Coordinate X to shoot: ");
                                coordx = int.Parse(Console.ReadLine()); //between 1 y 12
                                if (coordx < 1 || coordx > 12)
                                {
                                    Console.WriteLine("Please enter a value between 1 and 12 for Coordinate x.");
                                }
                            } while (coordx < 1 || coordx > 12);
                            do
                            {
                                Console.Write("Coordinate Y to shoot: ");
                                coordy = int.Parse(Console.ReadLine()); //between 1 y 12
                                if (coordy < 1 || coordy > 12)
                                {
                                    Console.WriteLine("Please enter a value between 1 and 12 for Coordinate x.");
                                }/*
                                else if (coordx == 1 && coordy == 6 || coordx == 1 && coordy == 7 || coordx == 1 && coordy == 8 || coordx == 2 && coordy == 6 || coordx == 2 && coordy == 7 || coordx == 3 && coordy == 4 || coordx == 3 && coordy == 5 || coordx == 3 && coordy == 6 || coordx == 3 && coordy == 7 || coordx == 3 && coordy == 8 || coordx == 3 && coordy == 9 || coordx == 3 && coordy == 10 || coordx == 4 && coordy == 6 || coordx == 4 && coordy == 7 || coordx == 5 && coordy == 6 || coordx == 5 && coordy == 7 || coordx == 6 && coordy == 5 || coordx == 6 && coordy == 6 || coordx == 6 && coordy == 7 || coordx == 6 && coordy == 8 || coordx == 7 && coordy == 6 || coordx == 7 && coordy == 7 || coordx == 7 && coordy == 8 || coordx == 7 && coordy == 9 || coordx == 8 && coordy == 6 || coordx == 8 && coordy == 7 || coordx == 9 && coordy == 6 || coordx == 9 && coordy == 7 || coordx == 9 && coordy == 8 || coordx == 10 && coordy == 1 || coordx == 11 && coordy == 1 || coordx == 12 && coordy == 1)
                                {
                                    Console.WriteLine("You can't shoot land.");
                                }*/
                                else if (players.GetBoardR2()[coordy - 1, coordx - 1] != null) // si la casilla ya ha sido disparada
                                {
                                    Console.WriteLine("You've already shot at that coordinate. Please enter a different coordinate.");
                                    alreadyShot = true;
                                }
                                else
                                {
                                    alreadyShot = false;
                                }
                            } while (coordy < 1 || coordy > 12 || alreadyShot /*|| (coordy < 1 || coordy > 12 || (coordx == 1 && coordy == 6 || coordx == 1 && coordy == 7 || coordx == 1 && coordy == 8 || coordx == 2 && coordy == 6 || coordx == 2 && coordy == 7 || coordx == 3 && coordy == 4 || coordx == 3 && coordy == 5 || coordx == 3 && coordy == 6 || coordx == 3 && coordy == 7 || coordx == 3 && coordy == 8 || coordx == 3 && coordy == 9 || coordx == 3 && coordy == 10 || coordx == 4 && coordy == 6 || coordx == 4 && coordy == 7 || coordx == 5 && coordy == 6 || coordx == 5 && coordy == 7 || coordx == 6 && coordy == 5 || coordx == 6 && coordy == 6 || coordx == 6 && coordy == 7 || coordx == 6 && coordy == 8 || coordx == 7 && coordy == 6 || coordx == 7 && coordy == 7 || coordx == 7 && coordy == 8 || coordx == 7 && coordy == 9 || coordx == 8 && coordy == 6 || coordx == 8 && coordy == 7 || coordx == 9 && coordy == 6 || coordx == 9 && coordy == 7 || coordx == 9 && coordy == 8 || coordx == 10 && coordy == 1 || coordx == 11 && coordy == 1 || coordx == 12 && coordy == 1))*/);

                            coordx = coordx - 1;
                            coordy = coordy - 1;

                            string answer = players.GetBoardGameP1().ShootAnswer(coordx, coordy);

                            players.GetBoardR2()[coordy, coordx] = answer;

                            Console.Clear();
                            Console.WriteLine("Your boardgame: ");
                            players.GetBoardGameP2().ViewMap();
                            Console.WriteLine();
                            Console.WriteLine("Opponents boardgame: ");
                            players.ViewMapR2();

                            if (answer.Equals(" X "))
                            {
                                Console.WriteLine("Ship Hit!");
                            }
                            else
                            {
                                Console.WriteLine(" Water! ");
                            }
                            Console.ReadKey();

                            whoseturn = 1;

                            if (players.GetBoardGameP2().IsLooser() == true)
                            {
                                players.Winner = 1;
                                players.GetPlayer1().SetWinner(1);
                                players.GetPlayer1().GetNumMovements();

                                Console.WriteLine("  **********************************************************");
                                Console.WriteLine("******                    YOU HAVE WON!                 ******");
                                Console.WriteLine("  **********************************************************");

                            }

                            players.GetPlayer1().SetNumMovements(players.GetPlayer1().GetNumMovements() + 1);
                            break;

                        }
                        else if (resp.Equals("e"))
                        {
                            
                            // Crear un nuevo objeto Players con los datos de la partida
                            string player1 = players.GetPlayer1().GetFileSaveString();
                            string playerui = players.GetPlayer2().GetFileSaveString();
                            string boardp1 = players.GetBoardGameP1().GetBoardSaveString();
                            string boardp2 = players.GetBoardGameP2().GetBoardSaveString();
                            string boardR1 = players.GetBoardRSaveString(players.GetBoardR1());
                            string boardR2 = players.GetBoardRSaveString(players.GetBoardR2());

                            // Agregar los elementos a la lista
                            listgameToSave.Add(player1);
                            listgameToSave.Add(playerui);
                            listgameToSave.Add(boardp1);
                            listgameToSave.Add(boardp2);
                            listgameToSave.Add(boardR1);
                            listgameToSave.Add(boardR2);
    
                            
                            // Guardar la lista en el archivo de texto
                            players.SavePreviousGamesToFile(listgameToSave);
                            
                            //ahora, para yo ver qué se ha guardado en la lista
                            //Console.WriteLine("Previous games:");
                            //Console.WriteLine(string.Join(";", listgameToSave));
                            Console.WriteLine("Previous game saved to file \n Click anywhere to continue");
                            Console.ReadKey();

                            // Salir del juego
                            whoseturn = 0;
                            return null;
                        }
                        else
                        {
                            Console.WriteLine("Choose 's' to continue shooting or 'e' to exit");
                        }
                    } while (resp != "s" || resp != "e");


                    Console.ReadKey();
                    Console.Clear();
                }

                else
                {
                    break;
                }
            }

            if (players.GetPlayer1().GetWinner() == 1) // SI PLAYER 1 GANA
            {
                rank = new Rankings(players.GetPlayer1().GetName(), players.GetPlayer2().GetName(), players.GetPlayer1().GetNumMovements(), players.GetPlayer1().GetName());
            }
            else // SI PLAYER 2 GANA
            {
                rank = new Rankings(players.GetPlayer1().GetName(), players.GetPlayer2().GetName(), players.GetPlayer2().GetNumMovements(), players.GetPlayer2().GetName());
            }
            return rank;
        }

        public Rankings playvsUI()
        {
            while (players.GetPlayer1().GetWinner() == 0 && players.GetPlayer2().GetWinner() == 0 || whoseturn == 0)
            {
                if (whoseturn == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Players' 1 turn... Click any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Players' 1 BoardGame: ");
                    players.GetBoardGameP1().ViewMap();
                    Console.WriteLine();
                    Console.WriteLine("Opponents boardgame: ");
                    players.ViewMapR1();
                    Console.WriteLine();

                    string resp;
                    bool exits = false;
                    do
                    {
                        Console.WriteLine("Do you want to shoot or to exit? ('s' or 'e')");
                        resp = Console.ReadLine();
                        if (resp.Equals("s"))
                        {
                            int coordx, coordy;
                            bool alreadyShot = false; // variable para indicar si la coordenada ya ha sido disparada
                            do
                            {
                                Console.Write("Coordinate X to shoot: ");
                                coordx = int.Parse(Console.ReadLine()); //between 1 y 12
                                if (coordx < 1 || coordx > 12)
                                {
                                    Console.WriteLine("Please enter a value between 1 and 12 for Coordinate x.");
                                }
                            } while (coordx < 1 || coordx > 12);
                            do
                            {
                                Console.Write("Coordinate Y to shoot: ");
                                coordy = int.Parse(Console.ReadLine()); //between 1 y 12
                                if (coordy < 1 || coordy > 12)
                                {
                                    Console.WriteLine("Please enter a value between 1 and 12 for Coordinate x.");
                                }/*
                                else if (coordx == 1 && coordy == 6 || coordx == 1 && coordy == 7 || coordx == 1 && coordy == 8 || coordx == 2 && coordy == 6 || coordx == 2 && coordy == 7 || coordx == 3 && coordy == 4 || coordx == 3 && coordy == 5 || coordx == 3 && coordy == 6 || coordx == 3 && coordy == 7 || coordx == 3 && coordy == 8 || coordx == 3 && coordy == 9 || coordx == 3 && coordy == 10 || coordx == 4 && coordy == 6 || coordx == 4 && coordy == 7 || coordx == 5 && coordy == 6 || coordx == 5 && coordy == 7 || coordx == 6 && coordy == 5 || coordx == 6 && coordy == 6 || coordx == 6 && coordy == 7 || coordx == 6 && coordy == 8 || coordx == 7 && coordy == 6 || coordx == 7 && coordy == 7 || coordx == 7 && coordy == 8 || coordx == 7 && coordy == 9 || coordx == 8 && coordy == 6 || coordx == 8 && coordy == 7 || coordx == 9 && coordy == 6 || coordx == 9 && coordy == 7 || coordx == 9 && coordy == 8 || coordx == 10 && coordy == 1 || coordx == 11 && coordy == 1 || coordx == 12 && coordy == 1)
                                {
                                    Console.WriteLine("You can't shoot land.");
                                }*/
                                else if (players.GetBoardR1()[coordy - 1, coordx - 1] != null) // si la casilla ya ha sido disparada
                                {
                                    Console.WriteLine("You've already shot at that coordinate. Please enter a different coordinate.");
                                    alreadyShot = true;
                                }
                                else
                                {
                                    alreadyShot = false;
                                }
                            } while (coordy < 1 || coordy > 12 || alreadyShot /*|| (coordy < 1 || coordy > 12 || (coordx == 1 && coordy == 6 || coordx == 1 && coordy == 7 || coordx == 1 && coordy == 8 || coordx == 2 && coordy == 6 || coordx == 2 && coordy == 7 || coordx == 3 && coordy == 4 || coordx == 3 && coordy == 5 || coordx == 3 && coordy == 6 || coordx == 3 && coordy == 7 || coordx == 3 && coordy == 8 || coordx == 3 && coordy == 9 || coordx == 3 && coordy == 10 || coordx == 4 && coordy == 6 || coordx == 4 && coordy == 7 || coordx == 5 && coordy == 6 || coordx == 5 && coordy == 7 || coordx == 6 && coordy == 5 || coordx == 6 && coordy == 6 || coordx == 6 && coordy == 7 || coordx == 6 && coordy == 8 || coordx == 7 && coordy == 6 || coordx == 7 && coordy == 7 || coordx == 7 && coordy == 8 || coordx == 7 && coordy == 9 || coordx == 8 && coordy == 6 || coordx == 8 && coordy == 7 || coordx == 9 && coordy == 6 || coordx == 9 && coordy == 7 || coordx == 9 && coordy == 8 || coordx == 10 && coordy == 1 || coordx == 11 && coordy == 1 || coordx == 12 && coordy == 1))*/);


                            coordx = coordx - 1;
                            coordy = coordy - 1;

                            string answer = players.GetBoardGameP2().ShootAnswer(coordx, coordy);

                            players.GetBoardR1()[coordy, coordx] = answer;

                            Console.Clear();
                            Console.WriteLine("Your boardgame: ");
                            players.GetBoardGameP1().ViewMap();
                            Console.WriteLine();
                            Console.WriteLine("Opponents boardgame: ");
                            players.ViewMapR1();

                            if (answer.Equals(" X "))
                            {
                                Console.WriteLine("Ship Hit!");
                            }
                            else
                            {
                                Console.WriteLine(" Water! ");
                            }
                            Console.ReadKey();

                            whoseturn = 2;

                            if (players.GetBoardGameP2().IsLooser() == true)
                            {
                                players.Winner = 1;
                                players.GetPlayer1().SetWinner(1);
                                players.GetPlayer1().GetNumMovements();

                                Console.WriteLine("  **********************************************************");
                                Console.WriteLine("******                    YOU HAVE WON!                 ******");
                                Console.WriteLine("  **********************************************************");

                            }

                            players.GetPlayer1().SetNumMovements(players.GetPlayer1().GetNumMovements() + 1);
                            break;

                        }
                        else if (resp.Equals("e"))
                        {
                            
                            // Crear un nuevo objeto Players con los datos de la partida
                            string player1 = players.GetPlayer1().GetFileSaveString();
                            string playerui = players.GetPlayer2().GetFileSaveString();
                            string boardp1 = players.GetBoardGameP1().GetBoardSaveString();
                            string boardp2 = players.GetBoardGameP2().GetBoardSaveString();
                            string boardR1 = players.GetBoardRSaveString(players.GetBoardR1());
                            string boardR2 = players.GetBoardRSaveString(players.GetBoardR2());

                            // Agregar los elementos a la lista
                            listgameToSave.Add(player1);
                            listgameToSave.Add(playerui);
                            listgameToSave.Add(boardp1);
                            listgameToSave.Add(boardp2);
                            listgameToSave.Add(boardR1);
                            listgameToSave.Add(boardR2);
    
                            
                            // Guardar la lista en el archivo de texto
                            players.SavePreviousGamesToFile(listgameToSave);
                            
                            //ahora, para yo ver qué se ha guardado en la lista
                            //Console.WriteLine("Previous games:");
                            //Console.WriteLine(string.Join(";", listgameToSave));
                            Console.WriteLine("Previous game saved to file \n Click anywhere to continue");
                            Console.ReadKey();

                            // Salir del juego
                            whoseturn = 0;
                            return null;
                        }
                        else
                        {
                            Console.WriteLine("Choose 's' to continue shooting or 'e' to exit");
                        }
                    } while (resp != "s" || resp != "e");


                    Console.ReadKey();
                    Console.Clear();

                }
                else if (whoseturn == 2 && players.GetPlayer1().GetWinner() == 0)
                {

                    Console.Clear();
                    Console.WriteLine("Players' 2 turn... Click any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    players.ViewMapR2();
                    Console.WriteLine();

                    Random rand = new Random();
                    int coordx = rand.Next(1, 13) - 1;
                    int coordy;
                    bool alreadyShot = false; // variable para indicar si la coordenada ya ha sido disparada
                    /*
                    do
                    {*/
                        coordy = rand.Next(1, 13) - 1;
                        /*if (players.GetBoardR2()[coordy - 1, coordx - 1] != null) // si la casilla ya ha sido disparada
                        {
                            alreadyShot = true;
                        }
                        else
                        {
                            alreadyShot = false;
                        }
                    } while (coordy < 1 || coordy > 12 || alreadyShot == true);*/
                    
                    string answer = players.GetBoardGameP1().ShootAnswer(coordx, coordy);

                    players.GetBoardR2()[coordy, coordx] = answer;

                    if (answer.Equals(" X "))
                    {
                        Console.WriteLine("Ship Hit!");
                    }
                    else
                    {
                        Console.WriteLine(" Water! ");
                    }

                    Console.Clear();
                    Console.WriteLine("UI's boardgame: ");
                    players.GetBoardGameP2().ViewMap();
                    Console.WriteLine();
                    Console.WriteLine(" Players' 2 turn \nOpponents boardgame: ");
                    players.ViewMapR2();

                    whoseturn = 1;
                    if (players.GetBoardGameP1().IsLooser() == true)
                    {
                        players.Winner = 1;
                        players.GetPlayer2().SetWinner(1);
                        players.GetPlayer2().GetNumMovements();

                        Console.WriteLine("  **********************************************************");
                        Console.WriteLine("******                    YOU HAVE WON!                 ******");
                        Console.WriteLine("  **********************************************************");
                    }
                    players.GetPlayer2().SetNumMovements(players.GetPlayer2().GetNumMovements() + 1);

                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }

            if (players.GetPlayer1().GetWinner() == 1)
            {
                rank = new Rankings(players.GetPlayer1().GetName(), players.GetPlayer2().GetName(), players.GetPlayer1().GetNumMovements(), players.GetPlayer1().GetName());

            }
            else
            {
                rank = new Rankings(players.GetPlayer1().GetName(), players.GetPlayer2().GetName(), players.GetPlayer2().GetNumMovements(), players.GetPlayer2().GetName());
            }
            return rank;
        }

        

    }
}
