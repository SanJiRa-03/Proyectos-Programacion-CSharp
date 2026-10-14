using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica2
{
    public abstract class Ship
    {
        protected string Name;
        protected int Width;
        protected int Hits;
        public Coordenadas Posicion;
        
        public bool IsSunk()
        {
            if (Hits >= Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Ship()
        {
        }
        public Ship(string name, int width, int hits, Coordenadas posicion)
        {
            Name = name;
            Width = width;
            Hits = hits;
            Posicion = posicion;
        }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public int GetWidth()
        {
            return Width;
        }
        public void SetWidth(int width)
        {
            this.Width = width;
        }
        public int GetHits()
        {
            return Hits;
        }
        public void SetHits(int hits)
        {
            this.Hits = hits;
        }
        public Coordenadas GetPos()
        {
            return Posicion;
        }
        public void SetPos(Coordenadas posicion)
        {
            this.Posicion = posicion;
        }




    }
}
