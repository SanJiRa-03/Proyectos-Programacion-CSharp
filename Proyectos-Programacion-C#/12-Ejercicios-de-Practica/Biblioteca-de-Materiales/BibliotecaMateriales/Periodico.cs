using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaMateriales.Material;

namespace BibliotecaMateriales
{
    public class Periodico : Material
    {
        public int NumeroEdicion { get; set; }
        public string CiudadPublicacion { get; set; }


        public Periodico(string titulo, string isbn, int numeroEdicion, string ciudadPublicacion) : base(titulo, isbn)
        {
            NumeroEdicion = numeroEdicion;
            CiudadPublicacion = ciudadPublicacion;
            Tipo = TipoMaterial.Periodico;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("---PERIÓDICO---");
            Console.WriteLine("Titulo: " + Titulo);
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Autor: " + NumeroEdicion);
            Console.WriteLine("Numero de paginas: " + CiudadPublicacion);
        }
        public override string EscribirInfo()
        {
            char sep = ';';
            string s = "periodico" + sep + Titulo + sep + ISBN + sep + NumeroEdicion + sep + CiudadPublicacion;
            return s;
        }
    }
}
