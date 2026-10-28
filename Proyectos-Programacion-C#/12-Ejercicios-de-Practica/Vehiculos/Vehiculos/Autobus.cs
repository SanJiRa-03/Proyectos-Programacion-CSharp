using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Autobus : Vehiculo
    {
        protected string publico;

        public Autobus() { }
        public Autobus(string marca, string matricula, string publico) : base(marca, matricula)
        {
            this.publico = publico;
        }
        public void SetPublico(string publico)
        {
            this.publico = publico;
        }
        public string GetPublico()
        {
            return publico;
        }
        
        public override void PedirInfo()
        {
            base.PedirInfo();
            Console.WriteLine("¿Es de uso público? (s/n):");
            publico = (Console.ReadLine());
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("- AUTOBUSES -");
            base.MostrarInfo();
            if (publico == "s")
            {
                publico = "Sí.";
            }
            else
            {
                publico = "No.";
            }
            Console.WriteLine("Uso público: " + publico);
        }
        public override string EscribirFichero()
        {
            char sep = ';';
            string s = ("Autobús" + marca + sep + matricula + sep + publico);
            return s;
        }
    }
}
