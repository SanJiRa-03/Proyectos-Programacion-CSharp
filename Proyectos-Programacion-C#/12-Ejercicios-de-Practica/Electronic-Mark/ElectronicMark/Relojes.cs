using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicMark
{
    public class Relojes : Dispositivos
    {
        //Atributos
        private int fabricacion;
        private bool autonomia;
        //Constructores
        //Constructor vacío
        public Relojes() { }
        //Constructor parametrizado
        public Relojes(string nombreDispositivo, string modelo, string nombreFabricante, int fecha, int capacidad, int fabricacion, bool autonomia) : base(nombreDispositivo, modelo, nombreFabricante, fecha, capacidad)
        {
            this.fabricacion = fabricacion;
            this.autonomia = autonomia;
        }
        //Mutadores y accesores
        public void SetFabricacion(int fabricacion)
        {
            this.fabricacion = fabricacion;
        }
        public int GetFabricacion()
        {
            return fabricacion;
        }
        public void SetAutonomia(bool autonomia)
        {
            this.autonomia = autonomia;
        }
        public bool GetAutonomia()
        {
            return autonomia;
        }
        //Métodos
        public override void PedirInfo()
        {
            int fecha, autonomia;
            Console.WriteLine("| RELOJES |");
            base.PedirInfo();
            do
            {
                Console.WriteLine("¿Está fabricado en 2021? (1. Sí, 2. No)");
                fecha = int.Parse(Console.ReadLine());
                if (fecha != 1 && fecha != 2)
                {
                    Console.WriteLine("Por favor inserta una opción válida.");
                }

            } while (fecha != 1 && fecha != 2);
            do
            {
                Console.WriteLine("¿Tiene autonomía? (1. Sí, 2. No)");
                autonomia = int.Parse(Console.ReadLine());
                if (autonomia != 1 && autonomia != 2)
                {
                    Console.WriteLine("Por favor inserta una opción válida.");
                }
            } while (autonomia != 1 && autonomia != 2);            
        }
        public override void MostrarInfo()
        {

        }
    }
}
