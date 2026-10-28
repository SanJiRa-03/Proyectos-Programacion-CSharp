using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInstrumentos
{
    public class Guitarras : Instrumentos
    {
        //Atributos                
        private int numeroCuerdas;
        private string tipoGuitarra;                
        public Guitarras() 
        {
            Console.WriteLine("Insertando guitarra...");
            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Modelo: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("Número de serie: ");
            string numeroSerie = Console.ReadLine();
            Console.WriteLine("Número de cuerdas: ");
            int numeroCuerdas = int.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de guitarra: ");
            string tipoGuitarra = Console.ReadLine();            
            Console.WriteLine("Latitud: ");
            int latitud = int.Parse(Console.ReadLine());
            Console.WriteLine("Longitud: ");
            int longitud = int.Parse(Console.ReadLine());


            this.marca = marca;
            this.modelo = modelo;
            this.numeroSerie = numeroSerie;
            this.numeroCuerdas = numeroCuerdas;
            this.tipoGuitarra = tipoGuitarra;
            this.latitud = latitud;
            this.latitud = longitud;
        }
        //Constructor parametrizado
        public Guitarras(string marca, string modelo, string numeroSerie, int longitud, int latitud, int numeroCuerdas, string tipoGuitarra) : base(marca, modelo, numeroSerie, latitud, longitud)
        {
            this.numeroCuerdas = numeroCuerdas;
            this.tipoGuitarra = tipoGuitarra;
        }
        //Mutadores y accesores
        public void SetNumeroCuerdas(int numeroCuerdas)
        {
            this.numeroCuerdas = numeroCuerdas;
        }
        public int GetNumeroCuerdas()
        {
            return numeroCuerdas;
        }
        public void SetTipoGuitarra(string tipoGuitarra)
        {
            this.tipoGuitarra = tipoGuitarra;
        }
        public string GetTipoGuitarra()
        {
            return tipoGuitarra;
        }
        //Métodos
        public override void ObtenerInformacion()
        {
            Console.WriteLine("GUITARRAS:");
            base.ObtenerInformacion();
            Console.WriteLine("Número de cuerdas: " + GetNumeroCuerdas());
            Console.WriteLine("Tipo de guitarra: " + GetTipoGuitarra ());            
        }
    }
}
