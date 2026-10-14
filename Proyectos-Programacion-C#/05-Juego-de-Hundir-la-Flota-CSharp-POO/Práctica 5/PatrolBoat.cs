using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica2
{
    public class PatrolBoat : Ship
    {
        public PatrolBoat()
        {
        }
        public PatrolBoat(string name, int width, int hits, Coordenadas posicion) : base(name, width, hits, posicion)
        {
            Name = "Patrol Boat";
            Width = 2;
            Hits = hits;
            Posicion = posicion;
        }

        public override string ToString()
        {
            return " P ";
        }

    }
}
