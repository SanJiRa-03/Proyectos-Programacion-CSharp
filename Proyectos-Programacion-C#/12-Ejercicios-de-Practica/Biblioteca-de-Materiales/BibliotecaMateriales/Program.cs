using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMateriales
{
    internal class Program{
        
        static List<Material> MaterialBiblioteca = new List<Material>();
        static void Main(string[] args)
        {            

            Libro libro1 = new Libro(titulo: "libro1", isbn: "123", autor: "autor1", numeroPaginas: 10);
            Libro libro2 = new Libro(titulo: "libro2", isbn: "1234", autor: "autor2", numeroPaginas: 11);
            MaterialBiblioteca.Add(libro1);
            MaterialBiblioteca.Add(libro2);

            Revista revista1 = new Revista(titulo: "revista1", isbn: "456", numeroEdicion: 1, tema: "Deporte");
            Revista revista2 = new Revista(titulo: "revista2", isbn: "4567", numeroEdicion: 2, tema: "Moda");
            MaterialBiblioteca.Add(revista1);
            MaterialBiblioteca.Add(revista2);

            Periodico periodico1 = new Periodico(titulo: "periodico1", isbn: "678", numeroEdicion: 3, ciudadPublicacion: "Madrid");
            Periodico periodico2 = new Periodico(titulo: "periodico2", isbn: "6789", numeroEdicion: 4, ciudadPublicacion: "Barcelona");
            MaterialBiblioteca.Add(periodico1);
            MaterialBiblioteca.Add(periodico2);

            Escribirfichero();
            LeerFichero();
        }
        public static void Escribirfichero()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lista.txt");
            StreamWriter sw = new StreamWriter(path);

            foreach (Material M in MaterialBiblioteca)
            {
                sw.WriteLine(M.EscribirInfo());
            }

            sw.Close();
        }
        public static void LeerFichero()
        {
            List<Material> RellenarListaTXT = new List<Material>();
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lista.txt");
            if (!File.Exists(path)) File.Create(path).Close();
            StreamReader sr = new StreamReader(path);

            char sep = ';';

            string linea;

            while ((linea = sr.ReadLine()) != null)
            {
                string[] datos = linea.Split(sep);
                if (datos[0] == "libro")
                {
                    Libro libro = new Libro(datos[1], datos[2], datos[3], Convert.ToInt32(datos[4]));
                    RellenarListaTXT.Add(libro);

                }else if (datos[0] == "periodico")
                {
                    Periodico periodico = new Periodico(datos[1], datos[2], int.Parse(datos[3]), datos[4]);
                    RellenarListaTXT.Add(periodico);
                }
                else if (datos[0] == "revista")
                {
                    Revista revista = new Revista(datos[1], datos[2], int.Parse(datos[3]), datos[4]);
                    RellenarListaTXT.Add(revista);
                }
            }

            sr.Close();

            foreach (Material M in RellenarListaTXT)
            {
                M.MostrarInfo();
            }
            
            Console.ReadKey();
        }
    }
}