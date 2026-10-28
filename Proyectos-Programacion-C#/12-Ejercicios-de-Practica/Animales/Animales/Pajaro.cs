using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Pajaro : Animal
    {
        //Atributos
        private string especie;
        private int nido;
        //Constructores
        //Constructor vacío
        public Pajaro() { }
        //Constructor parametrizado
        public Pajaro(string nombre, string sonido, int tipo, string especie, int nido) : base(nombre, sonido, tipo)
        {
            this.especie = especie;
            this.nido = nido;
        }
        //Mutadores y accesores
        public void SetEspecie(string especie)
        {
            this.especie = especie;
        }
        public string GetEspecie()
        {
            return especie;
        }
        public void SetNido(int nido)
        {
            this.nido = nido;
        }
        public int GetNido()
        {
            return nido;
        }
        //Métodos
        public override void MostrarInfo()
        {
            Console.WriteLine("- Pájaros -");
            base.MostrarInfo();
            Console.WriteLine("Especie -> " + especie);
            Console.WriteLine("Nido -> " + nido);
            Console.WriteLine("\n");
        }
        public override string EscribirFichero()
        {
            char sep = ';';
            string s = ("pajaro" + sep + nombre + sep + sonido + sep + tipo + sep + especie + sep + nido);
            return s;
        }
    }
}
