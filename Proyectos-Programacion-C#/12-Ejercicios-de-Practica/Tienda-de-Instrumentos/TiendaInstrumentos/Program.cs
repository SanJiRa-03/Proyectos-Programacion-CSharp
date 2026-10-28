using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInstrumentos
{
    class Program
    {
        static List<Instrumentos> listaInstrumentos = new List<Instrumentos>();
        static void Main(string[] args)
        {
            int op;
            bool fin = false;

            Guitarra guitarra = new Guitarra();
            Piano piano = new Piano();

            while (!fin)
            {                
                op = Menu();

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        int op2;
                        Console.WriteLine("¿Qué instrumento deseas añadir?");
                        Console.WriteLine("1.- Guitarra");                        
                        Console.WriteLine("2.- Piano");
                        op2 = int.Parse(Console.ReadLine());
                        switch (op2)
                        {
                            case 1:
                                Console.Clear();
                                guitarra = new Guitarra();
                                guitarra.PedirInfo();
                                listaInstrumentos.Add(guitarra);
                                break;
                            case 2:
                                Console.Clear();
                                piano = new Piano();
                                piano.PedirInfo();
                                listaInstrumentos.Add(piano);
                                break;
                            default: Console.WriteLine("Inserta una opción válida.\n"); break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Inserta el número de serie del instrumento que deseas alquilar:");
                        string numeroSerie = Console.ReadLine();
                        foreach (Instrumentos I in listaInstrumentos)
                        {
                            if (numeroSerie == I.GetNumeroSerie())
                            {
                                I.MostrarInfo();
                                Console.WriteLine("Alquilado correctamente!\n");
                                I.SetAlquilado(true);
                            }else
                            {
                                Console.WriteLine("No hay ningún instrumento con ese número de serie o este es incorrecto.\n");
                            }
                        }
                        break;
                        case 3:
                            Console.Clear();
                        foreach (Instrumentos I in listaInstrumentos)
                        {
                            if (I.GetAlquilado() == true)
                            {
                                I.MostrarInfo();
                            }else
                            {
                                Console.WriteLine("No hay elementos alquilados todavía.\n");
                            }
                        }
                        break;
                    case 4:
                        Console.Clear();
                        EscribirFichero();
                        LeerFichero();
                        break;
                        case 5:
                            Console.Clear();
                        Console.WriteLine("Has decidido salir del menú.\n");
                        fin = true;
                        break;
                    default: Console.WriteLine("Inserta una opción válida.\n"); break;
                }
            }
        }
        public static int Menu()
        {
            int op;
            Console.WriteLine("Bienvenid@ al menú, elige una opción:");
            Console.WriteLine("1.- Añadir un instrumento.");
            Console.WriteLine("2.- Alquilar un instrumento.");
            Console.WriteLine("3.- Listar instrumentos con su ubicación");
            Console.WriteLine("4.- Guardar los datos en un archivo de texto.");
            Console.WriteLine("5.- Salir");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        public static void EscribirFichero()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lista.txt");
            StreamWriter sw = new StreamWriter(path);

            foreach (Instrumentos I in listaInstrumentos)
            {
                sw.WriteLine(I.EscribirInfo());
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
                if (datos[0] == "guitarra")
                {
                    Guitarra guitarra = new Guitarra(datos[1], datos[2], datos[3], Convert.ToBoolean(datos[4]), int.Parse(datos[5]), int.Parse(datos[6]), int.Parse(datos[7]), datos[8]);
                }
                else if (datos[0] == "piano")
                {
                    Piano piano = new Piano(datos[1], datos[2], datos[3], bool.Parse(datos[4]), int.Parse(datos[5]), int.Parse(datos[6]), int.Parse(datos[7]), datos[8]);
                }
            }
            
            sr.Close();

            foreach (Instrumentos I in listaInstrumentos)
            {
                I.MostrarInfo();
            }
        }
    }   
}
