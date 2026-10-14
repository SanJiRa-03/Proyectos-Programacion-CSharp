using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica2
{
    public class Player1 : Player
    {
        public Player1()
        {

        }
        public Player1(string Name) : base(Name)
        {
            this.Name = Name;
        }
        public Player1(string Name, int NumMovements, int Winner):base(Name, NumMovements, Winner)
        {
            this.Name = GetName();
            this.NumMovements = GetNumMovements();
            this.Winner = GetWinner();
        }

        public override void PlaceShips(ref BoardGame board)
        {
            PatrolBoat pb1 = new PatrolBoat();
            pb1.SetWidth(2); // size = 2
            Console.WriteLine("***** Patrol Boat *****");
            Console.WriteLine("Initial position of the ship to place:");
            int coordx11, coordx12;
            bool coordCorrecta = false;
            do
            {
                do
                {
                    Console.Write("Coordinate x:  ");
                    coordx11 = int.Parse(Console.ReadLine());
                    if (coordx11 < 1 || coordx11 > 12)
                    {
                        Console.WriteLine("Please enter a value between 1 and 12 for Coordinate x.");
                    }
                } while (coordx11 < 1 || coordx11 > 12);


                do
                {
                    Console.Write("Coordinate y:  ");
                    coordx12 = int.Parse(Console.ReadLine());
                    if (coordx12 < 1 || coordx12 > 12)
                    {
                        Console.WriteLine("Please enter a value between 1 and 12 for Coordinate y.");
                    }/*
                    else if (coordx11 == 1 && coordx12 == 6 || coordx11 == 1 && coordx12 == 7 || coordx11 == 1 && coordx12 == 8 || coordx11 == 2 && coordx12 == 6 || coordx11 == 2 && coordx12 == 7 || coordx11 == 3 && coordx12 == 4 || coordx11 == 3 && coordx12 == 5 || coordx11 == 3 && coordx12 == 6 || coordx11 == 3 && coordx12 == 7 || coordx11 == 3 && coordx12 == 8 || coordx11 == 3 && coordx12 == 9 || coordx11 == 3 && coordx12 == 10 || coordx11 == 4 && coordx12 == 6 || coordx11 == 4 && coordx12 == 7 || coordx11 == 5 && coordx12 == 6 || coordx11 == 5 && coordx12 == 7 || coordx11 == 6 && coordx12 == 5 || coordx11 == 6 && coordx12 == 6 || coordx11 == 6 && coordx12 == 7 || coordx11 == 6 && coordx12 == 8 || coordx11 == 7 && coordx12 == 6 || coordx11 == 7 && coordx12 == 7 || coordx11 == 7 && coordx12 == 8 || coordx11 == 7 && coordx12 == 9 || coordx11 == 8 && coordx12 == 6 || coordx11 == 8 && coordx12 == 7 || coordx11 == 9 && coordx12 == 6 || coordx11 == 9 && coordx12 == 7 || coordx11 == 8 && coordx12 == 8 || coordx11 == 10 && coordx12 == 1 || coordx11 == 11 && coordx12 == 1 || coordx11 == 12 && coordx12 == 1)
                    {
                        Console.WriteLine("You can't place a ship on land.");
                    }*/
                } while (coordx12 < 1 || coordx12 > 12/* || (coordx11 == 1 && coordx12 == 6 || coordx11 == 1 && coordx12 == 7 || coordx11 == 1 && coordx12 == 8 || coordx11 == 2 && coordx12 == 6 || coordx11 == 2 && coordx12 == 7 || coordx11 == 3 && coordx12 == 4 || coordx11 == 3 && coordx12 == 5 || coordx11 == 3 && coordx12 == 6 || coordx11 == 3 && coordx12 == 7 || coordx11 == 3 && coordx12 == 8 || coordx11 == 3 && coordx12 == 9 || coordx11 == 3 && coordx12 == 10 || coordx11 == 4 && coordx12 == 6 || coordx11 == 4 && coordx12 == 7 || coordx11 == 5 && coordx12 == 6 || coordx11 == 5 && coordx12 == 7 || coordx11 == 6 && coordx12 == 5 || coordx11 == 6 && coordx12 == 6 || coordx11 == 6 && coordx12 == 7 || coordx11 == 6 && coordx12 == 8 || coordx11 == 7 && coordx12 == 6 || coordx11 == 7 && coordx12 == 7 || coordx11 == 7 && coordx12 == 8 || coordx11 == 7 && coordx12 == 9 || coordx11 == 8 && coordx12 == 6 || coordx11 == 8 && coordx12 == 7 || coordx11 == 9 && coordx12 == 6 || coordx11 == 9 && coordx12 == 7 || coordx11 == 8 && coordx12 == 8 || coordx11 == 10 && coordx12 == 1 || coordx11 == 11 && coordx12 == 1 || coordx11 == 12 && coordx12 == 1)*/);


                if (board.IsEmpty(coordx11, coordx12) == true) //if its empty 
                {
                    coordCorrecta = true;
                }/*
                else if (board.IsLand(coordx11, coordx12) == true)
                {
                    Console.WriteLine("Position with land, please choose another position");
                    coordCorrecta = false;
                }*/
                else
                {
                    Console.WriteLine("Position occupied, please choose another position");
                    coordCorrecta = false;
                }
            } while (coordCorrecta == false);

            bool direcCorrecta1 = false;
            string direc1 = "";
            do
            {
                Console.Write("Direction of the ship (u, d, l, r): ");
                direc1 = Console.ReadLine();
                if (direc1 == "u")
                {
                    //int[] coordx1a = { coordx11, coordx12 + (1 * -1) }; //coordenada final
                    if (coordx12 - pb1.GetWidth() < 0 )
                    {
                        Console.WriteLine("Not a valid direction. ");
                        direcCorrecta1 = false;
                    }
                    else
                    {
                        // check that all required positions in the array are empty
                        for (int i = coordx12; i < coordx12 - (pb1.GetWidth()-1); i++)
                        {
                            if (direcCorrecta1 == false)
                            {
                                if (board.IsEmpty(coordx11, i) == false)
                                {
                                    Console.WriteLine("Position occupied, please choose another direction");
                                    direcCorrecta1 = false; // if any position is occupied, there is an overlap
                                }/*
                                else if (board.IsLand(coordx11, i) == true)
                                {
                                    Console.WriteLine("Position with land, please choose another direction");
                                    direcCorrecta1 = false;
                                }*/
                                else
                                {
                                    Console.WriteLine("Ship placed correctly");
                                    direcCorrecta1 = true;
                                }
                            }
                        }
                    }

                }
                else if (direc1 == "d")
                {
                    //int[] coordx1a = { coordx11, coordx12 + 1 }; //coordenada final
                    if (coordx12 + pb1.GetWidth() > 12)
                    {
                        Console.WriteLine("Not a valid direction. ");
                        direcCorrecta1 = false;
                    }
                    else
                    {
                        // check that all required positions in the array are empty
                        for (int i = coordx12; i < coordx12 + (pb1.GetWidth()-1); i++)
                        {
                            if (direcCorrecta1 == false)
                            {
                                if (board.IsEmpty(coordx11, i) == false)
                                {
                                    Console.WriteLine("Position occupied, please choose another direction");
                                    direcCorrecta1 = false; // if any position is occupied, there is an overlap
                                }/*
                                else if (board.IsLand(coordx11, i) == true)
                                {
                                    Console.WriteLine("Position with land, please choose another direction");
                                    direcCorrecta1 = false;
                                }*/
                                else
                                {
                                    Console.WriteLine("Ship placed correctly");
                                    direcCorrecta1 = true;
                                }
                            }
                        }
                    }
                }
                else if (direc1 == "l")
                {
                    //int[] coordx1a = { coordx11 + (1 * -1) , coordx12}; //coordenada final
                    if (coordx11 - pb1.GetWidth() < 0)
                    {
                        Console.WriteLine("Not a valid direction. ");
                        direcCorrecta1 = false;
                    }
                    else
                    {
                        // check that all required positions in the array are empty
                        for (int i = coordx11; i < coordx11 - (pb1.GetWidth()-1); i++)
                        {
                            if (direcCorrecta1 == false)
                            {
                                if (board.IsEmpty(i, coordx12) == false)
                                {
                                    Console.WriteLine("Position occupied, please choose another direction");
                                    direcCorrecta1 = false; // if any position is occupied, there is an overlap
                                }/*
                                else if (board.IsLand(i, coordx12) == true)
                                {
                                    Console.WriteLine("Position with land, please choose another direction");
                                    direcCorrecta1 = false;
                                }*/
                                else
                                {
                                    Console.WriteLine("Ship placed correctly");
                                    direcCorrecta1 = true;
                                }
                            }
                        }
                        
                    }
                }
                else if (direc1 == "r")
                {
                    //int[] coordx1a = { coordx11 + 1 , coordx12}; //coordenada final
                    if (coordx11 + pb1.GetWidth() > 12)
                    {
                        Console.WriteLine("Not a valid direction. ");
                        direcCorrecta1 = false;
                    }
                    else
                    {
                        // check that all required positions in the array are empty
                        for (int i = coordx11; i < coordx11 + (pb1.GetWidth()-1); i++)
                        {
                            if (direcCorrecta1 == false)
                            {
                                if (board.IsEmpty(i, coordx12) == false)
                                {
                                    Console.WriteLine("Position occupied, please choose another direction");
                                    direcCorrecta1 = false; // if any position is occupied, there is an overlap
                                }/*
                                else if (board.IsLand(i, coordx12) == true)
                                {
                                    Console.WriteLine("Position with land, please choose another direction");
                                    direcCorrecta1 = false;
                                }*/
                                else
                                {
                                    Console.WriteLine("Ship placed correctly");
                                    direcCorrecta1 = true;
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Not a correct direction. Please introduce 'u' for up, 'd' for down, 'l' for left and 'r' for right. ");
                    direcCorrecta1 = false;
                }
            } while (direcCorrecta1 == false);
            pb1.Posicion = new Coordenadas();
            pb1.Posicion.CoordX = coordx11;
            pb1.Posicion.CoordY = coordx12;
            pb1.Posicion.Direccion = direc1;
            board.AddShip(pb1);
            Console.WriteLine("**************************************************************\n");
            


            Submarine s1 = new Submarine();
            s1.SetWidth(3); // size = 3
            Console.WriteLine("***** Submarine *****");
            Console.WriteLine("Initial position of the ship to place: ");
            int coordx21, coordx22;
            bool coordCorrecta1 = false;
            do
            {
                do
                {
                    Console.Write("Coordinate x:  ");
                    coordx21 = int.Parse(Console.ReadLine());
                    if (coordx21 < 1 || coordx21 > 12)
                    {
                        Console.WriteLine("Please enter a value between 1 and 12 for Coordinate x.");
                    }
                } while (coordx21 < 1 || coordx21 > 12);


                do
                {
                    Console.Write("Coordinate y:  ");
                    coordx22 = int.Parse(Console.ReadLine());
                    if (coordx22 < 1 || coordx22 > 12)
                    {
                        Console.WriteLine("Please enter a value between 1 and 12 for Coordinate y.");
                    }/*
                    else if (coordx21 == 1 && coordx22 == 6 || coordx21 == 1 && coordx22 == 7 || coordx21 == 1 && coordx22 == 8 || coordx21 == 2 && coordx22 == 6 || coordx21 == 2 && coordx22 == 7 || coordx21 == 3 && coordx22 == 4 || coordx21 == 3 && coordx22 == 5 || coordx21 == 3 && coordx22 == 6 || coordx21 == 3 && coordx22 == 7 || coordx21 == 3 && coordx22 == 8 || coordx21 == 3 && coordx22 == 9 || coordx21 == 3 && coordx22 == 10 || coordx21 == 4 && coordx22 == 6 || coordx21 == 4 && coordx22 == 7 || coordx21 == 5 && coordx22 == 6 || coordx21 == 5 && coordx22 == 7 || coordx21 == 6 && coordx22 == 5 || coordx21 == 6 && coordx22 == 6 || coordx21 == 6 && coordx22 == 7 || coordx21 == 6 && coordx22 == 8 || coordx21 == 7 && coordx22 == 6 || coordx21 == 7 && coordx22 == 7 || coordx21 == 7 && coordx22 == 8 || coordx21 == 7 && coordx22 == 9 || coordx21 == 8 && coordx22 == 6 || coordx21 == 8 && coordx22 == 7 || coordx21 == 9 && coordx22 == 6 || coordx21 == 9 && coordx22 == 7 || coordx21 == 8 && coordx22 == 8 || coordx21 == 10 && coordx22 == 1 || coordx21 == 11 && coordx22 == 1 || coordx21 == 12 && coordx22 == 1)
                    {
                        Console.WriteLine("You can't place a ship on land.");
                    }*/
                } while (coordx22 < 1 || coordx22 > 12 /*|| (coordx21 == 1 && coordx22 == 6 || coordx21 == 1 && coordx22 == 7 || coordx21 == 1 && coordx22 == 8 || coordx21 == 2 && coordx22 == 6 || coordx21 == 2 && coordx22 == 7 || coordx21 == 3 && coordx22 == 4 || coordx21 == 3 && coordx22 == 5 || coordx21 == 3 && coordx22 == 6 || coordx21 == 3 && coordx22 == 7 || coordx21 == 3 && coordx22 == 8 || coordx21 == 3 && coordx22 == 9 || coordx21 == 3 && coordx22 == 10 || coordx21 == 4 && coordx22 == 6 || coordx21 == 4 && coordx22 == 7 || coordx21 == 5 && coordx22 == 6 || coordx21 == 5 && coordx22 == 7 || coordx21 == 6 && coordx22 == 5 || coordx21 == 6 && coordx22 == 6 || coordx21 == 6 && coordx22 == 7 || coordx21 == 6 && coordx22 == 8 || coordx21 == 7 && coordx22 == 6 || coordx21 == 7 && coordx22 == 7 || coordx21 == 7 && coordx22 == 8 || coordx21 == 7 && coordx22 == 9 || coordx21 == 8 && coordx22 == 6 || coordx21 == 8 && coordx22 == 7 || coordx21 == 9 && coordx22 == 6 || coordx21 == 9 && coordx22 == 7 || coordx21 == 8 && coordx22 == 8 || coordx21 == 10 && coordx22 == 1 || coordx21 == 11 && coordx22 == 1 || coordx21 == 12 && coordx22 == 1)*/);

                if (board.IsEmpty(coordx21, coordx22) == true)
                {
                    coordCorrecta1 = true;
                }/*
                else if (board.IsLand(coordx21, coordx22) == true)
                {
                    Console.WriteLine("Position with land, please choose another direction");
                    coordCorrecta1 = false;
                }*/
                else
                {
                    coordCorrecta1 = false;
                    Console.WriteLine("Position occupied, please choose another position");
                }
            } while (coordCorrecta1 == false);
            int[] coordx2 = { coordx21, coordx22 };
            bool direcCorrecta2 = false;
            string direc2 = "";
            do
            {
                Console.Write("Direction of the ship (u, d, l, r): ");
                direc2 = Console.ReadLine();
                if (direc2 == "u")
                {
                    //int[] coordx2a = { coordx21, coordx22 + (2 * -1) }; //coordenada final
                    if (coordx22 - s1.GetWidth() < 0) //if out of the limits of the matrix
                    {
                        Console.WriteLine("Not a valid direction. ");
                        direcCorrecta2 = false;
                    }
                    else
                    {
                        // check that all required positions in the array are empty
                        for (int i = coordx22; i > coordx22 - (s1.GetWidth()-1); i--)
                        {
                            if (direcCorrecta2 == false)
                            {
                                if (board.IsEmpty(coordx21, i) == false)
                                {
                                    Console.WriteLine("Position occupied, please choose another direction");
                                    direcCorrecta2 = false; // if any position is occupied, there is an overlap
                                }/*
                                else if (board.IsLand(coordx21, i) == true)
                                {
                                    Console.WriteLine("Position with land, please choose another direction");
                                    direcCorrecta1 = false;
                                }*/
                                else
                                {
                                    Console.WriteLine("Ship placed correctly");
                                    direcCorrecta2 = true;
                                }
                            }
                        }
                    }
                }
                else if (direc2 == "d")
                {
                    //int[] coordx2a = { coordx21, coordx22 + 2 }; //coordenada final
                    if (coordx22 + s1.GetWidth() > 12)
                    {
                        Console.WriteLine("Not a valid direction. ");
                        direcCorrecta2 = false;
                    }
                    else
                    {
                        // check that all required positions in the array are empty
                        for (int i = coordx22; i < coordx22 + (s1.GetWidth()-1); i++)
                        {
                            if (direcCorrecta2 == false)
                            {
                                if (board.IsEmpty(coordx21, i) == false)
                                {
                                    Console.WriteLine("Position occupied, please choose another direction");
                                    direcCorrecta2 = false; // if any position is occupied, there is an overlap
                                }/*
                                else if (board.IsLand(coordx21, i) == true)
                                {
                                    Console.WriteLine("Position with land, please choose another direction");
                                    direcCorrecta1 = false;
                                }*/
                                else
                                {
                                    Console.WriteLine("Ship placed correctly");
                                    direcCorrecta2 = true;
                                }
                            }
                        }
                    }
                }
                else if (direc2 == "l")
                {
                    //int[] coordx2a = { coordx21 + (2 * -1), coordx22 }; //coordenada final
                    if (coordx21 - s1.GetWidth() < 0)
                    {
                        Console.WriteLine("Not a valid direction. ");
                        direcCorrecta2 = false;
                    }
                    else
                    {
                        // check that all required positions in the array are empty
                        for (int i = coordx21; i > (coordx21 - (s1.GetWidth()-1)); i--)
                        {
                            if (direcCorrecta2 == false)
                            {
                                if (board.IsEmpty(i, coordx22) == false)
                                {
                                    Console.WriteLine("Position occupied, please choose another direction");
                                    direcCorrecta2 = false; // if any position is occupied, there is an overlap
                                }/*
                                else if (board.IsLand(i, coordx22) == true)
                                {
                                    Console.WriteLine("Position with land, please choose another direction");
                                    direcCorrecta1 = false;
                                }*/
                                else
                                {
                                    Console.WriteLine("Ship placed correctly");
                                    direcCorrecta2 = true;
                                }
                            }
                        }
                    }
                }
                else if (direc2 == "r")
                {
                    //int[] coordx2a = { coordx21 + 2, coordx22 }; //coordenada final
                    if (coordx21 + s1.GetWidth() > 12)
                    {
                        Console.WriteLine("Not a valid direction. ");
                        direcCorrecta2 = false;
                    }
                    else
                    {
                            // check that all required positions in the array are empty
                        for (int i = coordx21; i < coordx21 + (s1.GetWidth() - 1); i++)
                        {
                            if(direcCorrecta2 == false)
                            {
                                if (board.IsEmpty(i, coordx22) == false)
                                {
                                    Console.WriteLine("Position occupied, please choose another direction");
                                    direcCorrecta2 = false; // if any position is occupied, there is an overlap
                                }/*
                                else if (board.IsLand(i, coordx22) == true)
                                {
                                    Console.WriteLine("Position with land, please choose another direction");
                                    direcCorrecta1 = false;
                                }*/
                                else
                                {
                                    Console.WriteLine("Ship placed correctly");
                                    direcCorrecta2 = true;
                                }
                            }
                                
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Not a correct direction. Please introduce 'u' for up, 'd' for down, 'l' for left and 'r' for right. ");
                    direcCorrecta2 = false;
                }
            } while (direcCorrecta2 == false);
            s1.Posicion = new Coordenadas();
            s1.Posicion.CoordX = coordx21;
            s1.Posicion.CoordY = coordx22;
            s1.Posicion.Direccion = direc2;
            board.AddShip(s1);
            Console.WriteLine("**************************************************************\n");

            

            Destructor d1 = new Destructor();
            d1.SetWidth(4); // size = 4
            Console.WriteLine("***** Destructor *****");
            Console.WriteLine("Initial position of the ship to place: ");
            int coordx31, coordx32;
            bool coordCorrecta2 = false;
            do
            {
                do
                {
                    Console.Write("Coordinate x:  ");
                    coordx31 = int.Parse(Console.ReadLine());
                    if (coordx31 < 1 || coordx31 > 12)
                    {
                        Console.WriteLine("Please enter a value between 1 and 12 for Coordinate x.");
                    }
                } while (coordx31 < 1 || coordx31 > 12);


                do
                {
                    Console.Write("Coordinate y:  ");
                    coordx32 = int.Parse(Console.ReadLine());
                    if (coordx32 < 1 || coordx32 > 12)
                    {
                        Console.WriteLine("Please enter a value between 1 and 12 for Coordinate y.");
                    }/*
                    else if (coordx31 == 1 && coordx32 == 6 || coordx31 == 1 && coordx32 == 7 || coordx31 == 1 && coordx32 == 8 || coordx31 == 2 && coordx32 == 6 || coordx31 == 2 && coordx32 == 7 || coordx31 == 3 && coordx32 == 4 || coordx31 == 3 && coordx32 == 5 || coordx31 == 3 && coordx32 == 6 || coordx31 == 3 && coordx32 == 7 || coordx31 == 3 && coordx32 == 8 || coordx31 == 3 && coordx32 == 9 || coordx31 == 3 && coordx32 == 10 || coordx31 == 4 && coordx32 == 6 || coordx31 == 4 && coordx32 == 7 || coordx31 == 5 && coordx32 == 6 || coordx31 == 5 && coordx32 == 7 || coordx31 == 6 && coordx32 == 5 || coordx31 == 6 && coordx32 == 6 || coordx31 == 6 && coordx32 == 7 || coordx31 == 6 && coordx32 == 8 || coordx31 == 7 && coordx32 == 6 || coordx31 == 7 && coordx32 == 7 || coordx31 == 7 && coordx32 == 8 || coordx31 == 7 && coordx32 == 9 || coordx31 == 8 && coordx32 == 6 || coordx31 == 8 && coordx32 == 7 || coordx31 == 9 && coordx32 == 6 || coordx31 == 9 && coordx32 == 7 || coordx31 == 8 && coordx32 == 8 || coordx31 == 10 && coordx32 == 1 || coordx31 == 11 && coordx32 == 1 || coordx31 == 12 && coordx32 == 1)
                    {
                        Console.WriteLine("You can't place a ship on land.");
                    }*/
                } while (coordx32 < 1 || coordx32 > 12);

                if (board.IsEmpty(coordx31, coordx32) == true)
                {
                    coordCorrecta2 = true;
                }/*
                else if (board.IsLand(coordx31, coordx32) == true)
                {
                    coordCorrecta2 = false;
                    Console.WriteLine("Position with land, please choose another position");
                }*/
                else
                {
                    coordCorrecta2 = false;
                    Console.WriteLine("Position occupied, please choose another position");
                }
            } while (coordCorrecta2 == false);
            int[] coordx3 = { coordx31, coordx32 };
            bool direcCorrecta3 = false;
            string direc3 = "";
            do
            {
                Console.Write("Direction of the ship (u, d, l, r): ");
                direc3 = Console.ReadLine();
                if (direc3 == "u")
                {
                    //int[] coordx3a = { coordx31, coordx32 + (3 * -1) }; //coordenada final
                    if (coordx32 - d1.GetWidth() < 0)
                    {
                        Console.WriteLine("Not a valid direction. ");
                        direcCorrecta3 = false;
                    }
                    else
                    {
                        // check that all required positions in the array are empty
                        for (int i = coordx32; i > coordx32 - (d1.GetWidth()-1); i--)
                        {
                            if (direcCorrecta3 == false)
                            {
                                if (board.IsEmpty(coordx31, i) == false)
                                {
                                    Console.WriteLine("Position occupied, please choose another direction");
                                    direcCorrecta3 = false; // if any position is occupied, there is an overlap
                                }/*
                                else if (board.IsLand(coordx31, i) == true)
                                {
                                    Console.WriteLine("Position with land, please choose another direction");
                                    direcCorrecta3 = false;
                                }*/
                                else
                                {
                                    Console.WriteLine("Ship placed correctly");
                                    direcCorrecta3 = true;
                                }
                            }
                        }
                    }
                }
                else if (direc3 == "d")
                {
                    //int[] coordx3a = { coordx31, coordx32 + 3 }; //coordenada final
                    if (coordx32 + d1.GetWidth() > 12)
                    {
                        Console.WriteLine("Not a valid direction. ");
                        direcCorrecta3 = false;
                    }
                    else
                    {
                        // check that all required positions in the array are empty
                        for (int i = coordx32; i < coordx32 + (d1.GetWidth()-1); i++)
                        {
                            if (direcCorrecta3 == false)
                            {
                                if (board.IsEmpty(coordx31, i) == false)
                                {
                                    Console.WriteLine("Position occupied, please choose another direction");
                                    direcCorrecta3 = false; // if any position is occupied, there is an overlap
                                }/*
                                else if (board.IsLand(coordx31, i) == true)
                                {
                                    Console.WriteLine("Position with land, please choose another direction");
                                    direcCorrecta3 = false;
                                }*/
                                else
                                {
                                    Console.WriteLine("Ship placed correctly");
                                    direcCorrecta3 = true;
                                }
                            }
                        }
                    }
                }
                else if (direc3 == "l")
                {
                    //int[] coordx3a = { coordx31 + (3 * -1), coordx32 }; //coordenada final
                    if (coordx31 - d1.GetWidth() < 0)
                    {
                        Console.WriteLine("Not a valid direction. ");
                        direcCorrecta3 = false;
                    }
                    else
                    {
                        // check that all required positions in the array are empty
                        for (int i = coordx31; i > coordx31 - (d1.GetWidth()-1); i--)
                        {
                            if (direcCorrecta3 == false)
                            {
                                if (board.IsEmpty(i, coordx32) == false)
                                {
                                    Console.WriteLine("Position occupied, please choose another direction");
                                    direcCorrecta3 = false; // if any position is occupied, there is an overlap
                                }/*
                                else if (board.IsLand(i, coordx32) == true)
                                {
                                    Console.WriteLine("Position with land, please choose another direction");
                                    direcCorrecta3 = false;
                                }*/
                                else
                                {
                                    Console.WriteLine("Ship placed correctly");
                                    direcCorrecta3 = true;
                                }
                            }
                        }
                    }
                }
                else if (direc3 == "r")
                {
                    //int[] coordx3a = { coordx31 + 3, coordx32 }; //coordenada final
                    if (coordx31 + d1.GetWidth() > 12)
                    {
                        Console.WriteLine("Not a valid direction. ");
                        direcCorrecta3 = false;
                    }
                    else
                    {
                        // check that all required positions in the array are empty
                        for (int i = coordx31; i < coordx31 + (d1.GetWidth()-1); i++)
                        {
                            if (direcCorrecta3 == false)
                            {
                                if (board.IsEmpty(i, coordx32) == false)
                                {
                                    Console.WriteLine("Position occupied, please choose another direction");
                                    direcCorrecta3 = false; // if any position is occupied, there is an overlap
                                }/*
                                else if (board.IsLand(i, coordx32) == true)
                                {
                                    Console.WriteLine("Position with land, please choose another direction");
                                    direcCorrecta3 = false;
                                }*/
                                else
                                {
                                    Console.WriteLine("Ship placed correctly");
                                    direcCorrecta3 = true;
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Not a correct direction. Please introduce 'u' for up, 'd' for down, 'l' for left and 'r' for right. ");
                    direcCorrecta3 = false;
                }
            } while (direcCorrecta3 == false);

            d1.Posicion = new Coordenadas();
            d1.Posicion.CoordX = coordx31;
            d1.Posicion.CoordY = coordx32;
            d1.Posicion.Direccion = direc3;
            board.AddShip(d1);
            Console.WriteLine("**************************************************************\n");


            AircraftCarriers ac1 = new AircraftCarriers();
            ac1.SetWidth(5); // size = 5
            Console.WriteLine("***** Aircraft Carriers *****");
            Console.WriteLine("Initial position of the ship to place: ");
            int coordx41, coordx42;
            bool coordCorrecta3 = false;
            do
            {
                do
                {
                    Console.Write("Coordinate x:  ");
                    coordx41 = int.Parse(Console.ReadLine());
                    if (coordx41 < 1 || coordx41 > 12)
                    {
                        Console.WriteLine("Please enter a value between 1 and 12 for Coordinate x.");
                    }
                } while (coordx41 < 1 || coordx41 > 12);


                do
                {
                    Console.Write("Coordinate y:  ");
                    coordx42 = int.Parse(Console.ReadLine());
                    if (coordx42 < 1 || coordx42 > 12)
                    {
                        Console.WriteLine("Please enter a value between 1 and 12 for Coordinate y.");
                    }/*
                    else if (coordx41 == 1 && coordx42 == 6 || coordx41 == 1 && coordx42 == 7 || coordx41 == 1 && coordx42 == 8 || coordx41 == 2 && coordx42 == 6 || coordx41 == 2 && coordx42 == 7 || coordx41 == 3 && coordx42 == 4 || coordx41 == 3 && coordx42 == 5 || coordx41 == 3 && coordx42 == 6 || coordx41 == 3 && coordx42 == 7 || coordx41 == 3 && coordx42 == 8 || coordx41 == 3 && coordx42 == 9 || coordx41 == 3 && coordx42 == 10 || coordx41 == 4 && coordx42 == 6 || coordx41 == 4 && coordx42 == 7 || coordx41 == 5 && coordx42 == 6 || coordx41 == 5 && coordx42 == 7 || coordx41 == 6 && coordx42 == 5 || coordx41 == 6 && coordx42 == 6 || coordx41 == 6 && coordx42 == 7 || coordx41 == 6 && coordx42 == 8 || coordx41 == 7 && coordx42 == 6 || coordx41 == 7 && coordx42 == 7 || coordx41 == 7 && coordx42 == 8 || coordx41 == 7 && coordx42 == 9 || coordx41 == 8 && coordx42 == 6 || coordx41 == 8 && coordx42 == 7 || coordx41 == 9 && coordx42 == 6 || coordx41 == 9 && coordx42 == 7 || coordx41 == 8 && coordx42 == 8 || coordx41 == 10 && coordx42 == 1 || coordx41 == 11 && coordx42 == 1 || coordx41 == 12 && coordx42 == 1)
                    {
                        Console.WriteLine("You can't place a ship on land.");
                    }*/
                } while (coordx42 < 1 || coordx42 > 12/* || (coordx41 == 1 && coordx42 == 6 || coordx41 == 1 && coordx42 == 7 || coordx41 == 1 && coordx42 == 8 || coordx41 == 2 && coordx42 == 6 || coordx41 == 2 && coordx42 == 7 || coordx41 == 3 && coordx42 == 4 || coordx41 == 3 && coordx42 == 5 || coordx41 == 3 && coordx42 == 6 || coordx41 == 3 && coordx42 == 7 || coordx41 == 3 && coordx42 == 8 || coordx41 == 3 && coordx42 == 9 || coordx41 == 3 && coordx42 == 10 || coordx41 == 4 && coordx42 == 6 || coordx41 == 4 && coordx42 == 7 || coordx41 == 5 && coordx42 == 6 || coordx41 == 5 && coordx42 == 7 || coordx41 == 6 && coordx42 == 5 || coordx41 == 6 && coordx42 == 6 || coordx41 == 6 && coordx42 == 7 || coordx41 == 6 && coordx42 == 8 || coordx41 == 7 && coordx42 == 6 || coordx41 == 7 && coordx42 == 7 || coordx41 == 7 && coordx42 == 8 || coordx41 == 7 && coordx42 == 9 || coordx41 == 8 && coordx42 == 6 || coordx41 == 8 && coordx42 == 7 || coordx41 == 9 && coordx42 == 6 || coordx41 == 9 && coordx42 == 7 || coordx41 == 8 && coordx42 == 8 || coordx41 == 10 && coordx42 == 1 || coordx41 == 11 && coordx42 == 1 || coordx41 == 12 && coordx42 == 1)*/);

                if (board.IsEmpty(coordx41, coordx42) == true)
                {
                    coordCorrecta3 = true;
                }/*
                else if (board.IsLand(coordx41, coordx42) == true)
                {
                    coordCorrecta3 = false;
                    Console.WriteLine("Position with land, please choose another position");
                }*/
                else
                {
                    coordCorrecta3 = false;
                    Console.WriteLine("Position occupied, please choose another position");
                }
            } while (coordCorrecta3 == false);
            int[] coordx4 = { coordx41, coordx42 };
            bool direcCorrecta4 = false;
            string direc4 = "";
            do
            {
                Console.Write("Direction of the ship (u, d, l, r): ");
                direc4 = Console.ReadLine();
                if (direc4 == "u")
                {
                    //int[] coordx4a = { coordx41, coordx42 + (4 * -1) }; //coordenada final
                    if (coordx42 - ac1.GetWidth() < 0)
                    {
                        Console.WriteLine("Not a valid direction. ");
                        direcCorrecta4 = false;
                    }
                    else
                    {
                        // check that all required positions in the array are empty
                        for (int i = coordx42; i > coordx42 - (ac1.GetWidth()-1); i--)
                        {
                            if (direcCorrecta4 == false)
                            {
                                if (board.IsEmpty(coordx41, i) == false)
                                {
                                    Console.WriteLine("Position occupied, please choose another direction");
                                    direcCorrecta4 = false; // if any position is occupied, there is an overlap
                                }/*
                                else if (board.IsLand(coordx41, i) == true)
                                {
                                    Console.WriteLine("Position with land, please choose another direction");
                                    direcCorrecta4 = false;
                                }*/
                                else
                                {
                                    Console.WriteLine("Ship placed correctly");
                                    direcCorrecta4 = true;
                                }
                            }
                        }
                    }
                }
                else if (direc4 == "d")
                {
                    //int[] coordx4a = { coordx41, coordx42 + 4 }; //coordenada final
                    if (coordx42 + ac1.GetWidth() > 12)
                    {
                        Console.WriteLine("Not a valid direction. ");
                        direcCorrecta4 = false;
                    }
                    else
                    {
                        // check that all required positions in the array are empty
                        for (int i = coordx42; i < coordx42 + (ac1.GetWidth()-1); i++)
                        {
                            if (direcCorrecta4 == false)
                            {
                                if (board.IsEmpty(coordx41, i) == false)
                                {
                                    Console.WriteLine("Position occupied, please choose another direction");
                                    direcCorrecta4 = false; // if any position is occupied, there is an overlap
                                }/*
                                else if (board.IsLand(coordx41, i) == true)
                                {
                                    Console.WriteLine("Position with land, please choose another direction");
                                    direcCorrecta4 = false;
                                }*/
                                else
                                {
                                    Console.WriteLine("Ship placed correctly");
                                    direcCorrecta4 = true;
                                }
                            }
                        }
                    }
                }
                else if (direc4 == "l")
                {
                    //int[] coordx4a = { coordx41 + (4 * -1), coordx42 }; //coordenada final
                    if (coordx41 - ac1.GetWidth() < 0)
                    {
                        Console.WriteLine("Not a valid direction. ");
                        direcCorrecta4 = false;
                    }
                    else
                    {
                        // check that all required positions in the array are empty
                        for (int i = coordx41; i > coordx41 - (ac1.GetWidth()-1); i--)
                        {
                            if (direcCorrecta4 == false)
                            {
                                if (board.IsEmpty(i, coordx42) == false)
                                {
                                    Console.WriteLine("Position occupied, please choose another direction");
                                    direcCorrecta4 = false; // if any position is occupied, there is an overlap
                                }/*
                                else if (board.IsLand(i, coordx42) == true)
                                {
                                    Console.WriteLine("Position with land, please choose another direction");
                                    direcCorrecta4 = false;
                                }*/
                                else
                                {
                                    Console.WriteLine("Ship placed correctly");
                                    direcCorrecta4 = true;
                                }
                            }
                        }
                    }
                }
                else if (direc4 == "r")
                {
                    //int[] coordx4a = { coordx41 + 4, coordx42 }; //coordenada final
                    if (coordx41 + ac1.GetWidth() > 12)
                    {
                        Console.WriteLine("Not a valid direction. ");
                        direcCorrecta4 = false;
                    }
                    else
                    {
                        // check that all required positions in the array are empty
                        for (int i = coordx41; i < coordx41 + (ac1.GetWidth()-1); i++)
                        {
                            if (direcCorrecta4 == false)
                            {
                                if (board.IsEmpty(i, coordx42) == false)
                                {
                                    Console.WriteLine("Position occupied, please choose another direction");
                                    direcCorrecta4 = false; // if any position is occupied, there is an overlap
                                }
                                /*else if (board.IsLand(i, coordx42) == true)
                                {
                                    Console.WriteLine("Position with land, please choose another direction");
                                    direcCorrecta4 = false;
                                }*/
                                else
                                {
                                    Console.WriteLine("Ship placed correctly");
                                    direcCorrecta4 = true;
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Not a correct direction. Please introduce 'u' for up, 'd' for down, 'l' for left and 'r' for right. ");
                    direcCorrecta4 = false;
                }
            } while (direcCorrecta4 == false);
            ac1.Posicion = new Coordenadas();
            ac1.Posicion.CoordX = coordx41;
            ac1.Posicion.CoordY = coordx42;
            ac1.Posicion.Direccion = direc4;
            board.AddShip(ac1);
            Console.WriteLine("**************************************************************\n");
        }

        

    }
}
