using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeContenidos
{
    class Pelicula : Contenido
    {
        private int añoEstreno, duracion;
        private string director, distribuidora;

        public Pelicula() { }
        public Pelicula(string titulo, string plataforma, string descripcion, string genero, string url, Usuario usuario, int calificacion, int likes, int añoEstreno, int duracion, string director, string distribuidora) : base(titulo, plataforma, descripcion, genero, url, usuario, calificacion, likes)
        {
            this.añoEstreno = añoEstreno;
            this.duracion = duracion;
            this.director = director;
            this.distribuidora = distribuidora;
        }

        public Pelicula(string titulo, string plataforma, string descripcion, string genero, string url, Usuario usuario, int calificacion, int likes) : base(titulo, plataforma, descripcion, genero, url, usuario, calificacion, likes)
        {
        }

        // Acesores y mutadores
        public int Get_AñoEstreno() { return this.añoEstreno; }
        public int Get_Duracion() { return this.duracion; }
        public string Get_Director() { return this.director; }
        public string Get_Distribuidora() { return this.distribuidora; }

        public void Set_AñoEstreno(int añoEstreno) { this.añoEstreno = añoEstreno; }
        public void Set_Duracion(int duracion) { this.duracion = duracion; }
        public void Set_Director(string director) { this.director = director; }
        public void Set_Distribuidora(string distribuidora) { this.distribuidora = distribuidora; }

        // Función para mostrar los contenidos almacenados
        public override void MostrarContenidos()
        {
            base.MostrarContenidos();
            Console.WriteLine("Año de estreno: " + Get_AñoEstreno() + "\nDuración: " + Get_Duracion() + "\nDirector: " + Get_Director() + "\nDistribuidora: " + Get_Distribuidora());
            Console.WriteLine("-----------------------------------------------" + "\n");
        }

        // Función para guardar en el fichero indicado los contenidos almacenados
        public override void ExportarContenidos(StreamWriter salida)
        {
            base.ExportarContenidos(salida);
            salida.WriteLine(Get_Director() + "|" + Get_Distribuidora() + "|" + Get_AñoEstreno() + "|" + Get_Duracion());

        }
    }
}
