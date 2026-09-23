using System;
using System.Collections.Generic;

namespace Práctica_1
{
    class Puerto
    {
        private List<Barcos> ListaBarcos;

        public Puerto()
        {
            ListaBarcos = new List<Barcos>();
        }

        public Puerto(List<Barcos> miLista)
        {
            ListaBarcos = miLista;
        }

        public List<Barcos> GetListaBarcos()
        {
            return ListaBarcos;
        }

        public void SetListaBarcos(List<Barcos> barcos)
        {
            ListaBarcos = barcos;
        }

        public void AddBarco(Barcos miBarco)
        {
            ListaBarcos.Add(miBarco);
            Console.WriteLine($"\n¡Barco añadido con éxito!");
            Console.WriteLine($"Carga acumulada total en el puerto: {ObtenerPesoTotalPuerto()} Kg.");
        }

        public double ObtenerPesoTotalPuerto()
        {
            double acumulado = 0;
            foreach (Barcos barquito in ListaBarcos)
            {
                acumulado += barquito.GetPesoTotal();
            }
            return acumulado;
        }

        public void Mostrar()
        {
            foreach (Barcos barquito in ListaBarcos)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("- Tipo de barco:");
                if (barquito is Barco_pesquero) Console.WriteLine("Pesquero.");
                else if (barquito is Barco_congelador) Console.WriteLine("Congelador.");
                else if (barquito is Barco_transporte) Console.WriteLine("Transporte.");
                else if (barquito is Barco_contenedores) Console.WriteLine("Contenedor.");

                barquito.Mostrar();
            }
            Console.WriteLine("\n=================================");
            Console.WriteLine($"CARGA TOTAL EN PUERTO: {ObtenerPesoTotalPuerto()} Kg.");
            Console.WriteLine("=================================");
        }

        public void Filtrar(int tipoCarga)
        {
            bool hayCoincidencias = false;

            foreach (Barcos barquito in ListaBarcos)
            {
                if (tipoCarga == 1 && (barquito is Barco_pesquero || barquito is Barco_congelador))
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("- Tipo de carga: | Alimentos perecederos |");
                    barquito.Mostrar();
                    hayCoincidencias = true;
                }
                else if (tipoCarga == 2 && (barquito is Barco_contenedores || barquito is Barco_transporte))
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("- Tipo de carga: | No perecederos Tipo 1 |");
                    barquito.Mostrar();
                    hayCoincidencias = true;
                }
                else if (tipoCarga == 3 && (barquito is Barco_contenedores || barquito is Barco_transporte))
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("- Tipo de carga: | No perecederos Tipo 2 |");
                    barquito.Mostrar();
                    hayCoincidencias = true;
                }
                else if (tipoCarga == 4 && barquito is Barco_contenedores)
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("- Tipo de carga: | Material peligroso |");
                    barquito.Mostrar();
                    hayCoincidencias = true;
                }
            }

            if (!hayCoincidencias)
            {
                Console.WriteLine("\nNo se encontraron barcos con el tipo de carga seleccionado.\n");
            }
        }

        public void CambiarCarga(string codigo)
        {
            Barcos barcoEncontrado = null;

            foreach (Barcos barquito in ListaBarcos)
            {
                if (barquito.GetCodigo() == codigo)
                {
                    barcoEncontrado = barquito;
                    break;
                }
            }

            if (barcoEncontrado == null)
            {
                Console.WriteLine("\nNo existe ningún barco con ese código de identificación en el puerto.\n");
                return;
            }

            if (barcoEncontrado is Barco_pesquero pesquero)
            {
                Console.WriteLine("Zona 1: Alimentos perecederos ¿Está cargado (s/n)?");
                bool cargado = Console.ReadLine().ToLower() == "s";
                double peso = 0;
                if (cargado) { Console.WriteLine("Inserte peso (Kg):"); peso = double.Parse(Console.ReadLine()); }
                pesquero.SetZonaUnica(cargado, peso);
            }
            else if (barcoEncontrado is Barco_congelador congelador)
            {
                Console.WriteLine("Zona 1: Alimentos perecederos ¿Está cargado (s/n)?");
                bool r1 = Console.ReadLine().ToLower() == "s";
                double p1 = 0; if (r1) { Console.WriteLine("Inserte peso Zona 1 (Kg):"); p1 = double.Parse(Console.ReadLine()); }

                Console.WriteLine("Zona 2: Alimentos perecederos ¿Está cargado (s/n)?");
                bool r2 = Console.ReadLine().ToLower() == "s";
                double p2 = 0; if (r2) { Console.WriteLine("Inserte peso Zona 2 (Kg):"); p2 = double.Parse(Console.ReadLine()); }

                congelador.SetZonaDoble(r1, p1, r2, p2);
            }
            else if (barcoEncontrado is Barco_transporte transporte)
            {
                Console.WriteLine("Zona 1: No perecederos (Tipo 1) ¿Está cargado (s/n)?");
                bool r1 = Console.ReadLine().ToLower() == "s";
                double p1 = 0; if (r1) { Console.WriteLine("Inserte peso Zona 1 (Kg):"); p1 = double.Parse(Console.ReadLine()); }

                Console.WriteLine("Zona 2: No perecederos (Tipo 2) ¿Está cargado (s/n)?");
                bool r2 = Console.ReadLine().ToLower() == "s";
                double p2 = 0; if (r2) { Console.WriteLine("Inserte peso Zona 2 (Kg):"); p2 = double.Parse(Console.ReadLine()); }

                Console.WriteLine("Zona 3: No perecederos (Tipo 2) ¿Está cargado (s/n)?");
                bool r3 = Console.ReadLine().ToLower() == "s";
                double p3 = 0; if (r3) { Console.WriteLine("Inserte peso Zona 3 (Kg):"); p3 = double.Parse(Console.ReadLine()); }

                transporte.SetCargasTransporte(r1, p1, r2, p2, r3, p3);
            }
            else if (barcoEncontrado is Barco_contenedores contenedor)
            {
                Console.WriteLine("Zona 1: No perecederos (Tipo 1) ¿Está cargado (s/n)?");
                bool r1 = Console.ReadLine().ToLower() == "s";
                double p1 = 0; if (r1) { Console.WriteLine("Inserte peso Zona 1 (Kg):"); p1 = double.Parse(Console.ReadLine()); }

                Console.WriteLine("Zona 2: No perecederos (Tipo 2) ¿Está cargado (s/n)?");
                bool r2 = Console.ReadLine().ToLower() == "s";
                double p2 = 0; if (r2) { Console.WriteLine("Inserte peso Zona 2 (Kg):"); p2 = double.Parse(Console.ReadLine()); }

                Console.WriteLine("Zona 3: No perecederos (Tipo 2) ¿Está cargado (s/n)?");
                bool r3 = Console.ReadLine().ToLower() == "s";
                double p3 = 0; if (r3) { Console.WriteLine("Inserte peso Zona 3 (Kg):"); p3 = double.Parse(Console.ReadLine()); }

                Console.WriteLine("Zona 4: Material peligroso ¿Está cargado (s/n)?");
                bool r4 = Console.ReadLine().ToLower() == "s";
                double p4 = 0; if (r4) { Console.WriteLine("Inserte peso Zona 4 (Kg):"); p4 = double.Parse(Console.ReadLine()); }

                contenedor.SetCargasContenedor(r1, p1, r2, p2, r3, p3, r4, p4);
            }

            Console.WriteLine("\n¡Carga modificada y guardada con éxito!");
            Console.WriteLine($"Nueva carga total acumulada en puerto: {ObtenerPesoTotalPuerto()} Kg.");
        }
    }
}