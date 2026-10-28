using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaArchivos
{
    public abstract class Archivo
    {
        //Atributos
        protected string titulo, autor, editorial;
        protected int fecha;
        //Constructores
        //Constructor vacío
        public Archivo() { }
        //Constructor parametrizado
        public Archivo(string titulo, string autor, string editorial, int fecha)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.fecha = fecha;
        }
        //Mutadores y accesores
        public string GetTitulo()
        {
            return this.titulo;
        }
        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string GetAutor()
        {
            return this.autor;
        }
        public void SetAutor(string autor)
        {
            this.autor = autor;
        }
        public string GetEditorial()
        {
            return this.editorial;
        }
        public void SetEditorial(string editorial)
        {
            this.editorial = editorial;
        }
        public int GetFecha()
        {
            return this.fecha;
        }
        public void SetTitulo(int fecha)
        {
            this.fecha = fecha;
        }
        //Métodos
        public virtual void PedirInfo()
        {
            Console.WriteLine("Inserta el título: ");
            string titulo = Console.ReadLine();
            Console.WriteLine("Inserta el autor: ");
            string autor = Console.ReadLine();
            Console.WriteLine("Editorial: ");
            string editorial = Console.ReadLine();
            Console.WriteLine("Fecha de publicación: ");
            int fecha = int.Parse(Console.ReadLine());

            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.fecha = fecha;
        }
        public virtual void ImprimirInfo()
        {
            Console.WriteLine("Título: " + GetTitulo());
            Console.WriteLine("Autor: " + GetAutor());
            Console.WriteLine("Editorial: " + GetEditorial());
            Console.WriteLine("Fecha de publicación: " + GetFecha());
        }
    }
}
