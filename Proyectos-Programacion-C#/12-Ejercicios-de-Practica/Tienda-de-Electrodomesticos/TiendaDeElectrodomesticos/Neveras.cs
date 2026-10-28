using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeElectrodomesticos
{
    public class Neveras : Electrodomésticos
    {
        //Atributos        
        private int capacidad;
        //Constructores
        //Constructor vacío
        public Neveras() { }
        //Constructor parametrizado
        public Neveras(string marca, string modelo, int año, string energia, bool fabricado, int capacidad) : base(marca, modelo, año, energia, fabricado)
        {
            this.capacidad = capacidad;
        }
        //Mutadores y accesores
        public void SetCapacidad(int capacidad)
        {
            this.capacidad = capacidad;
        }
        public int GetCapacidad()
        {
            return capacidad;
        }
        //Métodos
        public string Industrial(int capacidad)
        {
            string industrial;
            if (capacidad > 200)
            {
                industrial = "sí";
            }
            else
            {
                industrial = "no";
            }
            return industrial;
        }
        public override void PedirInfo()
        {
            base.PedirInfo();
            Console.WriteLine("¿Cuánta capacidad tiene?");
            int capacidad = int.Parse(Console.ReadLine());

            this.capacidad = capacidad;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("| Neveras |");
            base.MostrarInfo();
            Console.WriteLine("Capacidad: " + GetCapacidad());
            Console.WriteLine("Inteligente: " + Industrial(capacidad));
        }
    }
}
