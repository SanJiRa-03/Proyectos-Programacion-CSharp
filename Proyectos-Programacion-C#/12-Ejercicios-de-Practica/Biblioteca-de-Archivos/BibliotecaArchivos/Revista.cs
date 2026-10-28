using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaArchivos
{
    public class Revista : Archivo
    {
        //Atributos
        private int id;
        //Constructores
        //Constructor vacío
        public Revista() { }
        //Constructor parametrizado
        public Revista(string titulo, string autor, string editorial, int fecha, int id) : base(titulo, autor, editorial, fecha)
        {
            this.id = id;
        }
        //Mutadores y accesores
        public int GetID()
        {
            return id;
        }
        public void SetID(int id)
        {
            this.id = id;
        }
        //Métodos
        public override void PedirInfo()
        {
            Console.WriteLine("Insertando Revista...");
            base.PedirInfo();
            Console.WriteLine("Inserta su ID: ");
            int id = int.Parse(Console.ReadLine());

            this.id = id;
        }
        public override void ImprimirInfo()
        {
            Console.WriteLine("| REVISTAS |");
            base.ImprimirInfo();
            Console.WriteLine("ID: " + GetID() + "\n");            
        }
    }
}