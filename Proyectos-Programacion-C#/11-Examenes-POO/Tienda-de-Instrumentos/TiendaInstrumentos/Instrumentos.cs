using System;
using System.Collections.Generic;

namespace TiendaInstrumentos
{
    public class Instrumentos
    {
        //Atributos        
        protected string marca, modelo, numeroSerie;
        protected bool alquilado;
        protected int longitud, latitud;
        //Constructores
        //Constructor vacío
        public Instrumentos() { }
        //Constructor parametrizado
        public Instrumentos(string marca, string modelo, string numeroSerie, int latitud, int longitud)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.numeroSerie = numeroSerie;
            this.latitud = latitud;
            this.longitud = longitud;
        }
        //Mutadores y accesores
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
        //Métodos
        public virtual void ObtenerInformacion()
        {
            Console.WriteLine("| Instrumentos |");
            Console.WriteLine("Marca: " + GetMarca());
            Console.WriteLine("Modelo: " + GetModelo());
            Console.WriteLine("Número de serie: " + GetNumeroSerie());
            Console.WriteLine("Latitud: " + GetLatitud());
            Console.WriteLine("Longitud: " + GetLongitud());            
        }
    }
}
