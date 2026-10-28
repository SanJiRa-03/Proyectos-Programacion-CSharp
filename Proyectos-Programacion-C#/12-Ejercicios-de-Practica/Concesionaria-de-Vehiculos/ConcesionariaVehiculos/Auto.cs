using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionariaVehiculos
{
    public class Auto : Vehículo
    {
        //Atributos
        private int cantidadPuertas;
        //Constructores
        //Constructor vacío
        public Auto() { }
        //Constructor parametrizado
        public Auto(string marca, string modelo, int año, int cantidadPuertas) : base(marca, modelo, año)
        {
            this.cantidadPuertas = cantidadPuertas;
        }
        public void SetCantidadPuertas(int cantidadPuertas)
        {
            this.cantidadPuertas = cantidadPuertas;
        }
        public int GetCantidadPuertas()
        {
            return this.cantidadPuertas;
        }
        //Métodos
        public override void MostrarVehiculo()
        {
            Console.WriteLine("\n| AUTOS |");
            base.MostrarVehiculo();
            Console.WriteLine("Cantidad de puertas: " + GetCantidadPuertas());                        
        }
        public override void AgregarVehiculo()
        {
            base.AgregarVehiculo();
            Console.WriteLine("Inserte la cantidad de puertas que tiene el auto: ");
            int cantidadPuertas = int.Parse(Console.ReadLine());

            this.cantidadPuertas = cantidadPuertas;
        }
    }
}
