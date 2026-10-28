using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeContenidos
{
    class Podcast : Contenido
    {
        private int tipo, fechaCaducidad;
        private List<Episodio> episodios;

        public Podcast() { }
        public Podcast(string titulo, string plataforma, string descripcion, string genero, string url, Usuario usuario, int calificacion, int likes, int tipo, int fechaCaducidad) : base(titulo, plataforma, descripcion, genero, url, usuario, calificacion, likes)
        {
            this.tipo = tipo;
            this.fechaCaducidad = fechaCaducidad;
            episodios = new List<Episodio>();
        }

        public Podcast(string titulo, string plataforma, string descripcion, string genero, string url, Usuario usuario, int calificacion, int likes) : base(titulo, plataforma, descripcion, genero, url, usuario, calificacion, likes)
        {
            episodios = new List<Episodio>();
        }

        public int Get_Tipo() { return this.tipo; }
        public int Get_FechaCaducidad() { return this.fechaCaducidad; }

        public void Set_Tipo(int tipo) { this.tipo = tipo; }
        public void Set_FechaCaducidad(int fecha) { this.fechaCaducidad = fecha; }
        public List<Episodio> Episodios { get => episodios; set => episodios = value; }

        // Función para mostrar los contenidos almacenados
        public override void MostrarContenidos()
        {
            base.MostrarContenidos();

            string tipo = ObtenerTipo(Get_Tipo());
            string añoCad = ObtenerCaducidad(Get_FechaCaducidad());

            Console.WriteLine("Tipo de podcast: " + tipo + "\nFecha de caducidad: " + añoCad);

            Console.WriteLine("\nInformación de los episodios:\n");
            foreach (Episodio episodio in episodios)
            {
                episodio.MostrarListaEpisodios();
            }
        }

        // Función para guardar en el fichero indicado los contenidos almacenados
        public override void ExportarContenidos(StreamWriter salida)
        {
            base.ExportarContenidos(salida);

            string tipo = ObtenerTipo(Get_Tipo());
            string añoCad = ObtenerCaducidad(Get_FechaCaducidad());

            salida.WriteLine(tipo + "|" + añoCad);

            foreach (Episodio episodio in episodios)
            {
                episodio.ExportarListaEpisodios(salida);
            }
        }

        // Funciones para convertir el valor guardado en información que sea facil de entender por el usuario
        private string ObtenerTipo(int tipo)
        {
            string tipoS = "Audio";

            if (tipo == 2)
                tipoS = "Video";

            return tipoS;
        }
        private string ObtenerCaducidad(int caducidad)
        {
            string cad;

            if (caducidad == 0)
                cad = "Sin fecha límite";
            else
                cad = caducidad.ToString();

            return cad;
        }
    }
}
