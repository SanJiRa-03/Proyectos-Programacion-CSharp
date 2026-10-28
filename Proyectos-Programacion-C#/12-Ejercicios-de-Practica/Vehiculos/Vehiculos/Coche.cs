using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Coche : Vehiculo
    {
        private int puertas;

        public Coche() { }
        public Coche(string marca, string matricula, int puertas) : base(marca, matricula)
        {
            this.puertas = puertas;
        }
        public void SetPuertas(int puertas)
        {
            this.puertas = puertas;
        }
        public int GetPuertas()
        {
            return puertas;
        }
       
        public override void PedirInfo()
        {
            base.PedirInfo();
            Console.WriteLine("Inserte el número de puertas que tiene el coche:");
            puertas = int.Parse(Console.ReadLine());
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("- COCHES -");
            base.MostrarInfo();
            Console.WriteLine("Número de puertas: " + puertas);
        }
        public override string EscribirFichero()
        {
            char sep = ';';
            string s = ("Coche" + marca + sep + matricula + sep + puertas);
            return s;
        }
    }
}
