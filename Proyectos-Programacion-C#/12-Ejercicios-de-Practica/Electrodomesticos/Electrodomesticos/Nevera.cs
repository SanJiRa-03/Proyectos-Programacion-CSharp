using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    public class Nevera : Electrodomestico
    {
        //Atributos        
        //ENCAPSULAMIENTO
        private int capacidad;
        //Constructores
        //Constructor vacío
        public Nevera() { }
        //Constructor parametrizado
        public Nevera(string marca, string modelo, string energia, int año, string fabricacion, int capacidad) : base(marca, modelo, energia, año, fabricacion)
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
        //POLIMORFISMO DE SUBTIPO
        public override void PedirInfo()
        {
            base.PedirInfo();
            Console.WriteLine("Capacidad de la nevera:");
            int capacidad = int.Parse(Console.ReadLine());

            this.capacidad = capacidad;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Capacidad: " + capacidad);
            if (capacidad > 200)
            {
                Console.WriteLine("Nevera industrial: Sí");
            }
            else
            {
                Console.WriteLine("Nevera industriale: No");
            }
        }
        public override string EscribirInfo()
        {
            char sep = ';';
            string s = ("Nevera" + sep + marca + sep + modelo + sep + energia + sep + año + sep + fabricacion + sep + capacidad);
            return s;
        }
    }
}
