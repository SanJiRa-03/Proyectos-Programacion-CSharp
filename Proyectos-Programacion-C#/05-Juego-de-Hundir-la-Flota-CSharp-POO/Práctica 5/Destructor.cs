using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica2
{
    public class Destructor : Ship
    {
        public Destructor()
        {
        }
        public Destructor(string name, int width, int hits, Coordenadas posicion) : base(name, width, hits, posicion)
        {
            Name = "Destructor";
            Width = 4;
            Hits = hits;
            Posicion = posicion;
        }



        public override string ToString()
        {
            return " D ";
        }

    }
}
