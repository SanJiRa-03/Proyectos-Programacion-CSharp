using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica2
{
    public class BoardGame
    {
        
        public Ship [,] boardgame = new Ship[12,12];
        public List<Ship> listships = new List<Ship>();
        
        public void ViewMap()
        {
            /*bool[,] islandPositions = new bool[12, 12]; //the following are the positions (-1) because the map starts at 1 and the array at 0
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
            islandPositions[0, 11] = true;*/
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
                    if (boardgame[i,j] != null)
                    {
                        Console.Write(boardgame[i,j]);
                    }
                    //else if (j == 0 && i == 5 || j == 0 && i == 6 || j == 0 && i == 7 || j == 1 && i == 5 || j == 1 && i == 6 || j == 2 && i == 3 || j == 2 && i == 4 || j == 2 && i == 5 || j == 2 && i == 6 || j == 2 && i == 7 || j == 2 && i == 8 || j == 2 && i == 9 || j == 3 && i == 5 || j == 3 && i == 6 || j == 4 && i == 5 || j == 4 && i == 6 || j == 5 && i == 4 || j == 5 && i == 5 || j == 5 && i == 6 || j == 5 && i == 7 || j == 6 && i == 5 || j == 6 && i == 6 || j == 6 && i == 7 || j == 6 && i == 8 || j == 7 && i == 5 || j == 7 && i == 6 || j == 8 && i == 5 || j == 8 && i == 6 || j == 8 && i == 7 || j == 9 && i == 0 || j == 10 && i == 0 || j == 11 && i == 0)
                    //{
                    //    Console.Write(" L ");
                    //}
                    else
                    {
                        Console.Write(" - ");
                    }
                }
                Console.WriteLine();
                count++;
            }
        }

        public void AddShip(Ship ship)
        {
            this.boardgame[ship.Posicion.CoordY-1, ship.Posicion.CoordX-1] = ship; //posicion inicial del barco
            if (ship.GetWidth() == 2) //Patrol Boat
            {
                
                if (ship.Posicion.Direccion.Equals("u"))
                {
                    this.boardgame[ship.Posicion.CoordY - 2, ship.Posicion.CoordX - 1] = ship;
                }
                else if (ship.Posicion.Direccion.Equals("d"))
                {
                    this.boardgame[ship.Posicion.CoordY, ship.Posicion.CoordX - 1] = ship;
                }
                else if (ship.Posicion.Direccion.Equals("l"))
                {
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX - 2] = ship;
                }
                else if (ship.Posicion.Direccion.Equals("r"))
                {
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX] = ship;
                }

            }
            else if (ship.GetWidth() == 3) //Submarine
            {
                if (ship.Posicion.Direccion.Equals("u"))
                {
                    this.boardgame[ship.Posicion.CoordY - 2, ship.Posicion.CoordX - 1] = ship;
                    this.boardgame[ship.Posicion.CoordY - 3, ship.Posicion.CoordX - 1] = ship;
                }
                else if (ship.Posicion.Direccion.Equals("d"))
                {
                    
                    this.boardgame[ship.Posicion.CoordY, ship.Posicion.CoordX - 1] = ship;
                    this.boardgame[ship.Posicion.CoordY + 1, ship.Posicion.CoordX - 1] = ship;
                }
                else if (ship.Posicion.Direccion.Equals("l"))
                {
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX - 2] = ship;
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX - 3] = ship;
                }
                else if (ship.Posicion.Direccion.Equals("r"))
                {
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX] = ship;
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX + 1] = ship;
                }
            }
            else if (ship.GetWidth() == 4) //Destructor
            {

                if (ship.Posicion.Direccion.Equals("u"))
                {
                    this.boardgame[ship.Posicion.CoordY - 2, ship.Posicion.CoordX - 1] = ship;
                    this.boardgame[ship.Posicion.CoordY - 3, ship.Posicion.CoordX - 1] = ship;
                    this.boardgame[ship.Posicion.CoordY - 4, ship.Posicion.CoordX - 1] = ship;
                }
                else if (ship.Posicion.Direccion.Equals("d"))
                {
                    this.boardgame[ship.Posicion.CoordY, ship.Posicion.CoordX - 1] = ship;
                    this.boardgame[ship.Posicion.CoordY + 1, ship.Posicion.CoordX - 1] = ship;
                    this.boardgame[ship.Posicion.CoordY + 2, ship.Posicion.CoordX - 1] = ship;
                }
                else if (ship.Posicion.Direccion.Equals("l"))
                {
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX - 2] = ship;
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX - 3] = ship;
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX - 4] = ship;
                }
                else if (ship.Posicion.Direccion.Equals("r"))
                {
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX] = ship;
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX + 1] = ship;
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX + 2] = ship;
                }
            }
            else if (ship.GetWidth() == 5) // Aircraft Carriers
            {

                if (ship.Posicion.Direccion.Equals("u"))
                {
                    this.boardgame[ship.Posicion.CoordY - 2, ship.Posicion.CoordX - 1] = ship;
                    this.boardgame[ship.Posicion.CoordY - 3, ship.Posicion.CoordX - 1] = ship;
                    this.boardgame[ship.Posicion.CoordY - 4, ship.Posicion.CoordX - 1] = ship;
                    this.boardgame[ship.Posicion.CoordY - 5, ship.Posicion.CoordX - 1] = ship;
                }
                else if (ship.Posicion.Direccion.Equals("d"))
                {
                    this.boardgame[ship.Posicion.CoordY, ship.Posicion.CoordX - 1] = ship;
                    this.boardgame[ship.Posicion.CoordY + 1, ship.Posicion.CoordX - 1] = ship;
                    this.boardgame[ship.Posicion.CoordY + 2, ship.Posicion.CoordX - 1] = ship;
                    this.boardgame[ship.Posicion.CoordY + 3, ship.Posicion.CoordX - 1] = ship;
                }
                else if (ship.Posicion.Direccion.Equals("l"))
                {
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX - 2] = ship;
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX - 3] = ship;
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX - 4] = ship;
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX - 5] = ship;
                }
                else if (ship.Posicion.Direccion.Equals("r"))
                {
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX] = ship;
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX + 1] = ship;
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX + 2] = ship;
                    this.boardgame[ship.Posicion.CoordY - 1, ship.Posicion.CoordX + 3] = ship;
                }
            }
            listships.Add(ship);

        }

        
        public bool CheckOverlap(int x, int y, int width, string direction) 
        {
            if (direction.Equals("l") || direction.Equals("r")) // if direction is horizontal
            {
                // check that all required positions in the array are empty
                for (int i = x; i < x + width; i++)
                {
                    if (boardgame[i, y] != null)
                    {
                        return true; // if any position is occupied, there is an overlap
                    }
                }
            }
            else // if direction is vertical
            {
                // check that all required positions in the array are empty
                for (int j = y; j < y + width; j++)
                {
                    if (boardgame[x, j] != null)
                    {
                        return true; // if any position is occupied, there is an overlap
                    }
                }
            }
            return false; // if there is no overlap, return false
        }

        public bool IsEmpty(int x, int y)
        {
            if (boardgame[y-1, x-1] == null)
            {
                return true; 
            }

            else
            {
                return false; 
            }
        }

        public bool IsLand(int x, int y)
        {
            bool land = true;
            if (boardgame[y, x] != null)
            {
                land = true;
            }
            else
            {
                land = false;
            }
            return land;
        }

        
        public List<(int, int)> FiredCoordinates { get; set; } = new List<(int, int)>();

        public string ShootAnswer(int x, int y)
        {
            if (boardgame[y, x] == null)
            {
                return " O "; //water
            }
            else if (FiredCoordinates.Contains((x, y)))
            {
                return " Already fired ";
            }
            else
            {
                FiredCoordinates.Add((x, y)); // Agregar la coordenada a la lista de disparos
                boardgame[y, x].SetHits(boardgame[y, x].GetHits() + 1);

                return " X "; //hit
            }
        }


        public bool IsLooser()
        {
            bool haslost = true;
            for (int i = 0; i < listships.Count(); i++)
            {
                if (listships[i].IsSunk() == false )
                {
                    haslost = false;
                }

            }
            return haslost;
        }

        public string GetBoardSaveString()
        {
            string boardString = "";
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    boardString += this.boardgame[i, j] + ".";
                }
            }
            // Eliminamos el último punto sobrante
            boardString = boardString.TrimEnd('.');
            return boardString;

        }
        



    }
}
