using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaElectrodomesticosHerencia
{
     class Horno : Electrodomestico
    {
        // Atributos
        private string marca, modelo;
        private int energia, año, seFabrica, autolimpiado;
        // Constructores
        // Constructor vacío
        public Horno() { }
        // Constructor parametrizado
        public Horno(string marca, string modelo, int energia, int año, int seFabrica, int autolimpiado) : base(marca, modelo, energia, año, seFabrica)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.energia = energia;
            this.año = año;
            this.seFabrica = seFabrica;
            this.autolimpiado = autolimpiado;

        }
        // Accesores y Mutadores 
        public int Get_autolimpiado()
        {
            return autolimpiado;
        }
        public void Set_autolimpiado(int autolimpiado)
        {
            this.autolimpiado = autolimpiado;
        }
        // Mostrar
        public override void MostrarInfo()
        {
            Console.WriteLine("| HORNO |");
            base.MostrarInfo();
            VerificarGeneracion();
            Console.WriteLine("\n");
        }
        // Método de horno
        public void VerificarGeneracion()
        {
            if (energia == 1 && autolimpiado == 1 && año >= 2019)
            {
                Console.WriteLine("Es un horno de última generación.");
            }
            else
            {
                Console.WriteLine("No es un horno de última generación.");
            }
        }
    }
}
