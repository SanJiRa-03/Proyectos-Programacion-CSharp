using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publicaciones
{
    public class Libro : Publicacion
    {
        //Atributos
        private string autor;
        private int ejemplares;
        //Constructores
        //Constructor vacío
        public Libro() { }
        //Constructor parametrizado
        public Libro(string titulo, string editorial, int paginas, string autor, int ejemplares) : base(titulo, editorial, paginas)
        {
            this.autor = autor;
            this.ejemplares = ejemplares;
        }
        //Mutadoers y accesores
        public void SetAutor(string autor)
        {
            this.autor = autor;
        }
        public string GetAutor()
        {
            return autor;
        }
        public void SetEjemplares(int ejemplares)
        {
            this.ejemplares = ejemplares;
        }
        public int GetEjemplares()
        {
            return ejemplares;
        }       
        //Métodos
        public override void PedirInfo()
        {
            Console.WriteLine("Insertando libro...\n");
            base.PedirInfo();
            Console.WriteLine("Inserta el autor del libro: ");
            string autor = Console.ReadLine();
            Console.WriteLine("Inserta el nº de ejemplares que tiene el libro: ");
            int ejemplares = int.Parse(Console.ReadLine());

            this.autor = autor;
            this.ejemplares = ejemplares;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("|LIBROS|");
            base.MostrarInfo();
            Console.WriteLine("- Autor: " + GetAutor());
            Console.WriteLine("- Número de ejemplares: " + GetEjemplares() + "\n");
        }
    }
}
