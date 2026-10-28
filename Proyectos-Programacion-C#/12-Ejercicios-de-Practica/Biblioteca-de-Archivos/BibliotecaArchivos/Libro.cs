using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaArchivos
{
    public class Libro : Archivo
    {
        //Atributos
        private int trilogia;
        //Contructores
        //Contructor vacío
        public Libro() { }
        //Constructor parametrizado
        public Libro(string titulo, string autor, string editorial, int fecha, int trilogia) : base(titulo, autor, editorial, fecha)
        {
            this.trilogia = trilogia;
        }
        //Mutadores y accesores
        public int GetTrilogia()
        {
            return trilogia;
        }
        public void SetTrilogia(int trilogia)
        {
            this.trilogia = trilogia;
        }
        //Métodos
        public override void PedirInfo()
        {
            int trilogia;
            Console.WriteLine("Insertando Libro...");
            base.PedirInfo();
            do
            {
                Console.WriteLine("¿Es una trilogía? (1. Sí 2. No)");
                trilogia = int.Parse(Console.ReadLine());
                if (trilogia != 1 && trilogia != 2)
                {
                    Console.WriteLine("Seleccione 1 para 'sí', 2 para 'no'.\n");
                }
            } while (trilogia != 1 && trilogia != 2);
            
            this.trilogia = trilogia;
        }
        public override void ImprimirInfo()
        {
            Console.WriteLine("| LIBROS |");
            base.ImprimirInfo();
            Console.WriteLine("Trilogía: " +  ObtenerTrilolgia(GetTrilogia()) + "\n");
        }
        private string ObtenerTrilolgia(int trilogia)
        {
            string respuesta;

            if (trilogia == 1)
            {
                respuesta = "Sí.";
            }
            else
            {
                respuesta = "No.";
            }                            
            return respuesta;
        }
    }
}
