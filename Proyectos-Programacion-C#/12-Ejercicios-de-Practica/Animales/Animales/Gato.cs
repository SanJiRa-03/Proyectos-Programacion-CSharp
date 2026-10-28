using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Gato : Animal
    {
        //Atributos
        private string colorPelaje;
        private int ronroneo;        
        //Constructores
        //Constructor vacío
        public Gato() { }
        //Constructor parametrizado
        public Gato(string nombre, string sonido, int tipo, string colorPelaje, int ronroneo) : base(nombre, sonido, tipo)
        {
            this.colorPelaje = colorPelaje;
            this.ronroneo = ronroneo;
        }
        //Mutadores y accesores
        public void SetColorPelaje(string colorPelaje)
        {
            this.colorPelaje = colorPelaje;
        }
        public string GetColorPelaje()
        {
            return colorPelaje;
        }
        public void SetRonroneo(int ronroneo)
        {
            this.ronroneo = ronroneo;
        }
        public int GetRonroneo()
        {
            return ronroneo;
        }
        //Métodos
        public override void MostrarInfo()
        {
            Console.WriteLine("- Gatos -");
            base.MostrarInfo();
            Console.WriteLine("Color del pelaje -> " + colorPelaje);
            Console.WriteLine("Ronroneo -> " + ronroneo);
            Console.WriteLine("\n");
        }
        public override string EscribirFichero()
        {
            char sep = ';';
            string s = ("gato" + sep + nombre + sep + sonido + sep + tipo + sep + colorPelaje + sep + ronroneo);
            return s;
        }
    }
}
