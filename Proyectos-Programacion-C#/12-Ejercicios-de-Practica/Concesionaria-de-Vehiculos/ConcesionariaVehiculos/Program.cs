using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionariaVehiculos
{
    class Program
    {        
        static void Main(string[] args)
        {
            int op, op1;
            bool fin = false;

            List<Vehículo> listavehiculos = new List<Vehículo>();
            Auto auto = new Auto(); 
            Camioneta camioneta = new Camioneta();

            while (!fin)
            {
                op = Menu();
                switch(op)
                {
                    case 1:
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("¿Qué vehículo deseas agregar?");
                            Console.WriteLine("1. Auto");
                            Console.WriteLine("2. Camioneta");
                            op1 = int.Parse(Console.ReadLine());

                        } while (op1 != 1 && op1 != 2);
                        
                        switch (op1)
                        {
                            case 1:                                
                                auto = new Auto();
                                auto.AgregarVehiculo();
                                listavehiculos.Add(auto);
                                break;
                            case 2:
                                camioneta = new Camioneta();
                                camioneta.AgregarVehiculo();
                                listavehiculos.Add(camioneta);
                                break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Vehículos guardados: ");                        
                        foreach (Vehículo vehículo in listavehiculos)
                        {
                            if (listavehiculos.Count == 0)
                            {
                                Console.WriteLine("No hay vehículos guardados.\n");
                            }
                            else
                            {
                                vehículo.MostrarVehiculo();
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Inserta la marca que quieres buscar:");
                        string marca = Console.ReadLine();
                        foreach (Vehículo vehículo in listavehiculos)
                        {
                            if (vehículo.GetMarca() == marca)
                            {
                                vehículo.MostrarVehiculo();
                            }
                            else
                            {
                                Console.WriteLine("No hay vehículos registrados con esa marca.");
                            }
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Has decidido salir del menú.\n");
                        fin = true;
                        break;
                        default: Console.WriteLine("Inserta una opción válida.\n");
                        break;
                }
            }

        }
        public static int Menu()
        {
            int op;
            Console.WriteLine(" \nBienvenid@ al menú, elige una opción:\n");
            Console.WriteLine(" 1. Agregar un vehículo");
            Console.WriteLine(" 2. Mostrar vehículos");
            Console.WriteLine(" 3. Buscar vehiculos");
            Console.WriteLine(" 4. Salir");
            op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}

        /*Herencia: la clase "Auto" y "Camioneta" heredan de la clase "Vehiculo".
        Composición: la clase "Concesionaria" contiene una lista de vehículos.
        Polimorfismo: el programa puede manejar tanto autos como camionetas de forma polimórfica.
        Encapsulación: los atributos de las clases están encapsulados para que no se puedan modificar desde fuera de las clases.
        Abstracción: la clase "Vehiculo" es abstracta y no se pueden crear objetos directamente de ella.*/






