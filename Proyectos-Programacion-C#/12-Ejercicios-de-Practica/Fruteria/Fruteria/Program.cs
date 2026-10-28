using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string[]> listaUsuarios = new List<string[]>();
            List<Productos> listaProductos = new List<Productos>();
            Productos productos = new Productos();

            //Variables
            bool fin = false, registrado = false;
            int op = 0;

            //LeerDelFichero();
            while(!registrado)
            {                
                if (Login(listaUsuarios) == true)
                {
                    while (!fin)
                    {
                        op = Menu();
                        switch (op)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Bienvenid@ a tu cesta:");
                                productos = new Productos();
                                productos.PedirInfo();
                                listaProductos.Add(productos);
                                break;
                            case 2:
                                Console.Clear();
                                if (listaProductos.Count > 0)
                                {
                                    foreach (Productos P in listaProductos)
                                    {
                                        P.MostrarInfo();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No hay productos guardados todavía.\n");
                                }                                
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Inserte el nombre del producto que deseas buscar:");
                                string nombre = Console.ReadLine();
                                bool encontrado = false;
                                foreach (Productos P in listaProductos)
                                {
                                    if (nombre == P.GetNombre())
                                    {
                                        P.MostrarInfo();
                                        encontrado = true;
                                    }
                                }
                                if (!encontrado)
                                {
                                    Console.WriteLine("No se encontró ese producto.\n");
                                }
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Inserte el ID del producto que deseas eliminar:");
                                string id = Console.ReadLine();
                                bool productoEncontrado = false;

                                List<Productos> nuevaListaProductos = new List<Productos>();
                                foreach (Productos P in listaProductos)
                                {
                                    if (id == P.GetId())
                                    {
                                        productoEncontrado = true;
                                    }
                                    else
                                    {
                                        nuevaListaProductos.Add(P);
                                    }
                                }

                                if (productoEncontrado)
                                {
                                    listaProductos = nuevaListaProductos;
                                    Console.WriteLine("El producto ha sido eliminado correctamente.\n");
                                }
                                else
                                {
                                    Console.WriteLine("No hay productos con ese ID.\n");
                                }
                                break;

                            case 5:
                                Console.Clear();
                                Console.WriteLine("Has decidido salir del menú, vuelve pronto!\n");                                
                                fin = true;
                                break;
                        }
                    }
                    registrado = true; // el usuario ha salido del menú: termina el programa
                }
            }                              
        }
        public static bool Login(List<string[]> listaUsuarios)
        {            
            bool registrado = false;
            
            Console.WriteLine("¿Estás registrado ya? (s/n)");
            string r = Console.ReadLine();
            if (r == "s")
            {
                Console.WriteLine("Inserte su usuario y contraseña:");
                Console.WriteLine("Usuario: ");
                string nombreUsuario = Console.ReadLine();
                Console.WriteLine("Contraseña: ");
                string contraseña = Console.ReadLine();
                foreach (string[] usuario in listaUsuarios)
                {
                    if (usuario[0] == nombreUsuario && usuario[1] == contraseña)
                    {
                        registrado = true;
                        Console.Clear();
                        Console.WriteLine("Bienvenid@ " + nombreUsuario);                        
                    }
                }
                if (!registrado)
                {
                    Console.WriteLine("Los datos no coinciden o no existe ese usuario :/");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Inserte un nombre de usuario y una contraseña:");
                Console.WriteLine("Usuario: ");
                string nombreUsuario = Console.ReadLine();
                Console.WriteLine("Contraseña: ");
                string contraseña = Console.ReadLine();
                string[] usuario = new string[2]; 
                usuario[0] = nombreUsuario; 
                usuario[1] = contraseña;
                listaUsuarios.Add(usuario);                
            }
            return registrado;
        }

        public static int Menu()
        {
            int op = 0;
            Console.WriteLine("Bienvenid@ al menú, escoge una opción:");
            Console.WriteLine("1.- Añadir un producto a la cesta.");
            Console.WriteLine("2.- Mostrar todos los productos.");
            Console.WriteLine("3.- Buscar un producto en la cesta.");
            Console.WriteLine("4.- Eliminar un producto de la cesta.");            
            Console.WriteLine("5.- Salir.");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        public static void EscribirAlArchivo(List<Usuarios> usuarios)
        {
            StreamWriter sw = File.CreateText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "listaUsuarios.txt"));
            try
            {
                foreach (Usuarios U in usuarios)
                {
                    sw.WriteLine(U.GetNombreUsuario() + ':' + U.GetContraseña());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ha producido un error");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sw.Close();
            }
        }

        public static List<Usuarios> LeerDelFichero()
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "listaUsuarios.txt"))) File.Create(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "listaUsuarios.txt")).Close();
            StreamReader sr = File.OpenText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "listaUsuarios.txt"));
            try
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(':');
                    usuarios.Add(new Usuarios(datos[0], datos[1]));
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
            return usuarios;
        }
    }
}
