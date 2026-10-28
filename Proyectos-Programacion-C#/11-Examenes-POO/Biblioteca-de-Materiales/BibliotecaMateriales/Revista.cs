using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMateriales {

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
        public override void GetInfo()
        {
            Console.WriteLine("---REVISTA---");
            Console.WriteLine("Titulo: " + Titulo);
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Numero de edicion: " + NumeroEdicion);
            Console.WriteLine("Tema: " + Tema);
        }
        public override string WriteInfo()
        {
            char sep = ';';
            string s = "revista" + sep + Titulo + sep + ISBN + sep + NumeroEdicion + sep + Tema;
            return s;
        }
    }
}
