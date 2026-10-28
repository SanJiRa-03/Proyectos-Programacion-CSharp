using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeContenidos
{
    class Episodio
    {
        private Contenido tipoAlmacenado;
        private string titulo;
        private int temporada, episodioTemporada;

        public Episodio()
        {
            
        }
        public Episodio(string titulo, int temporada, int episodioTemporada)
        {
            this.titulo = titulo;
            this.temporada = temporada;
            this.episodioTemporada = episodioTemporada;
        }
        // Accesores y mutadores
        public string Get_Titulo() { return this.titulo; }
        public int Get_Temporada() { return this.temporada; }
        public int Get_EpisodioTemporada() { return this.episodioTemporada; }

        public void Set_Titulo(string titulo) { this.titulo = titulo; }
        public void Set_Temporada(int temp) { this.temporada = temp; }
        public void Set_EpisodioTemporada(int episodio) { this.episodioTemporada = episodio; }
        public Contenido TipoAlmacenado { get => tipoAlmacenado; set => tipoAlmacenado = value; }

        // Función para mostrar los contenidos almacenados
        public void MostrarListaEpisodios()
        {
            Console.WriteLine("Título del episodio: " + Get_Titulo() + "\nTemporada: " + Get_Temporada() + "\nNúmero de episodio de la temporada: " + Get_EpisodioTemporada());
            Console.WriteLine("-----------------------------------------------" + "\n");
        }

        // Función para guardar en el fichero indicado los contenidos almacenados
        public void ExportarListaEpisodios(StreamWriter salida)
        {
            salida.Write(Get_Titulo() + "|" + Get_Temporada() + "|" + Get_EpisodioTemporada() + "\n");
        }
    }
}
