using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeElectrodomesticos
{
    public class Lavadoras : Electrodomésticos
    {
        //Atributos        
        private int programas;        
        //Constructores
        //Constructor vacío
        public Lavadoras() { }
        //Constructor parametrizado
        public Lavadoras(string marca, string modelo, int año, string energia, bool fabricado, int programas) : base(marca, modelo, año, energia, fabricado)
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
        public string Inteligente(int programas, string energia)
        {
            string inteligente;
            if (programas > 3 && energia == "s")
            {
                inteligente = "sí";
            }
            else
            {
                inteligente = "no";
            }
            return inteligente;
        }
        public override void PedirInfo()
        {
            base.PedirInfo();
            Console.WriteLine("¿Cuántos programas tiene?");
            int programas = int.Parse(Console.ReadLine());

            this.programas = programas;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("| Lavadoras |");
            base.MostrarInfo();
            Console.WriteLine("Número de programas: " + GetProgramas());
            Console.WriteLine("Inteligente: " + Inteligente(GetProgramas(), GetEnergia()));
        }

    }
}
