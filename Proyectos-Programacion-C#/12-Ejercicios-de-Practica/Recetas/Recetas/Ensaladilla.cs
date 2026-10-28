using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetas
{
    public class Ensaladilla : Receta
    {
        private int numeroPatatas;
        private string mayonesa;
        public Ensaladilla() { }
        public Ensaladilla(string nombre, int dificultad, int numeroPatatas, string mayonesa) : base(nombre, dificultad)
        {
            this.numeroPatatas = numeroPatatas;
            this.mayonesa = mayonesa;
        }

        public void SetNumeroPatatass(int numeroPatatas)
        {
            this.numeroPatatas = numeroPatatas;
        }
        public int GetNumeroPatatas()
        {
            return numeroPatatas;
        }
        public void SetMayonesa(string mayonesa)
        {
            this.mayonesa = mayonesa;
        }
        public string GetMayonesa()
        {
            return mayonesa;
        }
        public override void PedirInfo()
        {
            base.PedirInfo();
            Console.WriteLine("Inserte la cantidad de patatas:");
            numeroPatatas = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Lleva mayonesa? (s/n)");
            mayonesa = Console.ReadLine();
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("- ENSALADILLAS -");
            base.MostrarInfo();
            Console.WriteLine("Cantidad de patatas: " + numeroPatatas);
            if (mayonesa == "s")
            {
                mayonesa = "Sí.";
            }
            else
            {
                mayonesa = "No.";
            }
            Console.WriteLine("Mayonesa: " + mayonesa);
        }
        public override string EscribirFichero()
        {
            char sep = ';';
            string s = ("ensaladilla" + sep + nombre + sep + dificultad + sep + numeroPatatas + sep + mayonesa);
            return s;
        }
    }
}
