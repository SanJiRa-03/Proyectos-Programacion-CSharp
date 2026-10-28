using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMateriales {
    public class Libro : Material
    {
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }


        public Libro(string titulo, string isbn, string autor, int numeroPaginas) : base(titulo, isbn) {
            this.Autor = autor;
            this.NumeroPaginas = numeroPaginas;
            this.Tipo = TipoMaterial.Libro;
        }

        public override void GetInfo()
        {
            Console.WriteLine("---LIBRO---");
            Console.WriteLine("Titulo: " + Titulo);
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Numero de paginas: " + NumeroPaginas);
        }

        public override string WriteInfo()
        {
            char sep = ';';
            string s = "libro" + sep + Titulo + sep + ISBN + sep + Autor + sep + NumeroPaginas;
            return s;
        }
    }
}
