using System;

namespace Práctica_1
{
    class Barco_pesquero : Barcos
    {
        private bool estaCargado;
        private double pesoCarga;

        public Barco_pesquero() : base()
        {
            estaCargado = false;
            pesoCarga = 0;
        }

        public override double GetPesoTotal()
        {
            return estaCargado ? pesoCarga : 0;
        }

        public override void SetZonaUnica(bool estado, double peso)
        {
            this.estaCargado = estado;
            this.pesoCarga = estado ? peso : 0;
        }

        public override void InsertarBarco()
        {
            base.InsertarBarco();
            Console.WriteLine("Zona 1 (Alimentos perecederos) ¿Está cargado (s/n)?");
            string resp = Console.ReadLine().ToLower();
            estaCargado = (resp == "s");

            if (estaCargado)
            {
                Console.WriteLine("Inserte el peso de la carga (Kg):");
                pesoCarga = double.Parse(Console.ReadLine());
            }
            else
            {
                pesoCarga = 0;
            }
        }

        public override void Mostrar()
        {
            base.Mostrar();
            string estadoStr = estaCargado ? $"Lleno ({pesoCarga} Kg)." : "Vacío.";
            Console.WriteLine($"- Zona 1 (Alimentos perecederos): {estadoStr}");
            Console.WriteLine($"- Peso total del barco: {GetPesoTotal()} Kg.");
        }
    }
}