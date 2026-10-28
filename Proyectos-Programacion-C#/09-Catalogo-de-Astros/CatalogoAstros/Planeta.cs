using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoAstros
{
    internal class Planeta : Astro
    {
        private int periodo;
        private float inclinacion;
        private bool habitable;

        public Planeta(int periodo, float inclinacion, bool habitable, string nombre, float diametro, float X, float Y, float Z) : base(nombre, diametro, X, Y, Z)
        {
            this.periodo = periodo;
            this.inclinacion = inclinacion;
            this.habitable = habitable;
            this.nombre = nombre;
            this.diametro = diametro;
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        public Planeta()
        {
        }

        public int Periodo
        {
            get => periodo;
            set => periodo = value;
        }
        public float Inclinacion
        {
            get => inclinacion;
            set => inclinacion = value;
        }
        public bool Habitable
        {
            get => habitable;
            set => habitable = value;
        }
        public string Hab(bool hab)
        {
            string habitable;
            if (hab == true)
            {
                habitable = "si";
            }
            else
            {
                habitable = "no";
            }
            return habitable;
        }
    }
}
