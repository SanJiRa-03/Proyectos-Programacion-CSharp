using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInstrumentos
{
    public class Pianos : Instrumentos
    {
        //Atributos               
        private int numeroTeclas;
        private string tipoPiano;
        private bool alquilado;
        //Constructores
        //Constructor vacío
        public Pianos()
        {
            Console.WriteLine("Insertando piano...");
            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Modelo: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("Número de serie: ");
            string numeroSerie = Console.ReadLine();
            Console.WriteLine("Número de teclas: ");
            int numeroTeclas = int.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de piano: ");
            string tipoPiano = Console.ReadLine();            
            Console.WriteLine("Latitud: ");
            int latitud = int.Parse(Console.ReadLine());
            Console.WriteLine("Longitud: ");
            int longitud = int.Parse(Console.ReadLine());

            this.marca = marca;
            this.modelo = modelo;
            this.numeroSerie = numeroSerie;
            this.numeroTeclas = numeroTeclas;
            this.tipoPiano = tipoPiano;
            this.latitud = latitud;
            this.latitud = longitud;
        }
        //Constructor parametrizado
        public Pianos(string marca, string modelo, string numeroSerie, int longitud, int latitud, int numeroTeclas, string tipoPiano) : base(marca, modelo, numeroSerie, latitud, longitud)
        {
            this.numeroTeclas = numeroTeclas;
            this.tipoPiano = tipoPiano;
        }
        //Mutadores y accesores
        public void SetNumeroTeclas(int numeroTeclas)
        {
            this.numeroTeclas = numeroTeclas;
        }
        public int GetNumeroTeclas()
        {
            return numeroTeclas;
        }
        public void SetTipoPiano(string tipoPiano)
        {
            this.tipoPiano = tipoPiano;
        }
        public string GetTipoPiano()
        {
            return tipoPiano;
        }
        //Métodos
        public override void ObtenerInformacion()
        {
            Console.WriteLine("PIANOS:");
            base.ObtenerInformacion();
            Console.WriteLine("Número de teclas: " + GetNumeroTeclas());
            Console.WriteLine("Tipo de piano: " + GetTipoPiano());
        }
    }
}
