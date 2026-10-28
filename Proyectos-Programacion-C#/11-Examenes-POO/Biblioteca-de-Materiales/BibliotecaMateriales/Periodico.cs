using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMateriales {
    public class Periodico : Material
    {
        public int NumeroEdicion { get; set; }
        public string CiudadPublicacion { get; set; }


        public Periodico(string titulo, string isbn, int numeroEdicion, string ciudadPublicacion) : base(titulo, isbn) {
            NumeroEdicion = numeroEdicion;
            CiudadPublicacion = ciudadPublicacion;
            Tipo = TipoMaterial.Periodico;
        }
        public override void GetInfo()
        {
            Console.WriteLine("---PERIODICO---");
            Console.WriteLine("Titulo: " + Titulo);
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Numero de edicion: " + NumeroEdicion);
            Console.WriteLine("Ciudad de publicacion: " + CiudadPublicacion);
        }
        public override string WriteInfo()
        {
            char sep = ';';
            string s = "periodico" + sep + Titulo + sep + ISBN + sep + NumeroEdicion + sep + CiudadPublicacion;
            return s;
        }
    }
}
