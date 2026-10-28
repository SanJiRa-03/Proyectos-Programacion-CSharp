using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeContenidos
{
    class Serie : Contenido
    {
        private int numeroTemporadas, estado; // Estado 1 - En emision 2- Finalizado
        private List<Episodio> episodios;


        public Serie() { }
        public Serie(string titulo, string plataforma, string descripcion, string genero, string url, Usuario usuario, int calificacion, int likes, int numeroTemporadas, int estado) : base(titulo, plataforma, descripcion, genero, url, usuario, calificacion, likes)
        {
            this.numeroTemporadas = numeroTemporadas;
            this.estado = estado;
            episodios = new List<Episodio>();
        }

        public Serie(string titulo, string plataforma, string descripcion, string genero, string url, Usuario usuario, int calificacion, int likes) : base(titulo, plataforma, descripcion, genero, url, usuario, calificacion, likes)
        {
            episodios = new List<Episodio>();
        }

        // Accesores y mutadores
        public List<Episodio> Episodios { get => episodios; set => episodios = value; }
        public int Get_NumeroTemporadas() { return this.numeroTemporadas; }
        public int Get_Estado() { return this.estado; }

        public void Set_NumeroTemporadas(int nTemporadas) { this.numeroTemporadas = nTemporadas; }
        public void Set_Estado(int estado) { this.estado = estado; }
        
        // Función para mostrar los contenidos almacenados
        public override void MostrarContenidos()
        {
            base.MostrarContenidos();

            string estado = ObtenerEstado(Get_Estado());
            Console.WriteLine("Número de temporadas: " + Get_NumeroTemporadas() + "\nEstado de la serie: " + estado);

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

            string estado = ObtenerEstado(Get_Estado());
            salida.Write(Get_NumeroTemporadas() + "|" + estado + "\n");

            foreach (Episodio episodio in episodios)
            {
                episodio.ExportarListaEpisodios(salida);
            }
        }

        // Función para convertir el valor guardado en información que sea facil de entender por el usuario
        private string ObtenerEstado(int estado)
        {
            string est = "En emision";

            if (estado == 2)
                est = "Finalizado";

            return est;
        }
    }
}
