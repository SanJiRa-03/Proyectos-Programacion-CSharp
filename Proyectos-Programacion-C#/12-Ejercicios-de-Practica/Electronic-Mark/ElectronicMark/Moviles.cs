using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicMark
{
    public class Moviles : Dispositivos
    {

        //Atributos
        private int numCamaras;
        private bool apple;
        //Constructores
        //Constructor vacío
        public Moviles() { }
        //Constructor parametrizado
        public Moviles(string nombreDispositivo, string modelo, string nombreFabricante, int fecha, int capacidad, int numCamaras, bool apple) : base(nombreDispositivo, modelo, nombreFabricante, fecha, capacidad)
        {
            this.numCamaras = numCamaras;
            this.apple = apple;
        }
        //Mutadores y accesores
        public void SetCamaras(int numCamaras)
        {
            this.numCamaras = numCamaras;
        }
        public int GetCamaras()
        {
            return numCamaras;
        }
        public void SetApple(bool apple)
        {
            this.apple = apple;
        }
        public bool GetApple()
        {
            return apple;
        }
        //Métodos
        public override void PedirInfo()
        {
            int apple;
            Console.WriteLine("| MÓVILES |");
            base.PedirInfo();            
            Console.WriteLine("Inserte el número de cámaras que tiene:");
            int numCamaras = int.Parse(Console.ReadLine());            
            do
            {
                Console.WriteLine("¿Su marca es Apple? (1. Sí, 2. No)");
                apple = int.Parse(Console.ReadLine());
                if (apple != 1 && apple != 2)
                {
                    Console.WriteLine("Por favor inserta una opción válida.");
                }
            } while (apple != 1 && apple != 2);
        }
        public override void MostrarInfo()
        {

        }
    }
}
