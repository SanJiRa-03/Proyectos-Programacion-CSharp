using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    public class Lavadora : Electrodomestico
    {
        //Atributos        
        //ENCAPSULAMIENTO
        private int programas;
        //Constructores
        //Constructor vacío
        public Lavadora() { }
        //Constructor parametrizado
        public Lavadora(string marca, string modelo, string energia, int año, string fabricacion, int programas) : base(marca, modelo, energia, año, fabricacion)
        {
            this.programas = programas;
        }
        //Mutadores y accesores        
        public void SetProgramas(int programas)
        {
            this.programas = programas;
        }
        public int GetProgramas()
        {
            return programas;
        }
        //Métodos
        //POLIMORFISMO DE SUBTIPO
        public override void PedirInfo()
        {
            base.PedirInfo();
            Console.WriteLine("Cantidad de programas:");
            int programas = int.Parse(Console.ReadLine());

            this.programas = programas;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Programas: " + programas);
            if (energia == "s" && programas > 3)
            {
                Console.WriteLine("Lavadora inteligente: Sí");
            }
            else
            {
                Console.WriteLine("Lavadora inteligente: No");
            }
        }
        public override string EscribirInfo()
        {
            char sep = ';';
            string s = ("Lavadora" + sep + marca + sep + modelo + sep + energia + sep + año + sep + fabricacion + sep + programas);
            return s;
        }
    }
}
