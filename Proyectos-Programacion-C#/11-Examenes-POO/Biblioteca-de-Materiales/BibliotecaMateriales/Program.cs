using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMateriales {
    internal class Program {

        static List<Material> MaterialBiblioteca = new List<Material>();
        static void Main(string[] args) {
            // Introducir en la lista MaterialBiblioteca:
            // 2 libros, 2 revistas, 2 periódicos, utilizando los contructores parametrizados
            /*****************************************************************************/

            Libro libro1 = new Libro("Patata", "123jaen", "Brandon SANDer Son", 1080);
            Libro libro2 = new Libro("polOca", "457Polo", "Ma", 350);
            MaterialBiblioteca.Add(libro1);
            MaterialBiblioteca.Add(libro2);

            Revista revista1 = new Revista("HOLA", "13323h", 509, "Cotilleo");
            Revista revista2 = new Revista("Adios", "68", 905, "Temas Políticos");
            MaterialBiblioteca.Add(revista1);
            MaterialBiblioteca.Add(revista2);

            Periodico periodico1 = new Periodico("50 minutos", "u1yduq", 809, "Jaen");
            Periodico periodico2 = new Periodico("CBA", "82ugd", 17, "Murcia");
            MaterialBiblioteca.Add(periodico1);
            MaterialBiblioteca.Add(periodico2);


            /*****************************************************************************/

            EscribirFichero();
            LeerFichero();

        }

        public static void EscribirFichero() {
            // Escribir los materiales de la lista MaterialBiblioteca en el archivo biblioteca.txt
            /*****************************************************************************/
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lista.txt");
            StreamWriter sw = new StreamWriter(path);
            
            foreach(Material mat in MaterialBiblioteca)
            {
                sw.WriteLine(mat.WriteInfo());
            }

 
            sw.Close();


            /*****************************************************************************/
        }

        public static void LeerFichero() {
            List<Material> RellenarListaTXT = new List<Material>();
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lista.txt");
            // Rellenar la lista RellenarListaTXT con los datos del fichero biblioteca.txt
            /*****************************************************************************/
            if (!File.Exists(path)) File.Create(path).Close();
            StreamReader sr = new StreamReader(path);

            char sep = ';';

            string line;


            while ((line = sr.ReadLine()) != null)
            {
                string[] value = line.Split(sep);
                if (value[0] == "libro")//LIBRO
                {
                    Libro libro = new Libro(value[1], value[2], value[3], int.Parse(value[4]));
                    libro.GetInfo();
                    RellenarListaTXT.Add(libro);
                }
                else if (value[0] == "periodico")
                {
                    Periodico periodico = new Periodico(value[1], value[2], int.Parse(value[3]), value[4]);
                    RellenarListaTXT.Add(periodico);
                }
                else if (value[0] == "revista")
                {
                    Revista revista = new Revista(value[1], value[2], int.Parse(value[3]), value[4]);
                    RellenarListaTXT.Add(revista);
                }
            }
            sr.Close();
            Console.WriteLine(RellenarListaTXT.Count);


            /*****************************************************************************/

            // Mostrar información de cada elemento de RellenarListaTXT
            /*****************************************************************************/
            foreach (Material mat in RellenarListaTXT) 
            {
                mat.GetInfo();
            }
            /*****************************************************************************/
            
            Console.ReadKey();
        }
    }
}
