using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoAstros
{
    class Estrella : Astro
    {
        private int planetas;
        private float temperatura;

        public Estrella(int planetas, float temperatura, string nombre, float diametro, float X, float Y, float Z) : base(nombre, diametro, X, Y, Z)
        {
            this.nombre = nombre;
            this.diametro = diametro;
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.planetas = planetas;
            this.temperatura = temperatura;
        }
        public Estrella()
        {
        }

        public int Planetas
        {
            get => planetas;
            set => planetas = value;
        }
        public float Temperatura
        {
            get => temperatura;
            set => temperatura = value;
        }
        public string tipo_de_estrella(float temperatura)
        {
            string tipo;

            if (temperatura >= 30000)
            {
                tipo = "O";
            }
            else if (temperatura >= 20000)
            {
                tipo = "B";
            }
            else if (temperatura >= 10000)
            {
                tipo = "A";
            }
            else if (temperatura >= 7000)
            {
                tipo = "F";
            }
            else if (temperatura >= 6000)
            {
                tipo = "G";
            }
            else if (temperatura >= 4000)
            {
                tipo = "K";
            }
            else
            {
                tipo = "M";
            }
            return tipo;
        }
    }
}
