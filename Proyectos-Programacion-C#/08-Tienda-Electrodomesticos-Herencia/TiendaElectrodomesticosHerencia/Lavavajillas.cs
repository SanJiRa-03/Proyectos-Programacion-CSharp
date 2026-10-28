using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaElectrodomesticosHerencia
{
    class Lavavajillas : Electrodomestico
    {
        // Atributos
        private string marca, modelo;
        private int energia, año, seFabrica, tiempo;
        // Constructores
        // Constructor vacío
        public Lavavajillas() { }
        // Constructor parametrizado
        public Lavavajillas(string marca, string modelo, int energia, int año, int seFabrica, int tiempo) : base(marca, modelo, energia, año, seFabrica)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.energia = energia;
            this.año = año;
            this.seFabrica = seFabrica;
            this.tiempo = tiempo;
        }  
        // Accesores y mutadores
        public int Get_tiempo()
        {
            return tiempo;
        }
        public void Set_tiempo(int tiempo)
        {
            this.tiempo = tiempo;
        }
        // Mostrar
        public override void MostrarInfo()
        {
            Console.WriteLine("| LAVAVAJILLAS |");
            base.MostrarInfo();
            VerificarSostenibilidad();
            Console.WriteLine("\n");
        }
        // Método de lavavajillas
        public void VerificarSostenibilidad()
        {
            if (tiempo < 45 && año > 2018)
            {
                Console.WriteLine("Es un lavavajillas sostenible.");
            }
            else
            {
                Console.WriteLine("No es un lavavajillas sostenible.");
            }
        }
    }
}
