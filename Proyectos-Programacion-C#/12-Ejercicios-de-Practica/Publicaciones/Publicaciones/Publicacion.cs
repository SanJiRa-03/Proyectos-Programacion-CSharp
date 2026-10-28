using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publicaciones
{
    public abstract class Publicacion
    {
        //Atributos
        protected string titulo, editorial;
        protected int paginas;
        //Constructores
        //Constructor vacío
        public Publicacion() { }
        //Constructor parametrizado
        public Publicacion(string titulo, string editorial, int paginas)
        {
            this.titulo = titulo;
            this.editorial = editorial;
            this.paginas = paginas;
        }
        //Mutadoers y accesores
        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string GetTitulo()
        {
            return titulo;
        }
        public void SetEditorial(string editorial)
        {
            this.editorial = editorial;
        }
        public string GetEditorial()
        {
            return editorial;
        }
        public void SetPaginas(int paginas)
        {
            this.paginas = paginas;
        }
        public int GetPaginas()
        {
            return paginas;
        }
        //Métodos
        public virtual void PedirInfo()
        {
            Console.WriteLine("Inserta el título de la publicación: ");
            string titulo = Console.ReadLine();
            Console.WriteLine("Inserta la editorial de la publicación: ");
            string editorial = Console.ReadLine();
            Console.WriteLine("Inserta el número de páginas: ");
            int paginas = int.Parse(Console.ReadLine());

            this.titulo = titulo;
            this.editorial = editorial;
            this.paginas = paginas;
        }
        public virtual void MostrarInfo()
        {
            Console.WriteLine("- Título: " + GetTitulo());
            Console.WriteLine("- Editorial: " + GetEditorial());
            Console.WriteLine("- Número de páginas: " + GetPaginas());
        }       
    }
}
