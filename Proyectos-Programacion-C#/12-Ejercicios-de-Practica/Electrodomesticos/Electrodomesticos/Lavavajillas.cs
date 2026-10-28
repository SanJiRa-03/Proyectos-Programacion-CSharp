using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    public class Lavavajillas : Electrodomestico
    {
        //Atributos        
        //ENCAPSULAMIENTO
        private int tiempo;
        //Constructores
        //Constructor vacío
        public Lavavajillas() { }
        //Constructor parametrizado
        public Lavavajillas(string marca, string modelo, string energia, int año, string fabricacion, int tiempo) : base(marca, modelo, energia, año, fabricacion)
        {
            this.tiempo = tiempo;
        }
        //Mutadores y accesores        
        public void SetTiempo(int tiempo)
        {
            this.tiempo = tiempo;
        }
        public int GetTiempo()
        {
            return tiempo;
        }
        //Métodos
        //POLIMORFISMO DE SUBTIPO
        public override void PedirInfo()
        {
            base.PedirInfo();
            Console.WriteLine("Tiempo de lavado:");
            int tiempo = int.Parse(Console.ReadLine());

            this.tiempo = tiempo;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Tiempo de lavado: " + tiempo);
            if (tiempo < 45 && año > 2018)
            {
                Console.WriteLine("Lavavajillas sostenible: Sí");
            }
            else
            {
                Console.WriteLine("Lavavajillas sostenible: No");
            }
        }
        public override string EscribirInfo()
        {
            char sep = ';';
            string s = ("Lavavajillas" + sep + marca + sep + modelo + sep + energia + sep + año + sep + fabricacion + sep + tiempo);
            return s;
        }
    }
}
