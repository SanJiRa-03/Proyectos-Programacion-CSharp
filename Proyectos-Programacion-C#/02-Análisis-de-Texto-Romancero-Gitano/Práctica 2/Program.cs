using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ejercicio_2
{
    class Program
    {
        public static void Main()
        {
            string path = "../romancero_gitano.txt";
            List<string> palabras = CargarRomancero(path);

            if (palabras.Count == 0)
            {
                Console.WriteLine("No se encontraron palabras o el archivo está vacío.");
                return;
            }

            int palabrasUnicas = ContarPalabrasUnicas(palabras);
            int vecesNiño = ContarPalabra(palabras, "niño");
            int vecesPunto = ContarPuntos(palabras);

            MostrarEstadisticas(palabrasUnicas, vecesNiño, vecesPunto);
            GuardarFichero(palabras.Count, palabrasUnicas, vecesNiño, vecesPunto);

            Console.WriteLine("Estadísticas guardadas correctamente.");
            Console.ReadLine();
        }

        static List<string> CargarRomancero(string nombreArchivo)
        {
            List<string> palabras = new List<string>();

            try
            {
                //Uso de 'using' para asegurar el cierre automático del archivo
                using (StreamReader sr = new StreamReader(nombreArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] palabrasLinea = linea.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string palabra in palabrasLinea)
                        {
                            palabras.Add(palabra.ToLower());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar el archivo: " + ex.Message);
            }

            return palabras;
        }

        public static int ContarPalabrasUnicas(List<string> palabras)
        {
            //Uso Distinct() de LINQ para filtrar los elementos duplicados
            return palabras.Distinct().Count();
        }

        public static int ContarPalabra(List<string> palabras, string palabraBuscada)
        {
            int contador = 0;
            string objetivo = palabraBuscada.ToLower();

            foreach (string palabra in palabras)
            {
                //Limpio la palabra de signos adyacentes para una coincidencia exacta
                string palabraLimpia = palabra.Trim('.', ',', ';', ':', '!', '?', '«', '»');
                if (palabraLimpia == objetivo)
                {
                    contador++;
                }
            }
            return contador;
        }

        public static int ContarPuntos(List<string> palabras)
        {
            int contador = 0;
            foreach (string palabra in palabras)
            {
                foreach (char c in palabra)
                {
                    if (c == '.')
                    {
                        contador++;
                    }
                }
            }
            return contador;
        }

        public static void MostrarEstadisticas(int palabrasUnicas, int vecesNiño, int vecesPunto)
        {
            Console.WriteLine("Número de palabras únicas: " + palabrasUnicas);
            Console.WriteLine("Número de veces que aparece la palabra 'niño': " + vecesNiño);
            Console.WriteLine("Número de veces que aparece el signo de puntuación '.': " + vecesPunto);
        }

        public static void GuardarFichero(int palabrasTotales, int palabrasUnicas, int vecesNiño, int puntosTotales)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("../estadisticas.txt"))
                {
                    sw.WriteLine("Palabras totales: " + palabrasTotales);
                    sw.WriteLine("Palabras únicas: " + palabrasUnicas);
                    sw.WriteLine("Número de veces que aparece la palabra 'niño': " + vecesNiño);
                    sw.WriteLine("'.' totales: " + puntosTotales);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar las estadísticas: " + ex.Message);
            }
        }
    }
}