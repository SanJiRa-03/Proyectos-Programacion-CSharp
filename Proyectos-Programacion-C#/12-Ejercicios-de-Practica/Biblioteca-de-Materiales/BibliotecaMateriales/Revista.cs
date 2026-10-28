using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaMateriales.Material;

namespace BibliotecaMateriales
{
    public class Revista : Material
    {
        public int NumeroEdicion { get; set; }
        public string Tema { get; set; }

        public Revista(string titulo, string isbn, int numeroEdicion, string tema) : base(titulo, isbn)
        {
            this.NumeroEdicion = numeroEdicion;
            this.Tema = tema;
            this.Tipo = TipoMaterial.Revista;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("---REVISTA---");
            Console.WriteLine("Titulo: " + Titulo);
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Autor: " + NumeroEdicion);
            Console.WriteLine("Numero de paginas: " + Tema);
        }
        public override string EscribirInfo()
        {
            char sep = ';';
            string s = "revista" + sep + Titulo + sep + ISBN + sep + NumeroEdicion + sep + Tema;
            return s;
        }
    }
}
