using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables

            int op;
            bool fin = false;

            List<Archivo> lista = new List<Archivo>();            

            while (!fin)
            {
                try
                {
                    op = Menu();

                    switch (op)
                    {
                        case 1:
                            //Variables
                            int op1 = 0;
                            Console.Clear();
                            do
                            {
                                Console.WriteLine("¿Qué archivo deseas añadir a la biblioteca?\n");
                                Console.WriteLine("1. Libro");
                                Console.WriteLine("2. Revista");
                                op1 = int.Parse(Console.ReadLine());
                            } while (op1 != 1 && op1 != 2);
                            switch (op1)
                            {
                                case 1:
                                    Console.Clear();
                                    Libro libro = new Libro();
                                    libro.PedirInfo();
                                    lista.Add(libro);
                                    break;
                                case 2:
                                    Console.Clear();                                   
                                    Revista revista = new Revista();
                                    revista.PedirInfo();
                                    lista.Add(revista);
                                    break;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            foreach (Archivo archivos in lista)
                            {
                                if (lista.Count > 0)
                                {
                                    archivos.ImprimirInfo();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("No hay archivos guardados en la biblioteca.\n");
                                }
                            }
                            break;
                        case 3:

                            Console.Clear();
                            Console.WriteLine("Inserta el autor que desea buscar:");
                            string autor = Console.ReadLine();
                            foreach (Archivo archivos in lista)
                            {
                                if (autor == archivos.GetAutor())
                                {
                                    archivos.ImprimirInfo();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("No hay archivos guardados de ese autor en la biblioteca.\n");
                                }
                            }
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Inserta el autor del archivo que desea eliminar:");
                            autor = Console.ReadLine();
                            foreach (Archivo archivos in lista)
                            {
                                if (autor == archivos.GetAutor())
                                {
                                    lista.Remove(archivos);
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("No hay archivos guardados de ese autor en la biblioteca.\n");
                                }
                            }
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Informe de la biblioteca:");
                            Console.WriteLine("- Número total de archivos: " + lista.Count);
                            int numLibros = 0;
                            int numRevistas = 0;
                            foreach (Archivo archivo in lista)
                            {
                                if (archivo is Libro)
                                {
                                    numLibros++;
                                }
                                else if (archivo is Revista)
                                {
                                    numRevistas++;
                                }
                            }
                            Console.WriteLine("- Número de libros: " + numLibros);
                            Console.WriteLine("- Número de revistas: " + numRevistas);
                            break;
                        case 6:
                            fin = true;
                            Console.Clear();
                            Console.WriteLine("Has decidido salir del menú.\n");
                            break;
                            default: Console.WriteLine("Por favor inserta una opción válida.\n");
                            break;
                    }
                }catch (Exception ex) { Console.WriteLine(ex.Message + "\nPresione cualquier tecla para volver al menú"); Console.ReadKey(); Console.Clear(); }
            }            
        }        
        public static int Menu()
        {
            int op = 0;
            Console.WriteLine("Bienvenid@ al menú, por favor, elige una opción [1-6]\n");
            Console.WriteLine("1. Agregar un nuevo archivo a la biblioteca.");
            Console.WriteLine("2. Mostrar la información de todos los archivos en la biblioteca.");
            Console.WriteLine("3. Buscar un archivo en particular por su título o autor.");
            Console.WriteLine("4. Eliminar un archivo de la biblioteca.");
            Console.WriteLine("5. Mostrar un informe con estadísticas de la biblioteca.");
            Console.WriteLine("6. Salir");
            op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}
