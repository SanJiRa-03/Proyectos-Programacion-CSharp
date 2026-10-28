using RegistroDeportistas;
using System;
using System.Collections.Generic;
using System.IO;

namespace RegistroDeportistas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            bool fin = false;
            int op = 0;            
            //Creamos la lista de deportistas y un objeto deportista que usaremos más adelante.
            List<Deportista> listaDeportistas = new List<Deportista>();            
            Deportista deportista = new Deportista();

            while (!fin)
            {
                Banner();
                if (listaDeportistas.Count < 0)
                {
                    deportista.MostrarInfo();
                }
                else
                {
                    Console.WriteLine("No hay deportistas todavía :/\n");
                }                
                op = Menu();

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        deportista = new Deportista();
                        deportista.PedirInfo();
                        listaDeportistas.Add(deportista);
                        break;
                    case 2:
                        Console.Clear();
                        //Hago un bool que se defina en true si encuentra al deportista.
                        bool encontrado = false;
                        Console.WriteLine("Inserta el nombre del deportista que deseas eliminar:");
                        string nombre = Console.ReadLine();
                        //Hacemos una nueva lista 'listaAct' que sobreescribe la lista anterior por una nueva sin el nombre del deportista eliminado.
                        List<Deportista> listaAct = new List<Deportista>();
                        //Realizamos un foreach que busque en la lista de deportistas uno que se llame igual al que ha introducido el usuario.                       
                        foreach (Deportista D in listaDeportistas)
                        {
                            // Utilizo .ToLower() para que si el usuario introduce el nombre en mayúsculas, no haya problema.
                            if (D.GetNombre().ToLower() == nombre.ToLower())
                            {
                                encontrado = true;
                            }
                            else
                            {
                                listaAct.Add(D);
                            }
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("No existe ningún deportista con ese nombre en la lista.");
                        }

                        listaDeportistas = listaAct;

                        break;
                    case 3:
                        Console.Clear();
                        bool encontrado2 = false;
                        Console.WriteLine("Inserta el nombre del deportista que deseas buscar:");
                        string name = Console.ReadLine();
                        foreach (Deportista D in listaDeportistas)
                        {
                            if (D.GetNombre().ToLower() == name.ToLower())
                            {
                                encontrado2 = true;
                                D.MostrarInfo();
                            }
                        }
                        if (!encontrado2)
                        {
                            Console.WriteLine("No existe ningún deportista con ese nombre en la lista.");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        if (listaDeportistas.Count > 0)
                        {
                            foreach (Deportista D in listaDeportistas)
                            {
                                D.MostrarInfo();
                            }
                        }
                        else
                        {
                            Console.WriteLine("La lista está vacía.");
                        }
                        break;
                    case 5:
                        Console.Clear();
                        EscribirAlArchivo(listaDeportistas);
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Has decidido salir del menú.\n");
                        fin = true;
                        break;
                }
            }
        }
        public static int Menu()
        {
            int op;
            Console.WriteLine("Bienvenid@ al menú, por favor elige una opción:");
            Console.WriteLine("1.- Añadir a un deportista.");
            Console.WriteLine("2.- Eliminar a un deportista.");
            Console.WriteLine("3.- Buscar a un deportista.");
            Console.WriteLine("4.- Mostar la información de la lista de deportistas.");
            Console.WriteLine("5.- Guardar la información en un fichero de texto.");
            Console.WriteLine("6.- Salir.");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        public static void Banner()
        {
            Console.WriteLine(" ____   ____  ____  _____  ____  _____  ____     _ ");
            Console.WriteLine("|  _ | |  __||  _ ||  _  ||  _ /|__ __||  __|   (_)");
            Console.WriteLine("| |_) ||  __|| |_||| |_| || |_|/  | |  |  __|    _ ");
            Console.WriteLine("|____/ |____||_|   |_____||_||_|  |_|  |____|   (_)\n\n");            
        }
        public static void EscribirAlArchivo(List<Deportista> deportistas)
        {
            StreamWriter sw = File.CreateText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "deportistas.txt"));
            try
            {
                foreach (Deportista D in deportistas)
                {
                    sw.WriteLine(D.GetNombre() + ':' + D.GetEdad() + ':' + D.GetAltura() + ':' + D.GetPeso());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Se ha producido un error.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Close();
            }
        }
        public static List<Deportista> LeerDelFichero()
        {
            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "deportistas.txt"))) File.Create(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "deportistas.txt")).Close();
            StreamReader sr = File.OpenText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "deportistas.txt"));
            List<Deportista> deportistas = new List<Deportista> ();
            try
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(':');
                    deportistas.Add(new Deportista(datos[0], Convert.ToInt32(datos[1]), Convert.ToDouble(datos[2]), Convert.ToDouble(datos[3])));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Se ha producido un error.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
            }
            
            return deportistas;
        }        
    }
}