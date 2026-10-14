using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica2
{
    public class Submarine : Ship
    {
        public Submarine()
        {
        }
        public Submarine(string name, int width, int hits, Coordenadas posicion) : base(name, width, hits, posicion)
        {
            Name = "Submarine";
            Width = 3;
            Hits = hits;
            Posicion = posicion;
        }

        public override string ToString()
        {
            return " S ";
        }

    }
}
