using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetas
{
    class Program
    {
        static List<Receta> listaRecetas = new List<Receta>();
        static void Main(string[] args)
        {
            int op;
            bool fin = false;

            Tortilla tortilla = new Tortilla();
            Ensaladilla ensaladilla = new Ensaladilla();
            Gazpacho gazpacho = new Gazpacho();

            try
            {
                while (!fin)
                {
                    op = Menu();

                    switch (op)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("¿Qué receta deseas añadir?");
                            Console.WriteLine("1.- Tortilla de patatas.");
                            Console.WriteLine("2.- Ensaladilla rusa.");
                            Console.WriteLine("3.- Gazpacho.");
                            int op2 = int.Parse(Console.ReadLine());

                            switch (op2)
                            {
                                case 1:
                                    Console.Clear();
                                    tortilla = new Tortilla();
                                    tortilla.PedirInfo();
                                    listaRecetas.Add(tortilla);
                                    break;
                                case 2:
                                    Console.Clear();
                                    ensaladilla = new Ensaladilla();
                                    ensaladilla.PedirInfo();
                                    listaRecetas.Add(ensaladilla);
                                    break;
                                case 3:
                                    Console.Clear();
                                    gazpacho = new Gazpacho();
                                    gazpacho.PedirInfo();
                                    listaRecetas.Add(gazpacho);
                                    break;
                                default:
                                    Console.WriteLine("Inserta una opción válida.\n");
                                    break;
                            }
                            break;
                        case 2:
                            bool encontrado = false;
                            Console.Clear();
                            Console.WriteLine("Inserte el nombre de la receta a buscar:");
                            string nombre = Console.ReadLine();
                            foreach (Receta R in listaRecetas)
                            {
                                if (nombre == R.GetNombre())
                                {
                                    R.MostrarInfo();
                                    encontrado = true;
                                }                                
                            }
                            if (!encontrado)
                            {
                                Console.WriteLine("No hay recetas con ese nombre :/\n");
                            }
                            break;
                        case 3:
                            bool encontrado1 = false;
                            Console.Clear();
                            Console.WriteLine("Inserte el nombre de la receta que desea eliminar:");
                            nombre = Console.ReadLine();
                            int recetasEliminadas = listaRecetas.RemoveAll(R => R.GetNombre() == nombre);

                            if (recetasEliminadas > 0)
                            {
                                Console.WriteLine("Receta eliminada con éxito!\n");
                            }
                            else
                            {
                                Console.WriteLine("No hay recetas con ese nombre.\n");
                            }
                            break;
                        case 4:       
                            bool encontrado2 = false;
                            Console.Clear();
                            Console.WriteLine("Inserte el ingrediente que incluye la receta: (huevos/cebolla, mayonesa/patata, tomate/ajo)");
                            string ingrediente = Console.ReadLine();
                            foreach (Receta R in listaRecetas)
                            {
                                if (ingrediente == "huevos" || ingrediente == "cebolla")
                                {
                                    tortilla.MostrarInfo();
                                    encontrado2 = true;
                                }else if(ingrediente == "mayonesa" || ingrediente == "patata")
                                {
                                    ensaladilla.MostrarInfo();
                                    encontrado2 = true;
                                }else if (ingrediente == "tomate" || ingrediente == "ajo")
                                {
                                    gazpacho.MostrarInfo();
                                    encontrado2 = true;
                                }
                            }
                            if (!encontrado2)
                            {
                                Console.WriteLine("No hay recetas que incluyan ese ingrediente.\n");
                            }
                            break;
                        case 5:
                            Console.Clear();
                            if (listaRecetas.Count > 0)
                            {
                                foreach (Receta R in listaRecetas)
                                {
                                    R.MostrarInfo();
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay recetas todavía.\n");
                            }
                            break;
                        case 6:
                            Console.Clear();
                            EscribirFichero();
                            //LeerFichero();
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("Has decidido salir del menú, hasta pronto!");
                            fin = true;
                            break;
                            default: 
                            Console.WriteLine("Inserta una opción válida.\n");
                            break;
                    }
                }

            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static int Menu()
        {
            int op = 0;
            Console.WriteLine("Bienvenid@ al menú, escoge una opción:");
            Console.WriteLine("1.- Añadir receta.");
            Console.WriteLine("2.- Buscar receta por nombre.");
            Console.WriteLine("3.- Eliminar receta.");
            Console.WriteLine("4.- Mostrar recetas de un ingrediente en concreto.");
            Console.WriteLine("5.- Mostrar todas las recetas.");
            Console.WriteLine("6.- Guardar la info en un fichero de texto.");
            Console.WriteLine("7.- Salir");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        public static void EscribirFichero()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lista.txt");
            StreamWriter sw = new StreamWriter(path);

            foreach (Receta R in listaRecetas)
            {
                sw.WriteLine(R.EscribirFichero());
            }
            sw.Close();
        }
        public static void LeerFichero()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lista.txt");
            if (!File.Exists(path)) File.Create(path).Close();
            StreamReader sr = new StreamReader(path);

            char sep = ';';
            string linea;

            while ((linea = sr.ReadLine()) != null)
            {
                string[] datos = linea.Split(sep);
                if (datos[0] == "tortilla")
                {
                    Tortilla tortilla = new Tortilla(datos[1], int.Parse(datos[2]), int.Parse(datos[3]), datos[4]);

                }
                else if (datos[0] == "ensaladilla")
                {
                    Ensaladilla ensaladilla = new Ensaladilla(datos[1], int.Parse(datos[2]), int.Parse(datos[3]), datos[4]);
                }
                else if (datos[0] == "gazpacho")
                {
                    Gazpacho gazpacho = new Gazpacho(datos[1], int.Parse(datos[2]), int.Parse(datos[3]), datos[4]);
                }
            }
            sr.Close();

            foreach (Receta R in listaRecetas)
            {
                R.MostrarInfo();
            }
        }
    }
}