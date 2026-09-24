using System;
using System.Collections.Generic;
using System.IO;

namespace SensorProcessorExam
{
    public class ProcesadorSenales
    {
        private List<string> mediciones;
        private int numerrores;

        public ProcesadorSenales()
        {
            mediciones = new List<string>();
            numerrores = 0;
        }

        public int LeerMediciones(string nombreArchivo)
        {
            //Reiniciamos colección y contadores por cada lectura
            mediciones.Clear();
            numerrores = 0;

            try
            {
                if (!File.Exists(nombreArchivo))
                {
                    Console.WriteLine($"El archivo '{nombreArchivo}' no existe.");
                    return -1;
                }

                string[] lineas = File.ReadAllLines(nombreArchivo);

                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(';');

                    //Validación de estructura: exactamente 7 campos por lectura de sensor
                    if (datos.Length == 7)
                    {
                        mediciones.Add(linea);
                    }
                    else
                    {
                        numerrores++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ha producido un error durante la lectura: " + ex.Message);
            }

            return numerrores;
        }

        public void EscribirMediciones(string nombreArchivo)
        {
            try
            {
                File.WriteAllLines(nombreArchivo, mediciones);
                Console.WriteLine("Procesamiento completado y archivo exportado con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ha producido un error durante la escritura: " + ex.Message);
            }
        }
    }
}