using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetas
{
    public class Receta
    {
        protected string nombre;
        protected int dificultad;

        public Receta() { }
        public Receta(string nombre, int dificultad)
        {
            this.nombre = nombre;
            this.dificultad = dificultad;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetDificultad(int dificultad)
        {
            this.dificultad = dificultad;
        }
        public int GetDificultad()
        {
            return dificultad;
        }
        public virtual void PedirInfo()
        {
            Console.WriteLine("Inserte el nombre de la receta:");
            nombre = Console.ReadLine();
            Console.WriteLine("¿Cuál es su dificultad?:");
            Console.WriteLine("1- Fácil\n2- Medio\n3- Difícil");
            dificultad = int.Parse(Console.ReadLine());
        }
        public virtual void MostrarInfo()
        {
            Console.WriteLine("Nombre de la receta: " + nombre);
            if (dificultad == 1)
            {
                Console.WriteLine("Dificultad de la receta: Fácil.");
            }
            else if(dificultad == 2)
            {
                Console.WriteLine("Dificultad de la receta: Medio.");
            }
            else
            {
                Console.WriteLine("Dificultad de la receta: Difícil.");
            }            
        }
        public virtual string EscribirFichero()
        {
            char sep = ';';
            string s = (nombre + sep + dificultad);
            return s;
        }
    }
}