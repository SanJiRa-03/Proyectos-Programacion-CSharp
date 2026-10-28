using System;
using System.Collections.Generic;
using System.IO;

namespace Deportistas
{
     class Program
    {
        static void Main(string[] args)
        {
            List<Deportista> ListaDeportistas = new List<Deportista>();
            List<Atletismo> ListaAtletismo = new List<Atletismo>();
            List<Ciclismo> ListaCiclismo = new List<Ciclismo>();
            List<Natación> ListaNatacion= new List<Natación>();

            bool fin = false, fin2 = false;
            int op = 0, op2 = 0;
            while (!fin)
            {
                try
                {                    
                    do
                    {                       
                       op2 = Menu();


                        switch (op2)
                        {
                            case 1:
                                do
                                {
                                    Console.Clear();
                                    op = MenuDeportes();

                                } while (op < 1 || op > 4);
                                switch (op)
                                {
                                    case 1:
                                        // ATLETAS
                                        string nombre;
                                        int edad;
                                        double altura, peso;
                                        float velocidad;
                                        Console.Clear();
                                        Console.WriteLine("Inserte el nombre del deportista:\n");
                                        nombre = Console.ReadLine();
                                        Console.WriteLine("Inserte la edad del deportista:\n");
                                        edad = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Inserte la altura del deportista:\n");
                                        altura = float.Parse(Console.ReadLine());
                                        Console.WriteLine("Inserte el peso del deportista:\n");
                                        peso = float.Parse(Console.ReadLine());
                                        Console.WriteLine("Inserte la velocidad (en km/h) del atleta:\n");
                                        velocidad = float.Parse(Console.ReadLine());
                                        Atletismo atleta = new Atletismo(nombre, edad, altura, peso, velocidad);                                       
                                        ListaAtletismo.Add(atleta);
                                        break;
                                    case 2:
                                        // CICLISTAS                                      
                                        float kilometros;
                                        Console.Clear();
                                        Console.WriteLine("Inserte el nombre del deportista:\n");
                                        nombre = Console.ReadLine();
                                        Console.WriteLine("Inserte la edad del deportista:\n");
                                        edad = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Inserte la altura del deportista:\n");
                                        altura = float.Parse(Console.ReadLine());
                                        Console.WriteLine("Inserte el peso del deportista:\n");
                                        peso = float.Parse(Console.ReadLine());
                                        Console.WriteLine("Inserte los kilómetros que ha realizado el ciclista:\n");
                                        kilometros = float.Parse(Console.ReadLine());
                                        Ciclismo ciclista = new Ciclismo(nombre, edad, altura, peso, kilometros);                                        
                                        ListaCiclismo.Add(ciclista);
                                        break;
                                    case 3:
                                        // NADADORES                                        
                                        int pulsaciones;                                                                                
                                        Console.Clear();
                                        Console.WriteLine("Inserte el nombre del deportista:\n");
                                        nombre = Console.ReadLine();
                                        Console.WriteLine("Inserte la edad del deportista:\n");
                                        edad = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Inserte la altura del deportista:\n");
                                        altura = float.Parse(Console.ReadLine());
                                        Console.WriteLine("Inserte el peso del deportista:\n");
                                        peso = float.Parse(Console.ReadLine());
                                        Console.WriteLine("Inserte las pulsaciones por min. del nadador:\n");
                                        pulsaciones = int.Parse(Console.ReadLine());
                                        Natación nadador = new Natación(nombre, edad, altura, peso, pulsaciones);                                        
                                        ListaNatacion.Add(nadador);
                                        break;
                                    case 4:
                                        // SALIR
                                        Console.Clear();
                                        Console.WriteLine("Volviendo al menú principal...\n");
                                        fin2 = true;
                                        break;
                                }
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Inserte el nombre del deportista que desea eliminar: ");
                                string leer = Console.ReadLine();
                                List<Deportista> ListaAct = new List<Deportista>();
                                foreach (Deportista D in ListaDeportistas)
                                {
                                    if (D.Get_nombre().ToLower() != leer.ToLower()) // Crea una lista en la que se añaden todos los nombres diferentes a Jaime.
                                    {
                                        ListaAct.Add(D);
                                    }
                                }
                                ListaDeportistas = ListaAct;
                                break;
                            case 3:
                                bool cont = false;
                                Console.Clear();
                                Console.WriteLine("Inserte el nombre del deportista que desea buscar: ");
                                string n = Console.ReadLine();
                                foreach (Deportista D in ListaDeportistas)
                                {
                                    if (D.Get_nombre().ToLower() == n.ToLower())
                                    {
                                        D.Mostrar();
                                        cont = true;
                                    }
                                }
                                if (cont == false)
                                {
                                    Console.WriteLine("No existe ningún deportista con ese nombre.\n");
                                }
                                break;
                            case 4:
                                bool cont2 = false;
                                Console.Clear();
                                Console.WriteLine("| DEPORTISTAS |");
                                foreach (Deportista D in ListaDeportistas)
                                {
                                    D.Mostrar();
                                    cont2 = true;
                                }
                                if (cont2 == false)
                                {
                                    Console.WriteLine("No hay ningún deportista guardado.\n");
                                }
                                break;
                            case 5:
                                Console.Clear();

                                break;
                            case 6:
                                Console.Clear();
                                Console.WriteLine("Has decidido salir del programa.");
                                Console.ReadKey();
                                fin = true;
                                break;
                        }

                    } while (op < 0 || op > 6);
                                        
                }catch (Exception ex)
                {
                    Console.WriteLine("Se ha producido un error\n");
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static int MenuDeportes()
        {
            int op = 0;
            Console.WriteLine("Por favor, intruduzca el tipo de deporte al que pertenece el deportista:\n");
            Console.WriteLine("1.- Atletismo.");
            Console.WriteLine("2.- Ciclismo.");
            Console.WriteLine("3.- Natación.");            
            Console.WriteLine("4.- Salir.");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        public static int Menu()
        {
            int op2 = 0;
            Console.WriteLine("1.- Añadir a un deportista.");
            Console.WriteLine("2.- Eliminar a un deportista.");
            Console.WriteLine("3.- Buscar a un deportista.");
            Console.WriteLine("4.- Mostar la información de la lista de deportistas.");
            Console.WriteLine("5.- Guardar la información en un fichero de texto.");
            Console.WriteLine("6.- Salir.");
            op2 = int.Parse(Console.ReadLine());
            return op2;
        }
        public static void EscribirAlArchivo(List <Deportista> ListaDeportistas, List<Atletismo> ListaA, List<Ciclismo> ListaC, List<Natación> ListaN)
        {
            StreamWriter sw = File.CreateText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ListaDeportistas.txt"));
            try
            {
                /*foreach (Atletismo D in ListaA)
                {
                    sw.WriteLine("A:" + D.Get_nombre() + ':' + D.Get_edad() + ':' + D.Get_altura() + ':' + D.Get_peso() + ":" + D.Get_velocidad());
                }
                foreach (Ciclismo D in ListaC)
                {
                    sw.WriteLine("C:" + D.Get_nombre() + ':' + D.Get_edad() + ':' + D.Get_altura() + ':' + D.Get_peso() + ":" + D.Get_kilometros());
                }
                foreach (Natación D in ListaN)
                {
                    sw.WriteLine("N:" + D.Get_nombre() + ':' + D.Get_edad() + ':' + D.Get_altura() + ':' + D.Get_peso() + ":" + D.Get_pulsaciones());
                }*/
                foreach (Deportista D in ListaDeportistas)
                {
                    if (D is Atletismo)
                    {
                        Atletismo A = (Atletismo)D;
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Se ha producido un error.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sw.Close();
            }
        }
        public static void LeerDelArchivo(List<Deportista> ListaDeportistas, List<Atletismo> ListaAtletismo, List<Ciclismo> ListaCiclismo, List<Natación> ListaNatacion)
        {                      

            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ListaDeportistas.txt"))) File.Create(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ListaDeportistas.txt")).Close();
            StreamReader sr = File.OpenText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ListaDeportistas.txt"));
            try
            {
                string linea = "";
                while ((linea = sr.ReadLine()) != null)
                {                    
                    string[] datos = linea.Split(':');
                    if (datos[0] == "A") 
                    {
                        Atletismo atletismo = new Atletismo(datos[0], int.Parse(datos[1]), float.Parse(datos[2]), float.Parse(datos[3]), float.Parse(datos[4]));
                        ListaDeportistas.Add(atletismo);
                        ListaAtletismo.Add(atletismo);
                    }
                    if (datos[0] == "C")
                    {
                        Ciclismo ciclismo = new Ciclismo(datos[0], int.Parse(datos[1]), float.Parse(datos[2]), float.Parse(datos[3]), float.Parse(datos[4]));
                        ListaDeportistas.Add(ciclismo);
                        ListaCiclismo.Add(ciclismo);
                    }
                    if (datos[0] == "N")
                    {
                        Natación natacion = new Natación(datos[0], int.Parse(datos[1]), float.Parse(datos[2]), float.Parse(datos[3]), float.Parse(datos[4]));
                        ListaDeportistas.Add(natacion);
                        ListaNatacion.Add(natacion);
                    }
                    ListaDeportistas.Add(new Deportista());
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
        }
    }
}
