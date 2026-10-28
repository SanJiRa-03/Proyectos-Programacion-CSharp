using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoAstros
{
    internal class Cometa : Astro
    {
        private int anio;
        private string nombreestrella;
        private int periodo;

        public Cometa(int anio, string nombreestrella, string nombre, int periodo, float diametro, float X, float Y, float Z) : base(nombre, diametro, X, Y, Z)
        {
            this.anio = anio;
            this.nombreestrella = nombreestrella;
            this.nombre = nombre;
            this.periodo = periodo;
            this.diametro = diametro;
            this.X = X;
            this.Y = Y; 
            this.Z = Z;
        }
        public Cometa()
        {
        }

        public int Anio
        {
            get => anio;
            set => anio = value;
        }
        public string Nombreestrella
        {
            get => nombreestrella;
            set => nombreestrella = value;
        }
        public int Periodo
        {
            get => periodo;
            set => periodo = value;
        }
     }
}
