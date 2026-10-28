using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Perro : Animal
    {
        //Atributos
        private string raza;
        private int tamaño;
        //Constructores
        //Constructor vacío
        public Perro() { }
        //Constructor parametrizado
        public Perro(string nombre, string sonido, int tipo, string raza, int tamaño) : base(nombre, sonido, tipo)
        {
            this.raza = raza;
            this.tamaño = tamaño;
        }
        //Mutadores y accesores
        public void SetRaza(string raza)
        {
            this.raza = raza;
        }
        public string GetRaza()
        {
            return raza;
        }
        public void SetTamaño(int tamaño)
        {
            this.tamaño = tamaño;
        }
        public int GetTamaño()
        {
            return tamaño;
        }
        //Métodos
        public override void MostrarInfo()
        {
            Console.WriteLine("- Perros -");
            base.MostrarInfo();                   
            Console.WriteLine("Color del pelaje -> " + raza);
            Console.WriteLine("Tamaño -> " + tamaño);
            Console.WriteLine("\n");
        }
        public override string EscribirFichero()
        {
            char sep = ';';
            string s = ("perro" + sep + nombre + sep + sonido + sep + tipo + sep + raza + sep + tamaño);
            return s;
        }
    }
}
