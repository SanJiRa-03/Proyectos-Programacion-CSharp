using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica2
{
    public class AircraftCarriers : Ship
    {
        public AircraftCarriers()
        {
        }
        public AircraftCarriers(string name, int width, int hits, Coordenadas posicion) : base(name, width, hits, posicion)
        {
            Name = "Aircraft Carriers";
            Width = 5;
            Hits = hits;
            Posicion = posicion;
        }



        public override string ToString()
        {
            return " A ";
        }

    }
}
