using System;
using System.Collections.Generic;
using System.IO;

namespace ElectronicMark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            bool fin = false;

            Propietario propietario = new Propietario();
            Moviles moviles = new Moviles();
            Relojes relojes = new Relojes();
            Memorias_USB memorias_USB = new Memorias_USB();

            List<Dispositivos> listaDispositivos = new List<Dispositivos>(); 
            List<Propietario> listaPropietarios = new List<Propietario>();

            while (!fin)
            {
                try
                {
                    int respuesta;
                    bool valido = false;
                    while (!valido)
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("¿Eres propietario? (1. Sí, 2. No)");
                            respuesta = int.Parse(Console.ReadLine());
                            if (respuesta != 1 && respuesta != 2)
                            {
                                Console.WriteLine("Por favor inserta una opción válida.");
                            }
                        } while (respuesta != 1 && respuesta != 2);
                        if (respuesta == 1)
                        {                            
                            Console.WriteLine("Inserte su DNI por favor:");
                            string DNI = Console.ReadLine();
                            foreach (Propietario P in listaPropietarios)
                            {
                                if (DNI == P.GetDni())
                                {
                                    Console.WriteLine("¡Usuario encontrado!");                                    
                                    valido = true;
                                    op = Menu();
                                }
                            }
                            if (!valido)
                            {
                                Console.WriteLine("Lo sentimos, sus datos no coinciden.");
                                break;
                            }
                        }
                        else
                        {
                            propietario = new Propietario();
                            propietario.PedirDatos();
                            listaPropietarios.Add(propietario);                            
                        }
                    }
                                                                            
                        op = Menu();
                        switch (op)
                        {
                            case 1:
                                int op2;
                                Console.Clear();
                                do
                                {
                                    Console.WriteLine("¿Qué dispositivo desea añadir? [1-3]");
                                    Console.WriteLine("1. Móviles.");
                                    Console.WriteLine("2. Relojes inteligentes.");
                                    Console.WriteLine("3. Memorias USB.");
                                    Console.WriteLine("3. Salir al menú principal.");
                                    op2 = int.Parse(Console.ReadLine());
                                    if (op2 != 1 && op2 != 2 && op != 3 && op2 != 4)
                                    {
                                        Console.WriteLine("Por favor inserta una opción válida.");
                                    }
                                } while (op2 != 1 && op2 != 2 && op != 3 && op2 != 4);
                                switch (op2)
                                {
                                    case 1:
                                        Console.Clear();
                                        moviles.PedirInfo();
                                        break;
                                    case 2:
                                        Console.Clear();
                                        relojes.PedirInfo();
                                        break;
                                    case 3:
                                        Console.Clear();
                                        memorias_USB.PedirInfo();
                                        break;
                                    case 4:
                                        Console.Clear();
                                        op = Menu();
                                        break;
                                }
                                break;
                            case 2:
                                Console.Clear();
                                bool encontrado = false;
                                Console.WriteLine("Inserta el nombre del dispositivo que deseas dar de baja: ");
                                string nombre = Console.ReadLine();
                                foreach (Dispositivos D in listaDispositivos)
                                {
                                    if (nombre.ToLower() == D.GetNombreDispositivo())
                                    {
                                        encontrado = true;
                                        Console.WriteLine("¡Dispositivo encontrado y eliminado con éxito!");
                                        listaDispositivos.Remove(D);
                                    }
                                }
                                if (!encontrado)
                                {
                                    Console.WriteLine("Lo sentimos, no existe un dispositivo guardado con ese nombre.");
                                }
                                break;
                            case 3:
                                Console.Clear();
                                bool encontrado1 = false;
                                Console.WriteLine("Inserta el nombre del dispositivo que deseas dar de baja: ");
                                string n = Console.ReadLine();
                                foreach (Dispositivos D in listaDispositivos)
                                {
                                    if (n.ToLower() == D.GetNombreDispositivo())
                                    {
                                        encontrado1 = true;
                                        Console.WriteLine("¡Dispositivo encontrado con éxito!");
                                        D.MostrarInfo();
                                    }
                                }
                                if (!encontrado1)
                                {
                                    Console.WriteLine("Lo sentimos, no existe un dispositivo guardado con ese nombre.");
                                }
                                break;
                            case 4:
                                Console.Clear();
                                /*foreach (Dispositivos D in listaDispositivos)
                                {
                                    if (listaDispositivos.Count > 0)
                                    {
                                        D.MostrarInfo();
                                    }
                                }*/
                                break;
                            case 5:
                                Console.Clear();
                                EscribirAlArchivo(listaDispositivos);
                                break;
                            case 6:
                                Console.Clear();
                                Console.WriteLine("Has decidido salir del menú.");
                                fin = true;
                                break;
                        }                                                            
                }
                catch(Exception e)
                {
                    Console.WriteLine("Se ha producido un error.");
                    Console.WriteLine(e.Message);
                }
            }
        }       
        public static int Menu()
        {
            int op;
            Console.WriteLine("Bienvenid@ al menú, por favor elige una opción:");
            Console.WriteLine("1.- Dar de alta un nuevo dispositivo.");
            Console.WriteLine("2.- Dar de baja un dispositivo.");
            Console.WriteLine("3.- Buscar un dispositivo.");
            Console.WriteLine("4.- Mostrar por pantalla la información de la tienda.");
            Console.WriteLine("5.- Guardar la información en un fichero de texto.");
            Console.WriteLine("6.- Salir");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        public static void EscribirAlArchivo(List<Dispositivos> dispositivos)
        {
            StreamWriter sw = File.CreateText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dispositivos.txt"));
            try
            {
                foreach (Dispositivos D in dispositivos)
                {
                    sw.WriteLine(D.GetNombreDispositivo() + ':' + D.GetModelo() + ':' + D.GetNombreFabricante() + ':' + D.GetFecha() + ':' + D.GetCapacidad());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Se ha producido un error.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Close();
            }
        }
        public static List<Dispositivos> LeerDelArchivo()
        {
            List<Dispositivos> dispositivos = new List<Dispositivos>();
            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dispositivos.txt"))) File.Create(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dispositivos.txt")).Close();
            StreamReader sr = File.OpenText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dispositivos.txt"));
            try
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(':');
                    dispositivos.Add(new Dispositivos(datos[0], datos[1], datos[2], Convert.ToInt32(datos[3]), Convert.ToInt32(datos[4])));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Se ha producido un error.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
            }
            return dispositivos;
        }
    }
}
