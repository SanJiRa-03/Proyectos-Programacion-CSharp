using System;

namespace SensorProcessorExam
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Introduzca el nombre (con extensión) del fichero de medidas a leer: ");
            string input_filename = Console.ReadLine();

            Console.Write("Introduzca el nombre (con extensión) del fichero de salida: ");
            string output_filename = Console.ReadLine();

            ProcesadorSenales sp = new ProcesadorSenales();
            int errors = sp.LeerMediciones(input_filename);

            if (errors >= 0)
            {
                Console.WriteLine($"{errors} registros corruptos o con formato erróneo detectados.");
                sp.EscribirMediciones(output_filename);
            }

            Console.ReadLine();
        }
    }
}