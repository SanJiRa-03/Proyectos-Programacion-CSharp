using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Publicaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int op = 0;         
            bool fin = false;
            //Ficheros
            List<Publicacion> lista = new List<Publicacion>();
            lista = LeerDelArchivo();
            
           
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
                                Console.WriteLine("¿Qué publicación deseas añadir?");
                                Console.WriteLine("1. Libro");
                                Console.WriteLine("2. Revista");
                                op1 = int.Parse(Console.ReadLine());
                                if (op1 != 1 && op1 != 2)
                                {
                                    Console.WriteLine("Por favor inserta una opción correcta.\n");
                                }
                            } while (op1 != 1 && op1 != 2);
                            switch (op1)
                            {
                                case 1:                                    
                                    Libro libro = new Libro();
                                    libro.PedirInfo();
                                    lista.Add(libro);
                                    break;
                                case 2:                                    
                                    Revista revista = new Revista();
                                    revista.PedirInfo();
                                    lista.Add(revista);
                                    break;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            if (lista.Count > 0)
                            {
                                foreach (Publicacion publicacion in lista)
                                {
                                    publicacion.MostrarInfo();
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay publicaciones guardadas.\n");
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Inserta el título de la publicación que deseas buscar:");
                            string titulo = Console.ReadLine();
                            bool encontrada = false;
                            foreach (Publicacion publicaciones in lista)
                            {
                                if (titulo == publicaciones.GetTitulo())
                                {
                                    encontrada = true;
                                    publicaciones.MostrarInfo();
                                }                                
                            }
                            if(!encontrada)
                            {
                                Console.WriteLine("No hay publicaciones guardadas con ese nombre.\n");
                            }
                            break;
                        case 4:
                            Console.Clear();
                            EscribirAlArchivo(lista);                            
                            break;
                        case 5:
                            Console.WriteLine("Has decidido salir del menú.\n");
                            fin = true;
                            break;
                        default:
                            Console.WriteLine("Opción no válida, inténtalo de nuevo.\n");
                            break;
                    }
                }catch (Exception ex) {Console.WriteLine("Pulsa una tecla para continuar...");}                
            }
        }                       
        public static int Menu()
        {
            int op = 0;
            Console.WriteLine("Bienvenid@ al menú, por favor elige una opción:");
            Console.WriteLine("1. Añadir una publicación.");
            Console.WriteLine("2. Listar publicaciones.");
            Console.WriteLine("3. Mostrar la información de una publicación.");
            Console.WriteLine("4. Guardar los datos en un fichero.");
            Console.WriteLine("5. Salir");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        public static void EscribirAlArchivo(List<Publicacion> ListaPublicaciones)
        {
            StreamWriter sw = File.CreateText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ListaPublicaciones.txt"));
            try
            {
                foreach (Publicacion P in ListaPublicaciones)
                {
                    sw.WriteLine(P.GetTitulo() + ':' + P.GetEditorial() + ':' + P.GetPaginas());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ha producido un error.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sw.Close();
            }
        }
        public static List<Publicacion> LeerDelArchivo()
        {
            List<Publicacion> lista = new List<Publicacion>();
            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ListaPublicaciones.txt"))) File.Create(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ListaPublicaciones.txt")).Close();
            StreamReader sr = File.OpenText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ListaPublicaciones.txt"));
            try
            {
                string linea = "";
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(':');                   
                    lista.Add(new Libro(datos[0], datos[1], Convert.ToInt32(datos[2]), datos[3], Convert.ToInt32(datos[4])));
                    lista.Add(new Revista(datos[0], datos[1], Convert.ToInt32(datos[2]), Convert.ToInt32(datos[3]), Convert.ToInt32(datos[4])));
                }                              
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ha producido un error.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr.Close();
            }
            return lista;
        }
    }
}
