using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInstrumentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int opcion;
            bool fin = false;
            List<Instrumentos> listaInstrumentos = new List<Instrumentos>();

            try
            {
                while (!fin)
                {
                    Console.WriteLine(listaInstrumentos);
                    opcion = Menu();

                    switch (opcion)
                    {
                        case 1: // Añadir nuevo instrumento
                            int op;
                            do
                            {
                                Console.WriteLine("Inserta el instrumento que deseas añadir [1-2]:");
                                Console.WriteLine("1. Guitarra");
                                Console.WriteLine("2. Piano");
                                op = int.Parse(Console.ReadLine());
                                if (op != 1 && op != 2)
                                {
                                    Console.WriteLine("Inserta una opción entre 1 y 2.");
                                }
                            } while (op != 1 && op != 2);
                            switch (op)
                            {
                                case 1:
                                    Console.Clear();
                                    Guitarras guitarra = new Guitarras();
                                    listaInstrumentos.Add(guitarra);
                                    break;
                                case 2:
                                    Console.Clear();
                                    Pianos piano = new Pianos();
                                    listaInstrumentos.Add(piano);
                                    break;
                            }
                            break;
                        case 2:
                            Console.Clear();                            
                            bool encontrado = false;                            
                            Console.WriteLine("Inserte el número de serie del artículo que desea alquilar:");
                            string numero = Console.ReadLine();
                            foreach (Instrumentos I in listaInstrumentos)
                            {                             
                                if (numero == I.GetNumeroSerie())
                                {
                                    encontrado = true;
                                    Console.WriteLine("Instrumento alquilado!");
                                    I.SetAlquilado(true);
                                }
                            }                            
                            if (!encontrado)
                            {
                                Console.WriteLine("Lo sentimos, el número de serie es incorrecto o no existe ningún artículo con ese número.");
                            }
                            Console.ReadLine();
                            break;
                        case 3: // Mostrar instrumentos alquilados con su ubicación
                            Console.Clear();
                            bool encontrado2 = false;
                            Console.WriteLine("Instrumentos alquilados con su ubicación:");
                            foreach (Instrumentos I in listaInstrumentos)
                            {
                                if (I.GetAlquilado() == true)
                                {
                                    encontrado2 = true;                                    
                                    I.ObtenerInformacion();                                    
                                }
                            }
                            if (!encontrado2)
                            {
                                Console.WriteLine("Lo sentimos, no hay instrumentos alquilados todavía.");
                            }
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Has decidido salir del menú");
                            fin = true;
                            break;
                        default:
                            Console.WriteLine("Inserta una opción válida.");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Se ha producido un error.");
                Console.WriteLine(e.Message);
            }
        }
        public static int Menu()
        {
            int opcion;
            Console.Clear();
            Console.WriteLine("1. Nuevo instrumento");
            Console.WriteLine("2. Alquilar instrumento");
            Console.WriteLine("3. Listar instrumentos con su ubicación");
            Console.WriteLine("4. Salir");
            Console.Write("Introduzca opción: ");
            opcion = int.Parse(Console.ReadLine());
            return opcion;
        }       
    }
}

