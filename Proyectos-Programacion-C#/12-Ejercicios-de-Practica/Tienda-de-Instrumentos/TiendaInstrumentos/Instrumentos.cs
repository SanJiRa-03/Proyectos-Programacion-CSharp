using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInstrumentos
{
    public class Instrumentos
    {
        protected string marca, modelo, numeroSerie;
        protected bool alquilado = false;
        protected int latitud, longitud;

        public Instrumentos() { }
        public Instrumentos(string marca, string modelo, string numeroSerie, bool alquilado, int latitud, int longitud)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.numeroSerie = numeroSerie;
            this.alquilado = alquilado;
            this.latitud = latitud;
            this.longitud = longitud;
        }

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        public string GetMarca()
        {
            return marca;
        }
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string GetModelo()
        {
            return modelo;
        }
        public void SetNumeroSerie(string numeroSerie)
        {
            this.numeroSerie = numeroSerie;
        }
        public string GetNumeroSerie()
        {
            return numeroSerie;
        }
        public void SetAlquilado(bool alquilado)
        {
            this.alquilado = alquilado;
        }
        public bool GetAlquilado()
        {
            return alquilado;
        }
        public void SetLatitud(int latitud)
        {
            this.latitud = latitud;
        }
        public int GetLatitud()
        {
            return latitud;
        }
        public void SetLongitud(int longitud)
        {
            this.longitud = longitud;
        }
        public int GetLongitud()
        {
            return longitud;
        }

        public virtual void PedirInfo()
        {
            Console.WriteLine("Inserte la marca: ");
            marca = Console.ReadLine();
            Console.WriteLine("Inserte el modelo:");
            modelo = Console.ReadLine();
            Console.WriteLine("Inserte el número de serie:");
            numeroSerie = Console.ReadLine();
            Console.WriteLine("Inserte la latitud:");
            latitud = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte la longitud:");
            longitud = int.Parse(Console.ReadLine());   
        }
        public virtual void MostrarInfo()
        {
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Número de serie: " + numeroSerie);
            Console.WriteLine("Latitud: " + latitud);
            Console.WriteLine("Longitud: " + longitud);
        }
        public virtual string EscribirInfo()
        {
            char sep = ';';
            string s = (marca + sep + modelo + sep + numeroSerie + sep + latitud + sep + longitud);
            return s;
        }
    }
}
