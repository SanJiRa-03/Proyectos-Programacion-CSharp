using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    internal class Moto : Vehiculo
    {
        protected int ruedas;

        public Moto() { }
        public Moto(string marca, string matricula, int ruedas) : base(marca, matricula)
        {
            this.ruedas = ruedas;
        } 
        public void SetRuedas(int ruedas)
        {
            this.ruedas = ruedas;
        }
        public int GetRuedas()
        {
            return ruedas;
        }
       
        public override void PedirInfo()
        {            
            base.PedirInfo();
            Console.WriteLine("Inserte el número de ruedas de la moto:");
            ruedas = int.Parse(Console.ReadLine());
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("- MOTOS -");
            base.MostrarInfo();
            Console.WriteLine("Número de ruedas: " + ruedas);
        }
        public override string EscribirFichero()
        {
            char sep = ';';
            string s = ("Moto" + marca + sep + matricula + sep + ruedas);
            return s;
        }
    }
}
