using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMateriales
{
    public abstract class Material 
    {
        public string Titulo { get; set; }
        public string ISBN { get; set; }

        public enum TipoMaterial
        {
            Libro,
            Revista,
            Periodico
        }

        public TipoMaterial Tipo { get; set; }

        public Material(string titulo, string isbn)
        {
            Titulo = titulo;
            ISBN = isbn;
        }
        public abstract void MostrarInfo();
        public abstract string EscribirInfo();
    }
}
