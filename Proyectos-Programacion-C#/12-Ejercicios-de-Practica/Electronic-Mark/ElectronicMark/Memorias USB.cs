using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicMark
{
    public class Memorias_USB : Dispositivos
    {
        //Atributos        
        private int USB_C;
        private string tera;
        //Constructores
        //Constructor vacío
        public Memorias_USB() { }
        //Constructor parametrizado
        public Memorias_USB(string nombreDispositivo, string modelo, string nombreFabricante, int fecha, int capacidad, int USB_C, string tera) : base(nombreDispositivo, modelo, nombreFabricante, fecha, capacidad)
        {           
            this.USB_C = USB_C;
            this.tera = tera;
        }
        //Mutadores y accesores
        public void SetUSBC(int USB_C)
        {
            this.USB_C = USB_C;
        }
        public int GetUSB_C()
        {
            return USB_C;
        }
        public void SetTera(string tera)
        {
            this.tera = tera;
        }
        public string GetTera()
        {
            return tera;
        }
        //Métodos
        public override void PedirInfo()
        {
            int USB_C;
            string tera;
            Console.WriteLine("| MEMORIAS USB |");
            base.PedirInfo();
            do
            {
                Console.WriteLine("¿Es USB tipo C? (1. Sí, 2. No)");
                USB_C = int.Parse(Console.ReadLine());
                if (USB_C != 1 && USB_C != 2)
                {
                    Console.WriteLine("Por favor inserta una opción válida.");
                }

            } while (USB_C != 1 && USB_C != 2);
            
            Console.WriteLine("Inserte su capacidad en GB:");
            int capacidad = int.Parse(Console.ReadLine());
            if (capacidad >= 1000)
            {
                tera = "Sí";
            }
            else
            {
                tera = "No";
            }
        }
        public override void MostrarInfo()
        {

        }
    }
}
