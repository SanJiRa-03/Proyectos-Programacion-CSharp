using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    public class Horno : Electrodomestico
    {
        //Atributos        
        //ENCAPSULAMIENTO
        private string autolimpiado;        
        //Constructores
        //Constructor vacío
        public Horno() { }
        //Constructor parametrizado
        public Horno(string marca, string modelo, string energia, int año, string fabricacion, string autolimpiado) : base(marca, modelo, energia, año, fabricacion)
        {          
            this.autolimpiado = autolimpiado;
        }
        //Mutadores y accesores        
        public void SetAutolimpiado(string autolimpiado)
        {
            this.autolimpiado = autolimpiado;
        }
        public string GetAutolimpiado()
        {
            return autolimpiado;
        }
        //Métodos
        //POLIMORFISMO DE SUBTIPO
        public override void PedirInfo()
        {
            base.PedirInfo();            
            Console.WriteLine("¿Tiene capacidad de autolimpiado? (s/n):");
            string autolimpiado = Console.ReadLine();

            this.autolimpiado = autolimpiado;
        }        
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Autolimpiado: " + autolimpiado);
            if (energia == "s" && autolimpiado == "s" && año >= 2019)
            {
                Console.WriteLine("Horno de últ. generación: Sí");
            }
            else
            {
                Console.WriteLine("Horno de últ. generación: No");
            }
        }
        public override string EscribirInfo()
        {
            char sep = ';';
            string s = ("Horno" + sep + marca + sep + modelo + sep + energia + sep + año + sep + fabricacion + sep + autolimpiado);
            return s;
        }
    }
}
