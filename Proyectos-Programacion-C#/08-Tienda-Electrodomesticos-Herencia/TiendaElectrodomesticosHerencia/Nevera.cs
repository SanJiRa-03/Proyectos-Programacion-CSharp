using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaElectrodomesticosHerencia
{
     class Nevera : Electrodomestico
    {
        // Atributos
        private string marca, modelo;
        private int energia, año, seFabrica, inteligencia, capacidad;        
        // Constructores
        // Constructor vacío
        public Nevera() { }
        // Constructor parametrizado
        public Nevera(string marca, string modelo, int energia, int año, int seFabrica, int inteligencia, int capacidad) : base(marca, modelo, energia, año, seFabrica)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.energia = energia;
            this.año = año;
            this.seFabrica = seFabrica;
            this.inteligencia = inteligencia;
            this.capacidad = capacidad;
        }
        // Accesores y mutadores
        public int Get_capacidad()
        {
            return capacidad;
        }
        public void Set_capacidad(int capacidad)
        {
            this.capacidad = capacidad;
        }
        public int Get_inteligencia()
        {
            return inteligencia;
        }
        public void Set_inteligencia(int inteligencia)
        {
            this.inteligencia = inteligencia;
        }
        // Mostrar
        public override void MostrarInfo()
        {
            Console.WriteLine("| NEVERA |");
            base.MostrarInfo();
            VerificarIndustrial();
            Console.WriteLine("\n");
        }
        // Método de nevera
        public void VerificarIndustrial()
        {
            if (capacidad > 200 && inteligencia == 1)
            {
                Console.WriteLine("Es una nevera industrial.");
            }
            else
            {
                Console.WriteLine("No es una nevera industrial.");
            }
        }
    }
}
