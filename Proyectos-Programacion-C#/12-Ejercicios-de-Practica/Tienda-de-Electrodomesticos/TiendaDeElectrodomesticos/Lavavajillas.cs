using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeElectrodomesticos
{
    public class Lavavajillas : Electrodomésticos
    {
        //Atributos        
        private int tiempo;
        //Constructores
        //Constructor vacío
        public Lavavajillas() { }
        //Constructor parametrizado
        public Lavavajillas(string marca, string modelo, int año, string energia, bool fabricado, int tiempo) : base(marca, modelo, año, energia, fabricado)
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
        public string Sostenible(int tiempo, int año)
        {
            string sostenible;
            if (tiempo < 45 && año > 2018)
            {
                sostenible = "sí";
            }
            else
            {
                sostenible = "no";
            }
            return sostenible;
        }
        public override void PedirInfo()
        {
            base.PedirInfo();
            Console.WriteLine("¿Cuántos programas tiene?");
            int tiempo = int.Parse(Console.ReadLine());

            this.tiempo = tiempo;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("| Lavavajillas |");
            base.MostrarInfo();
            Console.WriteLine("Tiempo de lavado: " + GetTiempo());
            Console.WriteLine("Sostenible: " + Sostenible(GetTiempo(), GetAño()));
        }
    }
}
