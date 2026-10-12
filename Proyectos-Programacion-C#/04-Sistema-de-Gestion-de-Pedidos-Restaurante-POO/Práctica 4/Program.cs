using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_CE
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Menu> listaPedidos = new List<Menu>();
            int op;
            bool fin = false;

            while (!fin)
            {
                op = Menu();
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("¿Qué menú deseas añadir?");
                        Console.WriteLine("1.- Menú estándar.");
                        Console.WriteLine("2.- Menú Foddie.");
                        Console.WriteLine("3.- Menú Light.");
                        if (int.TryParse(Console.ReadLine(), out int op2))
                        {
                            Console.Clear();
                            switch (op2)
                            {
                                case 1:
                                    Menu_Estandar nuevoEstandar = new Menu_Estandar();
                                    nuevoEstandar.PedirInfo();
                                    listaPedidos.Add(nuevoEstandar);
                                    break;
                                case 2:
                                    Menu_Foddie nuevoFoddie = new Menu_Foddie();
                                    nuevoFoddie.PedirInfo();
                                    listaPedidos.Add(nuevoFoddie);
                                    break;
                                case 3:
                                    Menu_Light nuevoLight = new Menu_Light();
                                    nuevoLight.PedirInfo();
                                    listaPedidos.Add(nuevoLight);
                                    break;
                                default:
                                    Console.WriteLine("Inserta una opción válida.\n");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        if (listaPedidos.Count > 0)
                        {
                            foreach (Menu M in listaPedidos)
                            {
                                M.MostrarInfo();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay pedidos todavía.\n");
                        }
                        Console.WriteLine("\nPresiona Enter para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        bool encontrado = false;
                        Console.WriteLine("Inserte el número del pedido que desea cambiar de estado:");
                        if (int.TryParse(Console.ReadLine(), out int numeroPedido))
                        {
                            foreach (Menu M in listaPedidos)
                            {
                                if (numeroPedido == M.GetNumeroPedido())
                                {
                                    M.MostrarInfo();
                                    Console.WriteLine("\n¿A qué estado desea cambiar?:");
                                    Console.WriteLine("1. En preparación.");
                                    Console.WriteLine("2. En reparto.");
                                    Console.WriteLine("3. Entregado.");
                                    if (int.TryParse(Console.ReadLine(), out int op3))
                                    {
                                        switch (op3)
                                        {
                                            case 1:
                                                M.SetEstado("En preparación.");
                                                break;
                                            case 2:
                                                M.SetEstado("En reparto.");
                                                break;
                                            case 3:
                                                M.SetEstado("Entregado.");
                                                break;
                                        }
                                        Console.WriteLine("¡Estado actualizado con éxito!\n");
                                    }
                                    encontrado = true;
                                }
                            }
                            if (!encontrado)
                            {
                                Console.WriteLine("No se ha encontrado ningún pedido con ese número.\n");
                            }
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Has decidido salir del menú, ¡vuelve pronto!");
                        fin = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Inserta una opción válida.\n");
                        break;
                }
            }
        }

        public static int Menu()
        {
            Console.WriteLine("Bienvenid@ al menú, elige una opción:");
            Console.WriteLine("1.- Crear un nuevo pedido.");
            Console.WriteLine("2.- Visualizar los pedidos disponibles.");
            Console.WriteLine("3.- Cambiar estado de pedido.");
            Console.WriteLine("4.- Salir");
            if (int.TryParse(Console.ReadLine(), out int op))
            {
                return op;
            }
            return 0;
        }
    }
}