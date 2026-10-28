using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{    public class Program
    {
        static List<Vehiculo> listavehiculos = new List<Vehiculo>();
        static void Main(string[] args)
        {
            //Variables
            int op;
            bool fin = false;
            
            try
            {
                while (!fin)
                {
                    //LeerFichero();                    
                    op = Menu();

                    switch (op)
                    {
                        case 1:
                            int op2;
                            Console.Clear();
                            Console.WriteLine("¿Qué vehículo deseas añadir?");
                            Console.WriteLine("1.- Moto.");
                            Console.WriteLine("2.- Coche.");
                            Console.WriteLine("3.- Autobús.");
                            op2 = int.Parse(Console.ReadLine());
                            switch (op2)
                            {
                                case 1:
                                    Moto moto = new Moto();
                                    Console.Clear();
                                    moto.PedirInfo();
                                    listavehiculos.Add(moto);
                                    break;
                                case 2:
                                    Coche coche = new Coche();
                                    Console.Clear();
                                    coche.PedirInfo();
                                    listavehiculos.Add(coche);
                                    break;
                                case 3:
                                    Autobus autobus = new Autobus();
                                    Console.Clear();
                                    autobus.PedirInfo();
                                    listavehiculos.Add(autobus);
                                    break;
                                default:
                                    Console.WriteLine("Inserta una opción válida.\n");
                                    break;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            if (listavehiculos.Count > 0)
                            {
                                foreach (Vehiculo V in listavehiculos)
                                {
                                    V.MostrarInfo();
                                    Console.WriteLine("\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay vehículos todavía.\n");
                            }
                            
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Inserta la marca del vehículo que deseas buscar:");
                            string marca = Console.ReadLine();
                            foreach (Vehiculo V in listavehiculos)
                            {
                                if (marca == V.GetMarca())
                                {
                                    V.MostrarInfo();
                                    Console.WriteLine("\n");
                                }
                                else
                                {
                                    Console.WriteLine("No hay vehículos con esa marca.\n");
                                }
                            }
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Inserta la marca del vehículo que deseas eliminar:");
                            marca = Console.ReadLine();
                            List<Vehiculo> listaAct = new List<Vehiculo>();
                            foreach (Vehiculo V in listavehiculos)
                            {
                                if (marca == V.GetMarca())
                                {
                                    Console.WriteLine("Vehículo eliminado correctamente :)\n");
                                    listaAct.Add(V);
                                }
                                else
                                {
                                    Console.WriteLine("No hay vehículos con esa marca.\n");
                                    listavehiculos = listaAct;
                                }
                            }
                            break;
                        case 5:
                            Console.Clear();
                            EscribirFichero();                            
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("Has decidido salir del menú, vuelve pronto!");
                            fin = true;
                            break;
                        default:
                            Console.WriteLine("Inserta una opción válida.\n");
                            break;
                    }
                }

            }catch (Exception ex){ Console.WriteLine(ex);}            
        }
        public static int Menu()
        {
            int op;
            Console.WriteLine("\nBienvenid@ al menú, elige una opción:");
            Console.WriteLine("1. Añadir un vehículo.");
            Console.WriteLine("2. Mostrar todos los vehículos.");
            Console.WriteLine("3. Mostrar vehículos de una marca específica.");
            Console.WriteLine("4. Eliminar un vehículo.");
            Console.WriteLine("5. Guardar los datos en un fichero.");
            Console.WriteLine("6. Salir.");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        public static void EscribirFichero()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lista.txt");
            StreamWriter sw = new StreamWriter(path);

            foreach (Vehiculo V in listavehiculos)
            {
                sw.WriteLine(V.EscribirFichero());
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
                if (datos[0] == "Moto")
                {
                    Moto moto = new Moto(datos[1], datos[2], int.Parse(datos[3])); 
                    listavehiculos.Add(moto);
                }else if (datos[0] == "Coche")
                {
                    Coche coche = new Coche(datos[1], datos[2], int.Parse(datos[3]));
                    listavehiculos.Add(coche);
                }else if (datos[0] == "Autobús")
                {
                    Autobus autobus = new Autobus(datos[1], datos[2], datos[3]);
                    listavehiculos.Add(autobus);
                }
            }
            sr.Close();

            foreach (Vehiculo V in listavehiculos)
            {
                V.MostrarInfo();
            }
        }
    }
    
}