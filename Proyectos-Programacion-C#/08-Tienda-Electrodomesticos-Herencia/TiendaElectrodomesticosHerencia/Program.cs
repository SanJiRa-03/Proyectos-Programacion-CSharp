using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaElectrodomesticosHerencia
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            List<Electrodomestico> electrodomestico = new List<Electrodomestico>();
            Lavadora lavadora;
            Lavavajillas lavavajillas;
            Nevera nevera;
            Horno horno;

            bool fin = false;
            int op = 0, op2;

            while (!fin)
            {
                try
                {
                    Console.WriteLine("1- Introducir nuevo electrodoméstico.");
                    Console.WriteLine("2- Mostrar todos los electrodomésticos con su información.");
                    Console.WriteLine("3- Mostrar todos los electrodomésticos descatalogados.");
                    Console.WriteLine("4- Mostrar todos los electrodoméstico de una marca determinada.");
                    Console.WriteLine("5- Salir.");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {   
                            // Introducir nuevo electrodoméstico
                        case 1:
                            string marca, modelo;
                            int energia, año, seFabrica, numLavados, tiempo, capacidad, inteligencia, autolimpiado;                            
                            Console.Clear();
                            Console.WriteLine("1- Lavadoras.");
                            Console.WriteLine("2- Lavavajillas.");
                            Console.WriteLine("3- Neveras.");
                            Console.WriteLine("4- Hornos.");
                            Console.WriteLine("5- Salir.");
                            op2 = int.Parse(Console.ReadLine());

                            if (op2 == 1)
                            {
                                lavadora = new Lavadora();
                                Console.Clear();
                                Console.WriteLine("| LAVADORA |");
                                Console.WriteLine("Inserte la marca: ");
                                marca = Console.ReadLine().ToLower();
                                Console.WriteLine("Inserte el modelo: ");
                                modelo = Console.ReadLine().ToLower();
                                do
                                {
                                    Console.WriteLine("¿Ahorra energía? (1- Si o 2- No): ");
                                    energia = int.Parse(Console.ReadLine());
                                } while (energia != 1 && energia != 2);
                                do
                                {
                                    Console.WriteLine("Año de fabricación: ");
                                    año = int.Parse(Console.ReadLine());
                                } while (año < 1990 || año > 2022);
                                do
                                {
                                    Console.WriteLine("¿Se sigue fabricando? (1- Si o 2- No): ");
                                    seFabrica = int.Parse(Console.ReadLine());
                                } while (seFabrica != 1 && seFabrica != 2);
                                Console.WriteLine("Inserte el número de programas de lavado: ");
                                numLavados = int.Parse(Console.ReadLine());
                                lavadora = new Lavadora(marca, modelo, energia, año, seFabrica, numLavados);
                                electrodomestico.Add(lavadora);
                                Console.WriteLine("\n");
                            }
                            if (op2 == 2)
                            {
                                lavavajillas = new Lavavajillas();
                                Console.Clear();
                                Console.WriteLine("| LAVAVAJILLAS |");
                                Console.WriteLine("Inserte la marca: ");
                                marca = Console.ReadLine().ToLower();
                                Console.WriteLine("Inserte el modelo: ");
                                modelo = Console.ReadLine().ToLower();
                                do
                                {
                                    Console.WriteLine("¿Ahorra energía? (1- Si o 2- No): ");
                                    energia = int.Parse(Console.ReadLine());
                                } while (energia != 1 && energia != 2);
                                do
                                {
                                    Console.WriteLine("Año de fabricación: ");
                                    año = int.Parse(Console.ReadLine());
                                } while (año < 1990 || año > 2022);
                                do
                                {
                                    Console.WriteLine("¿Se sigue fabricando? (1- Si o 2- No): ");
                                    seFabrica = int.Parse(Console.ReadLine());
                                } while (seFabrica != 1 && seFabrica != 2);
                                Console.WriteLine("Tiempo de su programa más rápido (en minutos): ");
                                tiempo = int.Parse(Console.ReadLine());
                                lavavajillas = new Lavavajillas(marca, modelo, energia, año, seFabrica, tiempo);
                                electrodomestico.Add(lavavajillas);
                                Console.WriteLine("\n");
                            }
                            if (op2 == 3)
                            {
                                nevera = new Nevera();
                                Console.Clear();
                                Console.WriteLine("| NEVERA |");
                                Console.WriteLine("Inserte la marca: ");
                                marca = Console.ReadLine().ToLower();
                                Console.WriteLine("Inserte el modelo: ");
                                modelo = Console.ReadLine().ToLower();
                                do
                                {
                                    Console.WriteLine("¿Ahorra energía? (1- Si o 2- No): ");
                                    energia = int.Parse(Console.ReadLine());
                                } while (energia != 1 && energia != 2);
                                do
                                {
                                    Console.WriteLine("Año de fabricación: ");
                                    año = int.Parse(Console.ReadLine());
                                } while (año < 1990 || año > 2022);
                                do
                                {
                                    Console.WriteLine("¿Se sigue fabricando? (1- Si o 2- No): ");
                                    seFabrica = int.Parse(Console.ReadLine());
                                } while (seFabrica != 1 && seFabrica != 2);
                                Console.WriteLine("Capacidad de la nevera (en litros): ");
                                capacidad = int.Parse(Console.ReadLine());
                                do
                                {
                                    Console.WriteLine("¿Es inteligente? (1- Si o 2- No): ");
                                    inteligencia = int.Parse(Console.ReadLine());
                                } while (inteligencia != 1 && inteligencia != 2);
                                nevera = new Nevera(marca, modelo, energia, año, seFabrica, capacidad, inteligencia);
                                electrodomestico.Add(nevera);
                                Console.WriteLine("\n");
                            }
                            if (op2 == 4)
                            {
                                horno = new Horno();
                                Console.Clear();
                                Console.WriteLine("| HORNO |");
                                Console.WriteLine("Inserte la marca: ");
                                marca = Console.ReadLine().ToLower();
                                Console.WriteLine("Inserte el modelo: ");
                                modelo = Console.ReadLine().ToLower();
                                do
                                {
                                    Console.WriteLine("¿Ahorra energía? (1- Si o 2- No): ");
                                    energia = int.Parse(Console.ReadLine());
                                } while (energia != 1 && energia != 2);
                                do
                                {
                                    Console.WriteLine("Año de fabricación: ");
                                    año = int.Parse(Console.ReadLine());
                                } while (año < 1990 || año > 2022);
                                do
                                {
                                    Console.WriteLine("¿Se sigue fabricando? (1- Si o 2- No): ");
                                    seFabrica = int.Parse(Console.ReadLine());
                                } while (seFabrica != 1 && seFabrica != 2);
                                do
                                {
                                    Console.WriteLine("¿Tiene autolimpiado? (1- Si o 2- No): ");
                                    autolimpiado = int.Parse(Console.ReadLine());
                                } while (autolimpiado != 1 && autolimpiado != 2);
                                horno = new Horno(marca, marca, energia, año, seFabrica, autolimpiado);
                                electrodomestico.Add(horno);
                                Console.WriteLine("\n");
                            }
                            break;
                            // Mostrar toda la info. de los electrodomésticos
                        case 2:
                            Console.Clear();
                            if (electrodomestico.Count == 0)
                                Console.WriteLine("No hay ningún electrodoméstico guardado.\n");
                            else
                            {
                                Console.WriteLine("Lista de electrodomesticos guardados:\n");
                                foreach (Electrodomestico electrodomesticos in electrodomestico)
                                {
                                    electrodomesticos.MostrarInfo();
                                }
                                Console.WriteLine("\n");
                            }
                            break;
                            // Mostrar los electrodomésticos descatalogados
                        case 3:
                            Console.Clear();
                            int cont = 0;                                                                                                                 
                                Console.WriteLine("Lista de electrodomésticos descatalogados:\n");
                                foreach (Electrodomestico electrodomesticos in electrodomestico)
                                {
                                    if (electrodomesticos.Descatalogados())
                                    {
                                        electrodomesticos.MostrarInfo();
                                        cont++;
                                    }                                                                        
                                }
                            if (cont == 0)
                            {
                                Console.WriteLine("No hay ningún electrodoméstico descatalogado.\n");
                            }
                            Console.WriteLine("\n");
                            break;
                            // Buscar por marca determinada
                        case 4:
                            string buscarMarca;
                            int cont2 = 0;
                            Console.Clear();
                            Console.WriteLine("Porfavor, introduzca la marca del electrodoméstico que quiere buscar:\n");
                            buscarMarca = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Buscar marca: " + buscarMarca + "\n");
                            foreach (Electrodomestico electrodomesticos in electrodomestico)
                            {
                                if (electrodomesticos.Get_marca().ToLower() == buscarMarca)
                                {
                                    electrodomesticos.MostrarInfo();
                                    cont2++;
                                }
                            }
                            if (cont2 == 0)
                            {
                                Console.WriteLine("No hay ningún electrodoméstico que corresponda con esta marca.\n");
                            }
                            break;
                        case 5:
                            fin = true;
                            Console.WriteLine("- Saliendo del programa -");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Se ha producido un error.\n");
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
 }
