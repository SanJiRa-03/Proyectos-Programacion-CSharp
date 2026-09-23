using System;
using System.Collections.Generic;

namespace Práctica_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Puerto puerto = new Puerto();

            int op = 0, op1 = 0, op2 = 0;
            bool fin = false;

            while (!fin)
            {
                op = Menu();

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\nTipo de barco [1-4]:");
                        Console.WriteLine("1- Barco pesquero.");
                        Console.WriteLine("2- Barco congelador.");
                        Console.WriteLine("3- Barco transporte.");
                        Console.WriteLine("4- Barco de contenedores.");
                        op1 = int.Parse(Console.ReadLine());
                        switch (op1)
                        {
                            case 1:
                                Barco_pesquero pesquero = new Barco_pesquero();
                                pesquero.InsertarBarco();
                                puerto.AddBarco(pesquero);
                                break;
                            case 2:
                                Barco_congelador congelador = new Barco_congelador();
                                congelador.InsertarBarco();
                                puerto.AddBarco(congelador);
                                break;
                            case 3:
                                Barco_transporte transporte = new Barco_transporte();
                                transporte.InsertarBarco();
                                puerto.AddBarco(transporte);
                                break;
                            case 4:
                                Barco_contenedores contenedor = new Barco_contenedores();
                                contenedor.InsertarBarco();
                                puerto.AddBarco(contenedor);
                                break;
                        }
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 2:
                        string codigo;
                        bool encontrado = false;

                        Console.Clear();
                        Console.WriteLine("\nInserte el código de identificación:");
                        codigo = Console.ReadLine();

                        List<Barcos> listaB = puerto.GetListaBarcos();

                        for (int i = 0; i < listaB.Count; i++)
                        {
                            if (listaB[i].GetCodigo() == codigo)
                            {
                                listaB.RemoveAt(i);
                                Console.WriteLine("\nBarco eliminado con éxito");
                                Console.WriteLine($"Nueva carga acumulada en puerto: {puerto.ObtenerPesoTotalPuerto()} Kg.\n");
                                encontrado = true;
                                break;
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("\nNo existe ningún barco con ese código de identificación en el puerto.\n");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        if (puerto.GetListaBarcos().Count == 0)
                        {
                            Console.WriteLine("\nNo hay barcos en el puerto.\n");
                        }
                        else
                        {
                            puerto.Mostrar();
                        }
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 4:
                        string respuesta;
                        Console.Clear();
                        Console.WriteLine("\nTipo de carga [1-4]:");
                        Console.WriteLine("1- Alimentos perecederos.");
                        Console.WriteLine("2- No perecederos tipo 1.");
                        Console.WriteLine("3- No perecederos tipo 2.");
                        Console.WriteLine("4- Peligroso.");
                        op2 = int.Parse(Console.ReadLine());

                        if (puerto.GetListaBarcos().Count == 0)
                        {
                            Console.WriteLine("\nNo hay barcos en el puerto.\n");
                        }
                        else
                        {
                            puerto.Filtrar(op2);

                            Console.WriteLine("\n¿Desea cambiar la carga de algún barco (s/n)?");
                            respuesta = Console.ReadLine().ToLower();

                            if (respuesta == "s")
                            {
                                Console.WriteLine("\nInserte la ID del barco: ");
                                string codigoID = Console.ReadLine();

                                puerto.CambiarCarga(codigoID);
                            }
                        }
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("\nHas decidido salir del menú.");
                        Console.ReadKey();
                        fin = true;
                        break;
                }
            }
        }

        public static int Menu()
        {
            int op = 0;
            Console.WriteLine("\nBienvenid@ al menú");
            Console.WriteLine("-------------------");
            Console.WriteLine("1.- Inserción de un navío.");
            Console.WriteLine("2.- Eliminación de un navío.");
            Console.WriteLine("3.- Visualización textual.");
            Console.WriteLine("4.- Filtrar por tipo de carga.");
            Console.WriteLine("5.- Salir.");
            Console.WriteLine("Por favor, inserte una opción.");
            op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}