using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Program
    {
        static List<Electrodomestico> lista = new List<Electrodomestico>();
        static void Main(string[] args)
        {
            Lavadora lavadora = new Lavadora();
            Lavavajillas lavavajillas = new Lavavajillas();
            Nevera nevera = new Nevera();
            Horno horno = new Horno();
            //Variables
            int op;
            bool fin = false;

            LeerFichero();
            while (!fin)
            {
                op = Menu();
                switch (op)
                {
                    case 1:                        
                        Console.Clear();
                        Console.WriteLine("¿Qué electrodoméstico deseas añadir?");
                        Console.WriteLine("1. Lavadora");
                        Console.WriteLine("2. Lavavajillas");
                        Console.WriteLine("3. Nevera");
                        Console.WriteLine("4. Horno");
                        int op2 = int.Parse(Console.ReadLine());
                        switch (op2)
                        {
                            case 1:
                                Console.Clear();
                                lavadora = new Lavadora();
                                lavadora.PedirInfo();
                                lista.Add(lavadora);
                                break;
                            case 2:
                                Console.Clear();
                                lavavajillas = new Lavavajillas();
                                lavavajillas.PedirInfo();
                                lista.Add(lavavajillas);
                                break;
                            case 3:
                                Console.Clear();
                                nevera = new Nevera();
                                nevera.PedirInfo();
                                lista.Add(nevera);
                                break;
                            case 4:
                                Console.Clear();
                                horno = new Horno();
                                horno.PedirInfo();
                                lista.Add(horno);
                                break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        foreach (Electrodomestico E in lista)
                        {
                            E.MostrarInfo();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        foreach (Electrodomestico E in lista)
                        {
                            if (E.GetAño() < 2023)
                            {
                                E.MostrarInfo();
                            }
                            else
                            {
                                Console.WriteLine("No hay electrodomésticos descatalogados.\n");
                            }
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Inserte la marca del electrodoméstico a buscar:");
                        string marca = Console.ReadLine();                        
                        foreach (Electrodomestico E in lista)
                        {
                            if (marca == E.GetMarca())
                            {
                                E.MostrarInfo();
                            }
                            else
                            {
                                Console.WriteLine("No hay electrodomésticos con esa marca.\n");
                            }                           
                        }
                        break;
                    case 5:
                        Console.Clear();
                        EscribirFichero();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Has decidido salir del menú, vuelve pronto.");
                        fin = true;
                        break;
                    default:
                        Console.WriteLine("Inserta una opción válida.\n");
                        break;
                }
            }
        }
        public static int Menu()
        {            
            Console.WriteLine("Bienvenid@ a la tienda de electrodomésticos!");
            Console.WriteLine("1- Introducir nuevo electrodoméstico\r\n2- Mostrar todos los electrodomésticos con su información\r\n3- Mostrar todos los electrodomésticos descatalogados\r\n4- Mostrar todos los electrodomésticos de una marca determinada.\r\n5- Guardar la info en un archivo de texto.\r\n6- Salir.");
            int op = int.Parse(Console.ReadLine());
            return op;
        }
        public static void EscribirFichero()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lista.txt");
            StreamWriter sw = new StreamWriter(path);

            foreach (Electrodomestico E in lista)
            {
                sw.WriteLine(E.EscribirInfo());
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
                if (datos[0] == "Lavadora")
                {
                    Lavadora lavadora = new Lavadora(datos[1], datos[2], datos[3], int.Parse(datos[4]), datos[5], int.Parse(datos[6]));
                    lista.Add(lavadora);

                }else if (datos[0] == "Lavavajillas")
                {
                    Lavavajillas lavavajillas = new Lavavajillas(datos[1], datos[2], datos[3], int.Parse(datos[4]), datos[5], int.Parse(datos[6]));
                    lista.Add(lavavajillas);

                }else if (datos[0] == "Nevera")
                {
                    Nevera nevera = new Nevera(datos[1], datos[2], datos[3], int.Parse(datos[4]), datos[5], int.Parse(datos[6]));
                    lista.Add(nevera);

                }else if (datos[0] == "Horno")
                {
                    Horno horno = new Horno(datos[1], datos[2], datos[3], int.Parse(datos[4]), datos[5], datos[6]);
                    lista.Add(horno);
                }
            }
            sr.Close();

            foreach (Electrodomestico E in lista)
            {
                E.MostrarInfo();
            }
        }
    }
}
