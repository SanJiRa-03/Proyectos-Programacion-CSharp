using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Animal
    {
        //Atributos
        protected string nombre, sonido;
        protected int tipo;
        //Constructores
        //Constructor vacío
        public Animal() { }
        //Constructor parametrizado
        public Animal(string nombre, string sonido, int tipo)
        {
            this.nombre = nombre;
            this.sonido = sonido;
            this.tipo = tipo;
        }
        //Mutadores y accesores
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string Getnombre()
        {
            return nombre;
        }
        public void SetSonido(string sonido)
        {
            this.sonido = sonido;
        }
        public string GetSonido()
        {
            return sonido;
        }
        public void SetTipo(int tipo)
        {
            this.tipo = tipo;
        }
        public int GetTipo()
        {
            return tipo;
        }
        //Métodos
        public virtual void MostrarInfo()
        {
            Console.WriteLine("Nombre -> " + nombre);
            Console.WriteLine("Sonido -> " + sonido);
            Console.WriteLine("Tipo de animal -> " + tipo);
        }
        public virtual string EscribirFichero()
        {
            char sep = ';';
            string s = (nombre + sep + sonido + sep + tipo);
            return s;
        }
    }
}
