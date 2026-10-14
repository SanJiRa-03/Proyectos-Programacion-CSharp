using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica2
{
    internal class PlayerUI : Player
    {
        public PlayerUI()
        {

        }
        public PlayerUI(string Name) : base(Name)
        {
            this.Name = "Computer";
        }
        
        public PlayerUI(string Name, int NumMovements, int Winner):base(Name, NumMovements, Winner)
        {
            this.Name = "Computer";
            this.NumMovements = GetNumMovements();
            this.Winner = GetWinner();
        }

        //aleatorios
        public override void PlaceShips(ref BoardGame board)
        {
            Random rand = new Random();
            string[] direcciones = { "u", "d", "l", "r" };


            PatrolBoat pb1 = new PatrolBoat();
            pb1.SetWidth(2); // size = 2
            int coordx11, coordx12;
            string direc1;
            bool direcCorrecta1 = false;
            do
            {
                coordx11 = rand.Next(1, 13);
                coordx12 = rand.Next(1, 13); ; //
                direc1 = direcciones[rand.Next(4)]; // Selecciona una dirección aleatoria de direcciones
                if (direc1 == "u")
                {
                    //int[] coordx1a = { coordx11, coordx12 + (1 * -1) }; //coordenada final
                    if (coordx12 - pb1.GetWidth() < 0)
                    {
                        direcCorrecta1 = false;
                    }
                    else
                    {
                        direcCorrecta1 = true;
                    }

                }
                else if (direc1 == "d")
                {
                    //int[] coordx1a = { coordx11, coordx12 + 1 }; //coordenada final
                    if (coordx12 + pb1.GetWidth() > 12)
                    {
                        direcCorrecta1 = false;
                    }
                    else
                    {
                        direcCorrecta1 = true;
                    }
                }
                else if (direc1 == "l")
                {
                    //int[] coordx1a = { coordx11 + (1 * -1) , coordx12}; //coordenada final
                    if (coordx11 - pb1.GetWidth() < 0)
                    {
                        direcCorrecta1 = false;
                    }
                    else
                    {
                        direcCorrecta1 = true;
                    }
                }
                else if (direc1 == "r")
                {
                    //int[] coordx1a = { coordx11 + 1 , coordx12}; //coordenada final
                    if (coordx11 + pb1.GetWidth() > 12)
                    {
                        direcCorrecta1 = false;
                    }
                    else
                    {
                        direcCorrecta1 = true;
                    }
                }
                else
                {
                    direcCorrecta1 = false;
                }
            } while (direcCorrecta1 == false);
            pb1.Posicion = new Coordenadas();
            pb1.Posicion.CoordX = coordx11;
            pb1.Posicion.CoordY = coordx12;
            pb1.Posicion.Direccion = direc1;
            board.AddShip(pb1);

            
            Submarine s1 = new Submarine();
            s1.SetWidth(3); // size = 3
            int coordx21;
            int coordx22;
            string direc2;
            bool direcCorrecta2 = false; 
            do
            {
                coordx21 = rand.Next(1, 13);
                coordx22 = rand.Next(1, 13); ; //
                direc2 = direcciones[rand.Next(4)]; // Selecciona una dirección aleatoria de direcciones
                if (direc2 == "u")
                {
                    //int[] coordx2a = { coordx21, coordx22 + (2 * -1) }; //coordenada final
                    if (coordx22 - s1.GetWidth() < 0)
                    {
                        direcCorrecta2 = false;
                    }
                    else
                    {
                        direcCorrecta2 = true;
                    }
                }
                else if (direc2 == "d")
                {
                    //int[] coordx2a = { coordx21, coordx22 + 2 }; //coordenada final
                    if (coordx22 + s1.GetWidth() > 12)
                    {
                        direcCorrecta2 = false;
                    }
                    else
                    {
                        direcCorrecta2 = true;
                    }
                }
                else if (direc2 == "l")
                {
                    //int[] coordx2a = { coordx21 + (2 * -1), coordx22 }; //coordenada final
                    if (coordx21 - s1.GetWidth() < 0)
                    {
                        direcCorrecta2 = false;
                    }
                    else
                    {
                        direcCorrecta2 = true;
                    }
                }
                else if (direc2 == "r")
                {
                    //int[] coordx2a = { coordx21 + 2, coordx22 }; //coordenada final
                    if (coordx21 + s1.GetWidth() > 12)
                    {
                        direcCorrecta2 = false;
                    }
                    else
                    {
                        direcCorrecta2 = true;
                    }
                }
                else
                {
                    direcCorrecta2 = false;
                }
            } while (direcCorrecta2 == false);
            s1.Posicion = new Coordenadas();
            s1.Posicion.CoordX = coordx21;
            s1.Posicion.CoordY = coordx22;
            s1.Posicion.Direccion = direc2;
            board.AddShip(s1);

            Destructor d1 = new Destructor();
            d1.SetWidth(4); // size = 4
            int coordx31;
            int coordx32;
            string direc3;
            bool direcCorrecta3 = false;
            do
            {
                coordx31 = rand.Next(1, 13);
                coordx32 = rand.Next(1, 13); ; //
                direc3 = direcciones[rand.Next(4)]; // Selecciona una dirección aleatoria de direcciones
                if (direc3 == "u")
                {
                    //int[] coordx3a = { coordx31, coordx32 + (3 * -1) }; //coordenada final
                    if (coordx32 - d1.GetWidth() < 0)
                    {
                        direcCorrecta3 = false;
                    }
                    else
                    {
                        direcCorrecta3 = true;
                    }
                }
                else if (direc3 == "d")
                {
                    //int[] coordx3a = { coordx31, coordx32 + 3 }; //coordenada final
                    if (coordx32 + d1.GetWidth() > 12)
                    {
                        direcCorrecta3 = false;
                    }
                    else
                    {
                        direcCorrecta3 = true;
                    }
                }
                else if (direc3 == "l")
                {
                    //int[] coordx3a = { coordx31 + (3 * -1), coordx32 }; //coordenada final
                    if (coordx31 - d1.GetWidth() < 0)
                    {
                        direcCorrecta3 = false;
                    }
                    else
                    {
                        direcCorrecta3 = true;
                    }
                }
                else if (direc3 == "r")
                {
                    //int[] coordx3a = { coordx31 + 3, coordx32 }; //coordenada final
                    if (coordx31 + d1.GetWidth() > 12)
                    {
                        direcCorrecta3 = false;
                    }
                    else
                    {
                        direcCorrecta3 = true;
                    }
                }
                else
                {
                    direcCorrecta3 = false;
                }
            } while (direcCorrecta3 == false);
            d1.Posicion = new Coordenadas();
            d1.Posicion.CoordX = coordx31;
            d1.Posicion.CoordY = coordx32;
            d1.Posicion.Direccion = direc3;
            board.AddShip(d1);

            AircraftCarriers ac1 = new AircraftCarriers();
            ac1.SetWidth(5); // size = 5
            int coordx41;
            int coordx42;
            string direc4;
            bool direcCorrecta4 = false;
            do
            {
                coordx41 = rand.Next(1, 13);
                coordx42 = rand.Next(1, 13); ; //
                direc4 = direcciones[rand.Next(4)]; // Selecciona una dirección aleatoria de direcciones
                if (direc4 == "u")
                {
                    //int[] coordx4a = { coordx41, coordx42 + (4 * -1) }; //coordenada final
                    if (coordx42 - ac1.GetWidth() < 0)
                    {
                        direcCorrecta4 = false;
                    }
                    else
                    {
                        direcCorrecta4 = true;
                    }
                }
                else if (direc4 == "d")
                {
                    //int[] coordx4a = { coordx41, coordx42 + 4 }; //coordenada final
                    if (coordx42 + ac1.GetWidth() > 12)
                    {
                        direcCorrecta4 = false;
                    }
                    else
                    {
                        direcCorrecta4 = true;
                    }
                }
                else if (direc4 == "l")
                {
                    //int[] coordx4a = { coordx41 + (4 * -1), coordx42 }; //coordenada final
                    if (coordx41 - ac1.GetWidth() < 0)
                    {
                        direcCorrecta4 = false;
                    }
                    else
                    {
                        direcCorrecta4 = true;
                    }
                }
                else if (direc4 == "r")
                {
                    //int[] coordx4a = { coordx41 + 4, coordx42 }; //coordenada final
                    if (coordx41 + ac1.GetWidth() > 12)
                    {
                        direcCorrecta4 = false;
                    }
                    else
                    {
                        direcCorrecta4 = true;
                    }
                }
                else
                {
                    direcCorrecta4 = false;
                }
            } while (direcCorrecta4 == false);
            ac1.Posicion = new Coordenadas();
            ac1.Posicion.CoordX = coordx41;
            ac1.Posicion.CoordY = coordx42;
            ac1.Posicion.Direccion = direc4;
            board.AddShip(ac1);

            
            
        }

    }
}
