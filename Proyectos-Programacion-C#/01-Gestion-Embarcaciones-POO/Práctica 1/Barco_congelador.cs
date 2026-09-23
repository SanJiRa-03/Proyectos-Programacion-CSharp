using System;

namespace Práctica_1
{
    class Barco_congelador : Barcos
    {
        private bool zona1;
        private double peso1;
        private bool zona2;
        private double peso2;

        public Barco_congelador() : base()
        {
            zona1 = false;
            peso1 = 0;
            zona2 = false;
            peso2 = 0;
        }

        public override double GetPesoTotal()
        {
            return (zona1 ? peso1 : 0) + (zona2 ? peso2 : 0);
        }

        public override void SetZonaDoble(bool z1, double p1, bool z2, double p2)
        {
            this.zona1 = z1;
            this.peso1 = z1 ? p1 : 0;
            this.zona2 = z2;
            this.peso2 = z2 ? p2 : 0;
        }

        public override void InsertarBarco()
        {
            base.InsertarBarco();
            Console.WriteLine("Zona 1 - Alimentos perecederos ¿Está cargado (s/n)?");
            zona1 = Console.ReadLine().ToLower() == "s";
            if (zona1)
            {
                Console.WriteLine("Inserte el peso de la Zona 1 (Kg):");
                peso1 = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Zona 2 - Alimentos perecederos ¿Está cargado (s/n)?");
            zona2 = Console.ReadLine().ToLower() == "s";
            if (zona2)
            {
                Console.WriteLine("Inserte el peso de la Zona 2 (Kg):");
                peso2 = double.Parse(Console.ReadLine());
            }
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"- Zona 1 (Alimentos perecederos): {(zona1 ? $"Lleno ({peso1} Kg)." : "Vacío.")}");
            Console.WriteLine($"- Zona 2 (Alimentos perecederos): {(zona2 ? $"Lleno ({peso2} Kg)." : "Vacío.")}");
            Console.WriteLine($"- Peso total del barco: {GetPesoTotal()} Kg.");
        }
    }
}