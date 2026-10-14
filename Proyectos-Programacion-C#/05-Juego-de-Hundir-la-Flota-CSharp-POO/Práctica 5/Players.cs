using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica2
{
    public class Players
    {
        public string Name { get; set; }
        public int NumMovements { get; set;}
        public int Winner { get; set; }

        public Players() {}
        public Players(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }
        public Players(Player player1, Player player2, BoardGame boardp1, BoardGame boardp2, string[,] boardr1, string[,] boardr2)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.boardp1 = boardp1;
            this.boardp2 = boardp2;
            this.boardr1 = boardr1;
            this.boardr2 = boardr2;
        }

        


        // creamos un nuevo boardgame para que cada jugador, en cada partida, ponga sus barcos en su boardgame
        BoardGame boardp1 = new BoardGame(); 
        BoardGame boardp2 = new BoardGame();

        string[,] boardr1 = new string[12,12];
        string[,] boardr2 = new string[12, 12];

        public string[,] GetBoardR1()
        {
            return this.boardr1;
        }
        public string[,] GetBoardR2()
        {
            return this.boardr2;
        }

        //instanciamos nuevo jugador
        Player player1;
        Player player2;

        public Players(string Name)
        {
            this.Name = Name;
            this.NumMovements = NumMovements;
            this.Winner = Winner;
        }

        public Player GetPlayer1()
        {
            return this.player1;
        }
        public Player GetPlayer2()
        {
            return this.player2;
        }
        public BoardGame GetBoardGameP1()
        {
            return this.boardp1;
        }
        public BoardGame GetBoardGameP2()
        {
            return this.boardp2;
        }
        /*public BoardGame SetBoardGameP1(BoardGame Boardp1)
        {
             this.boardp1 = Boardp1;
        }
        public BoardGame SetBoardGameP2(BoardGame Boardp2)
        {
            this.boardp2 = Boardp2;
        }*/


        public void playervsui()
        {
            do
            {
                string nameplayer1 = "";
                bool nameokay = false;
                do
                {
                    Console.Write("Player's 1 name: ");
                nameplayer1 = Console.ReadLine();
                if (nameplayer1 == "")
                {
                    nameokay = false;
                } else { nameokay = true; }
                }while(nameokay = false);
                player1 = new Player1(nameplayer1);
            } while (player1 == null);

            string nameplayerui = "Computer";
            player2 = new PlayerUI(nameplayerui);

            player1.PlaceShips(ref boardp1);
            player2.PlaceShips(ref boardp2);
        }

        public void playervsplayer()
        {
            do
            {
                string nameplayer1 = "";
                bool nameokay = false;
                do
                {
                    Console.Write("Player's 1 name: ");
                nameplayer1 = Console.ReadLine();
                if (nameplayer1 == "")
                {
                    nameokay = false;
                } else { nameokay = true; }
                }while(nameokay = false);
                player1 = new Player1(nameplayer1);
            } while (player1 == null);
            do
            {
                string nameplayer2 = "";
                bool nameokay = false;
                do
                {
                    Console.Write("Player's 2 name: ");
                nameplayer2 = Console.ReadLine();
                if (nameplayer2 == "")
                {
                    nameokay = false;
                } else { nameokay = true; }
                }while(nameokay = false);
                player2 = new Player2(nameplayer2);
            } while (player2 == null);

            Console.WriteLine("Player 1 - Place your ships: ");
            player1.PlaceShips(ref boardp1);
            Console.Clear();
            Console.WriteLine("Player 2 - Place your ships: ");
            player2.PlaceShips(ref boardp2);
        }

        public void ViewMapR1()
        {
            /*bool[,] islandPositions = new bool[12, 12];
            islandPositions[5, 0] = true;
            islandPositions[6, 0] = true;
            islandPositions[7, 0] = true;
            islandPositions[5, 1] = true;
            islandPositions[6, 1] = true;
            islandPositions[3, 2] = true;
            islandPositions[4, 2] = true;
            islandPositions[5, 2] = true;
            islandPositions[6, 2] = true;
            islandPositions[7, 2] = true;
            islandPositions[8, 2] = true;
            islandPositions[9, 2] = true;
            islandPositions[5, 3] = true;
            islandPositions[6, 3] = true;
            islandPositions[5, 4] = true;
            islandPositions[6, 4] = true;
            islandPositions[4, 5] = true;
            islandPositions[5, 5] = true;
            islandPositions[6, 5] = true;
            islandPositions[7, 5] = true;
            islandPositions[5, 6] = true;
            islandPositions[6, 6] = true;
            islandPositions[7, 6] = true;
            islandPositions[8, 6] = true;
            islandPositions[5, 7] = true;
            islandPositions[6, 7] = true;
            islandPositions[5, 8] = true;
            islandPositions[6, 8] = true;
            islandPositions[7, 8] = true;
            islandPositions[0, 9] = true;
            islandPositions[0, 10] = true;
            islandPositions[0, 11] = true;
            */
            int count = 1;
            Console.WriteLine("    1  2  3  4  5  6  7  8  9  10 11 12 ");
            for (int i = 0; i < 12; i++)
            {
                if (count <= 9)
                {
                    Console.Write("{0}  ", count);
                }
                else
                {
                    Console.Write("{0} ", count);
                }
                for (int j = 0; j < 12; j++)
                {
                    //if (islandPositions[i, j])
                    //{
                    //    Console.Write(" L ");
                    //}
                    //else 
                    if (boardr1[i, j] != null)
                    {
                        Console.Write(boardr1[i, j]);
                    }
                    else
                    {
                        Console.Write(" - ");
                    }
                }
                Console.WriteLine();
                count++;                
            }

        }

        public void ViewMapR2()
        {
            /*bool[,] islandPositions = new bool[12, 12];
            islandPositions[5, 0] = true;
            islandPositions[6, 0] = true;
            islandPositions[7, 0] = true;
            islandPositions[5, 1] = true;
            islandPositions[6, 1] = true;
            islandPositions[3, 2] = true;
            islandPositions[4, 2] = true;
            islandPositions[5, 2] = true;
            islandPositions[6, 2] = true;
            islandPositions[7, 2] = true;
            islandPositions[8, 2] = true;
            islandPositions[9, 2] = true;
            islandPositions[5, 3] = true;
            islandPositions[6, 3] = true;
            islandPositions[5, 4] = true;
            islandPositions[6, 4] = true;
            islandPositions[4, 5] = true;
            islandPositions[5, 5] = true;
            islandPositions[6, 5] = true;
            islandPositions[7, 5] = true;
            islandPositions[5, 6] = true;
            islandPositions[6, 6] = true;
            islandPositions[7, 6] = true;
            islandPositions[8, 6] = true;
            islandPositions[5, 7] = true;
            islandPositions[6, 7] = true;
            islandPositions[5, 8] = true;
            islandPositions[6, 8] = true;
            islandPositions[7, 8] = true;
            islandPositions[0, 9] = true;
            islandPositions[0, 10] = true;
            islandPositions[0, 11] = true;
            */
            int count = 1;
            Console.WriteLine("    1  2  3  4  5  6  7  8  9  10 11 12 ");
            for (int i = 0; i < 12; i++)
            {
                if (count <= 9)
                {
                    Console.Write("{0}  ", count);
                }
                else
                {
                    Console.Write("{0} ", count);
                }
                for (int j = 0; j < 12; j++)
                {
                    /*if (islandPositions[i, j])
                    {
                        Console.Write(" L ");
                    }
                    else */if (boardr1[i, j] != null)
                    {
                        Console.Write(boardr1[i, j]);
                    }
                    else
                    {
                        Console.Write(" - ");
                    }
                }
                Console.WriteLine();
                count++;
            }            
        }

        public string GetBoardRSaveString(string[,] board)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    sb.Append(board[i, j]);
                    if (j < board.GetLength(1) - 1)
                    {
                        sb.Append(".");
                    }
                }
                sb.Append("|");
            }

            return sb.ToString();
        }


        // Now, to save the previous games with all of the information of each unfinished game

        public List<Players> previousgames = new List<Players>();

        public Players(List<Players> previousgames)
        {
            this.previousgames = previousgames;
        }

        //ACCESSOR AND MUTATOR OF THE LIST<PLAYERS> FOR PREVIOUS GAMES
        public List<Players> GetPreviousGames()
        {
            return previousgames;
        }

        public void SetPreviousGames(List<Players> pgames)
        {
            this.previousgames = pgames;
        }


        //FUNCTIONS

        public void AddPreviousGames(Players pg)
        {
            previousgames.Add(pg);
        }

        public void SavePreviousGamesToFile(List<object> listofgames )
        {
            var path2 = "../../previousgames.txt";
            char separator = ';';
            using (StreamWriter sw = new StreamWriter(path2, true)) //we put true so it can add the info at the end of the file (first empty line) --> following the structure StreamWriter(string path, bool append) 
            {
                // Recorrer la lista y guardar cada elemento en una línea separada
                foreach (object element in listofgames)
                {
                    sw.Write(element.ToString() + ";");
                }
                sw.WriteLine();
            }
        }


        public int SelectGameToPlay()
        {
            var path2 = "../../previousgames.txt";

            StreamReader sr2 = File.OpenText(path2);

            char separator = ';';
            char separator2 = '_';

            string line2;
            string[] values;
            string player1info;
            string player2info;
            string[] player1values;
            string player1name;
            int player1nummoves;
            string[] player2values;
            string player2name;
            int player2nummoves;
            int count1 = 1;
            Dictionary<int, string> gameLines = new Dictionary<int, string>(); // diccionario para almacenar los números de juego y las líneas correspondientes en el archivo
            while ((line2 = sr2.ReadLine()) != null)
            {
                // guardar la línea correspondiente al número de juego
                gameLines[count1] = line2;

                values = line2.Split(separator);

                player1info = values[0];
                player2info = values[1];

                player1values = player1info.Split(separator2);
                player1name = player1values[0];
                player1nummoves = int.Parse(player1values[1]);

                player2values = player2info.Split(separator2);
                player2name = player2values[0];
                player2nummoves = int.Parse(player2values[1]);

                Console.WriteLine("Game{0}:     Player 1: " + player1name + "          Player 2:" + player2name, count1);
                count1++;
            }
            sr2.Close();

            Console.WriteLine("\n Do you want to play a game? (y/n)");
            string playgame = Console.ReadLine();
            if (playgame == "y")
            {
                Console.WriteLine("\n Which game do you want to play? (ex. 1)");
                int opgame = int.Parse(Console.ReadLine());

                return opgame;
            }
            else
            {
                return 0;
            }
        }

        public void PlaySelectedGame(int opgame)
        {
            var path2 = "../../previousgames.txt";

            StreamReader sr2 = File.OpenText(path2);

            char separator = ';';
            char separator2 = '_';
            char separator3 = '.';

            string line2;
            string[] values;
            string player1info;
            string player2info;
            string[] player1values;
            string player1name;
            int player1nummoves;
            int player1winner;
            string[] player2values;
            string player2name;
            int player2nummoves;
            int player2winner;
            string boardp1, boardp2, boardr1, boardr2;
            int count1 = 1;
            while ((line2 = sr2.ReadLine()) != null)
            {
                if (count1 == opgame)
                {
                    values = line2.Split(separator);

                    player1info = values[0];
                    player2info = values[1];
                    boardp1 = values[2];
                    boardp2 = values[3];
                    boardr1 = values[4];
                    boardr2 = values[5];

                    player1values = player1info.Split(separator2);
                    player1name = player1values[0];
                    player1nummoves = int.Parse(player1values[1]);
                    player1winner = int.Parse(player1values[2]);
                    Player1 player1 = new Player1(player1name, player1nummoves, player1winner);

                    player2values = player2info.Split(separator2);
                    player2name = player2values[0];
                    player2nummoves = int.Parse(player2values[1]);
                    player2winner = int.Parse(player2values[2]);
                    PlayerUI player2 = new PlayerUI(player2name, player2nummoves, player2winner);

                    
                    BoardGame boardGameP1 = new BoardGame();
                    

                    BoardGame boardGameP2 = new BoardGame();

                    string[,] boardR1 = new string[12,12];
                    string[,] boardR2 = new string[12,12];

                    Players players = new Players(player1, player2); //, boardp1, boardp2, boardr1, boardr2
                    Console.WriteLine("\nPlaying game {0}...\n", opgame);

                    if (player2name == "Computer")
                    {
                        Console.WriteLine("It should load the game playerVSui");
                        //Game game = new Game(ref players, 1); // play in turns
                        //Rankings r1 = game.playvsUI();
                    }
                    else
                    {
                        if (player1nummoves <= player2nummoves) // player 1 turn
                        {
                            Console.WriteLine("It should load the game playerVSplayer, starting Player1");
                            //Game game1 = new Game(ref players, 1); // play in turns
                           //Rankings r2 = game1.play();
                        }
                        else // player 2 turn
                        {
                            Console.WriteLine("It should load the game playerVSplayer, starting Player2");
                            //Game game1 = new Game(ref players, 2); // play in turns
                           //Rankings r2 = game1.play();
                        }
                    }
                    break;
                }
                count1++;
            }
            sr2.Close();
        }



    }
}



