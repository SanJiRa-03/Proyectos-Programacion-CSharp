using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetas
{
    public class Gazpacho : Receta
    {
        private int numeroTomates;
        private string ajo;
        public Gazpacho() { }
        public Gazpacho(string nombre, int dificultad, int numeroTomates, string ajo) : base(nombre, dificultad)
        {
            this.numeroTomates = numeroTomates;
            this.ajo = ajo;
        }

        public void SetNumerotomates(int numeroTomates)
        {
            this.numeroTomates = numeroTomates;
        }
        public int GetNumeroTomates()
        {
            return numeroTomates;
        }
        public void SetAjo(string ajo)
        {
            this.ajo = ajo;
        }
        public string GetAjo()
        {
            return ajo;
        }
        public override void PedirInfo()
        {
            base.PedirInfo();
            Console.WriteLine("Inserte la cantidad de tomates:");
            numeroTomates = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Lleva ajo? (s/n)");
            ajo = Console.ReadLine();
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("- GAZPACHOS -");
            base.MostrarInfo();
            Console.WriteLine("Cantidad de tomates: " + numeroTomates);
            if (ajo == "s")
            {
                ajo = "Sí.";
            }
            else
            {
                ajo = "No.";
            }
            Console.WriteLine("Ajo: " + ajo);
        }
        public override string EscribirFichero()
        {
            char sep = ';';
            string s = ("gazpacho" + sep + nombre + sep + dificultad + sep + numeroTomates + sep + ajo);
            return s;
        }
    }
}
