using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInstrumentos
{
    public class Guitarra : Instrumentos
    {
        private int numeroCuerdas;
        private string tipoGuitarra;

        public Guitarra() { }
        public Guitarra(string marca, string modelo, string numeroSerie, bool alquilado, int latitud, int longitud, int numeroCuerdas, string tipoGuitarra) : base(marca, modelo, numeroSerie, alquilado, latitud, longitud)
        {
            this.numeroCuerdas = numeroCuerdas;
            this.tipoGuitarra = tipoGuitarra;
        }
        public void SetNumeroCuerdas(int numeroCuerdas)
        {
            this.numeroCuerdas = numeroCuerdas;
        }
        public int GetNumeroCuerdas()
        {
            return numeroCuerdas;
        }
        public void SetTipoGuitarra(string tipoGuitarra)
        {
            this.tipoGuitarra = tipoGuitarra;
        }
        public string GetTipoGuitarra()
        {
            return tipoGuitarra;
        }

        public override void PedirInfo()
        {            
            base.PedirInfo();
            Console.WriteLine("Inserte el número de cuerdas:");
            numeroCuerdas = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte el tipo de guitarra:");
            tipoGuitarra = Console.ReadLine();
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("- GUITARRAS -");
            base.MostrarInfo();
            Console.WriteLine("Número de cuerdas: " + numeroCuerdas);
            Console.WriteLine("Tipo de guitarra: " + tipoGuitarra + "\n");
        }
        public override string EscribirInfo()
        {
            char sep = ';';
            string s = ("guitarra" + sep + marca + sep + modelo + sep + numeroSerie + sep + latitud + sep + longitud + sep + numeroCuerdas + sep + tipoGuitarra);
            return s;
        }
    }
}
