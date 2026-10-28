using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    internal class Program
    {
        static List<Animal> listaAnimales = new List<Animal>();
        static void Main(string[] args)
        {            
            Gato gato = new Gato("Renato", "Miau", 1, "Atigrado", 1);
            listaAnimales.Add(gato);
            Perro perro = new Perro("Tizas", "Guau", 2, "Mastin", 3);
            listaAnimales.Add(perro);
            Pajaro pajaro = new Pajaro("Piqui", "Pio pio", 3, "Agaporni", 1);
            listaAnimales.Add(pajaro);
            //Escribe primero los animales parametrizados en el .txt
            EscribirFichero();
            //Luego los muestra por pantalla.
            LeerFichero();

        }
        public static void EscribirFichero()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lista.txt");
            StreamWriter sw = new StreamWriter(path);

            foreach (Animal A in listaAnimales)
            {
                sw.WriteLine(A.EscribirFichero());
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
                if (datos[0] == "gato")
                {
                    Gato gato = new Gato(datos[1], datos[2], int.Parse(datos[3]), datos[4], int.Parse(datos[5]));
                    //listaAnimales.Add(gato);

                }else if (datos[0] == "perro")
                {
                    Perro perro = new Perro(datos[1], datos[2], int.Parse(datos[3]), datos[4], int.Parse(datos[5]));  
                    //listaAnimales.Add(perro);

                }else if (datos[0] == "pajaro")
                {
                    Pajaro pajaro = new Pajaro(datos[1], datos[2], int.Parse(datos[3]), datos[4], int.Parse(datos[5]));
                    //listaAnimales.Add(pajaro);
                }
            }
            sr.Close();

            foreach (Animal A in listaAnimales)
            {
                A.MostrarInfo();
            }
        }
    }
}
