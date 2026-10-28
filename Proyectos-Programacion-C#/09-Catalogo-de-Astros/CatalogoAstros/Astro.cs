using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoAstros
{
     class Astro
    {
        protected string nombre;
        protected float diametro;
        protected float x;
        protected float y;
        protected float z;
        public Astro (string nombre, float diametro, float X, float Y, float Z)
        {
            this.nombre = nombre;
            this.diametro = diametro;    
            this.x = X;
            this.y = Y;
            this.z = Z;         
        }
    public Astro()
        {
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public float Diametro
        {
            get => diametro;
            set => diametro = value;
        }
        public float X
        {
            get => x;
            set => x = value;
        }
        public float Y
        {
            get => y;
            set => y = value;
        }
        public float Z
        {
            get => z;
            set => z = value;
        }
    }
}
