using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInstrumentos
{
    public class Piano : Instrumentos
    {
        private int numeroTeclas;
        private string tipoPiano;

        public Piano() { }
        public Piano(string marca, string modelo, string numeroSerie, bool alquilado, int latitud, int longitud, int numeroTeclas, string tipoPiano) : base(marca, modelo, numeroSerie, alquilado, latitud, longitud)
        {
            this.numeroTeclas = numeroTeclas;
            this.tipoPiano = tipoPiano;
        }
        public void SetNumeroTeclas(int numeroTeclas)
        {
            this.numeroTeclas = numeroTeclas;
        }
        public int GetNumeroTeclas()
        {
            return numeroTeclas;
        }
        public void SetTipoPiano(string tipoPiano)
        {
            this.tipoPiano = tipoPiano;
        }
        public string GetTipoPiano()
        {
            return tipoPiano;
        }

        public override void PedirInfo()
        {
            base.PedirInfo();
            Console.WriteLine("Inserte el número de teclas:");
            numeroTeclas = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte el tipo de piano:");
            tipoPiano = Console.ReadLine();
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("- PIANOS -");
            base.MostrarInfo();
            Console.WriteLine("Número de teclas: " + numeroTeclas);
            Console.WriteLine("Tipo de piano: " + tipoPiano + "\n");
        }
        public override string EscribirInfo()
        {
            char sep = ';';
            string s = ("piano" + sep + marca + sep + modelo + sep + numeroSerie + sep + latitud + sep + longitud + sep + numeroTeclas + sep + tipoPiano);
            return s;
        }
    }
}
