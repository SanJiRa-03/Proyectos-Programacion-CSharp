using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetas
{
    public class Tortilla : Receta
    {
        private int numeroHuevos;
        private string cebolla;
        public Tortilla() { }
        public Tortilla(string nombre, int dificultad, int numeroHuevos, string cebolla) : base(nombre, dificultad)
        {
            this.numeroHuevos = numeroHuevos;
            this.cebolla = cebolla;
        }

        public void SetNumeroHuevos(int numeroHuevos)
        {
            this.numeroHuevos = numeroHuevos;
        }
        public int GetNumeroHuevos()
        {
            return numeroHuevos;
        }
        public void SetCebolla(string cebolla)
        {
            this.cebolla = cebolla;
        }
        public string GetCebolla()
        {
            return cebolla;
        }
        public override void PedirInfo()
        {
            base.PedirInfo();
            Console.WriteLine("Inserte la cantidad de huevos:");
            numeroHuevos = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Lleva cebolla? (s/n)");
            cebolla = Console.ReadLine();
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("- TORTILLAS -");
            base.MostrarInfo();
            Console.WriteLine("Cantidad de huevos: " + numeroHuevos);
            if (cebolla == "s")
            {
                cebolla = "Sí.";
            }
            else
            {
                cebolla = "No.";
            }
            Console.WriteLine("Cebolla: " + cebolla);
        }
        public override string EscribirFichero()
        {
            char sep = ';';
            string s = ("tortilla" + sep + nombre + sep + dificultad + sep + numeroHuevos + sep + cebolla);
            return s;
        }
    }
}
