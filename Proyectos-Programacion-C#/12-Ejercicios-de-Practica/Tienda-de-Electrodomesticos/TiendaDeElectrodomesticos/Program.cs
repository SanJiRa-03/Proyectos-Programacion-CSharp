using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeElectrodomesticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Electrodomésticos> lista = new List<Electrodomésticos>();
            Electrodomésticos electrodomesticos = new Electrodomésticos();
            Lavadoras lavadoras = new Lavadoras();
            Lavavajillas lavavajillas = new Lavavajillas();
            Hornos hornos = new Hornos();
            Neveras neveras = new Neveras();

            //Variables
            int op = 0;
            bool fin = false;

            while (!fin)
            {
                op = Menu();

                switch (op)
                {
                    case 1:
                        int op2 = 0;
                        Console.Clear();
                        Console.WriteLine("¿Qué tipo de electrodoméstico deseas añadir?");
                        Console.WriteLine("1.- Lavadora.");
                        Console.WriteLine("2.- Lavavajillas.");
                        Console.WriteLine("3.- Horno.");
                        Console.WriteLine("4.- Nevera.");
                        op2 = int.Parse(Console.ReadLine());
                        switch (op2)
                        {
                            case 1:
                                Console.Clear();
                                lavadoras = new Lavadoras();
                                lavadoras.PedirInfo();
                                lista.Add(lavadoras);
                                break;
                            case 2:
                                Console.Clear();
                                lavavajillas = new Lavavajillas();
                                lavavajillas.PedirInfo();
                                lista.Add(lavavajillas);
                                break;
                            case 3:
                                Console.Clear();
                                hornos = new Hornos();
                                hornos.PedirInfo();
                                lista.Add(hornos);
                                break;
                            case 4:
                                Console.Clear();
                                neveras = new Neveras();
                                neveras.PedirInfo();
                                lista.Add(neveras);
                                break;
                                default: Console.WriteLine("Por favor elige una opción válida.");
                                break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        foreach (Electrodomésticos e in lista)
                        {
                            e.MostrarInfo();
                        }                        
                        if(lista.Count <= 0)
                        {
                            Console.WriteLine("No hay ningún electrodoméstico guardado todavía :/");
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        foreach (Electrodomésticos e in lista)
                        {
                            if (e.GetFabricado() == false)
                            {
                                e.MostrarInfo();
                            }
                        }
                        break;
                    case 4:
                        Console.Clear();
                        bool encontrado = false;
                        Console.WriteLine("Inserte la marca del electrodoméstico a buscar:");
                        string marca = Console.ReadLine();                        
                        foreach (Electrodomésticos electrodomésticos in lista)
                        {
                            if(marca == electrodomesticos.GetMarca())
                            {
                                encontrado = true;
                                electrodomésticos.MostrarInfo();
                            }                                                      
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("No hay electrodomésticos registrados con esa marca.");
                        }
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Has decidido salir del menú.");
                        fin = true;
                        break;
                    default:
                        Console.WriteLine("Por favor elige una opción válida.");
                        break;
                }
            }
        }
        public static int Menu()
        {
            int op = 0;
            Console.WriteLine("Bienvenid@ al menú, elige una opción:");
            Console.WriteLine("1.- Insertar electrodoméstico.");
            Console.WriteLine("2.- Mostrar todos los electrodomésticos.");
            Console.WriteLine("3.- Mostrar los electrodomésticos descatalogados.");
            Console.WriteLine("4.- Mostrar electrodomésticos de una det. marca.");
            Console.WriteLine("5.- Salir.");
            op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}
