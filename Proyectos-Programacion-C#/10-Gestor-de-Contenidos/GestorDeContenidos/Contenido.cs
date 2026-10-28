using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GestorDeContenidos
{
    class Contenido
    {
        protected string titulo, plataforma, descripcion, genero, url;
        protected int calificacion, likes;
        protected Usuario usuario;

        public Contenido() {
        }
        public Contenido(string titulo, string plataforma, string descripcion, string genero, string url, Usuario usuario, int calificacion, int likes) {
            this.titulo = titulo;
            this.plataforma = plataforma;
            this.descripcion = descripcion;
            this.genero = genero;
            this.url = url;
            this.usuario = usuario;
            this.calificacion = calificacion;
            this.likes = likes;
            usuario = new Usuario();
        }

        // Acesores y mutadores
        public string Get_Titulo() { return this.titulo; }
        public string Get_Plataforma() { return this.plataforma; }
        public string Get_Descripcion() { return this.descripcion; }
        public string Get_Genero() { return this.genero; }
        public string Get_Url() { return this.url; }
        public int Get_CalificacionEdad() { return this.calificacion; }
        public int Get_NumeroLikes() { return this.likes; }

        public void Set_Titulo(string titulo) { this.titulo = titulo; }
        public void Set_Plataforma(string plat) { this.plataforma = plat; }
        public void Set_Descripcion(string descripcion) { this.descripcion = descripcion; }
        public void Set_Genero(string genero) { this.genero = genero; }
        public void Set_Url(string url) { this.url = url; }
        public void Set_CalificacionEdad(int cal) { this.calificacion = cal; }
        public void Set_NumeroLikes(int likes) { this.likes = likes; }
        public Usuario Usuario { get => usuario; set => usuario = value; }

        // Función para mostrar los contenidos almacenados
        public virtual void MostrarContenidos()
        {
            Console.WriteLine("Usuario Registrador: " + usuario.Get_Nombre() + "\n");
            Console.WriteLine("Título: " + Get_Titulo() + "\nPlataforma: " + Get_Plataforma() + "\nDescripción: " + Get_Descripcion());
            Console.WriteLine("Género: " + Get_Genero() + "\nURL: " + Get_Url());
            Console.WriteLine("Edad mínima recomendada para ver el contenido: " + Get_CalificacionEdad() + "\nNúmero de likes: " + Get_NumeroLikes());
        }

        // Funcion de escritura en el fichero de contenidos
        public virtual void ExportarContenidos(StreamWriter salida)
        {
            try
            {
                salida.Write(Get_Titulo() + "|" + Get_Plataforma() + "|" + Get_Descripcion() + "|" + Get_Genero() + "|" + Get_Url() + "|" + Usuario.Get_Nombre() + "|" + Get_CalificacionEdad() + "|" + Get_NumeroLikes() + "|");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        

    }
}
