using System;

namespace Práctica_1
{
    class Barco_transporte : Barcos
    {
        private bool zona1;
        private double peso1;
        private bool zona2;
        private double peso2;
        private bool zona3;
        private double peso3;

        public Barco_transporte() : base()
        {
            zona1 = false; peso1 = 0;
            zona2 = false; peso2 = 0;
            zona3 = false; peso3 = 0;
        }

        public override double GetPesoTotal()
        {
            return (zona1 ? peso1 : 0) + (zona2 ? peso2 : 0) + (zona3 ? peso3 : 0);
        }

        public override void SetCargasTransporte(bool z1, double p1, bool z2, double p2, bool z3, double p3)
        {
            this.zona1 = z1; this.peso1 = z1 ? p1 : 0;
            this.zona2 = z2; this.peso2 = z2 ? p2 : 0;
            this.zona3 = z3; this.peso3 = z3 ? p3 : 0;
        }

        public override void InsertarBarco()
        {
            base.InsertarBarco();
            Console.WriteLine("Zona 1 - No perecederos Tipo 1 ¿Está cargado (s/n)?");
            zona1 = Console.ReadLine().ToLower() == "s";
            if (zona1) { Console.WriteLine("Inserte peso Zona 1 (Kg):"); peso1 = double.Parse(Console.ReadLine()); }

            Console.WriteLine("Zona 2 - No perecederos Tipo 2 ¿Está cargado (s/n)?");
            zona2 = Console.ReadLine().ToLower() == "s";
            if (zona2) { Console.WriteLine("Inserte peso Zona 2 (Kg):"); peso2 = double.Parse(Console.ReadLine()); }

            Console.WriteLine("Zona 3 - No perecederos Tipo 2 ¿Está cargado (s/n)?");
            zona3 = Console.ReadLine().ToLower() == "s";
            if (zona3) { Console.WriteLine("Inserte peso Zona 3 (Kg):"); peso3 = double.Parse(Console.ReadLine()); }
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"- Zona 1 (No perecederos Tipo 1): {(zona1 ? $"Lleno ({peso1} Kg)." : "Vacío.")}");
            Console.WriteLine($"- Zona 2 (No perecederos Tipo 2): {(zona2 ? $"Lleno ({peso2} Kg)." : "Vacío.")}");
            Console.WriteLine($"- Zona 3 (No perecederos Tipo 2): {(zona3 ? $"Lleno ({peso3} Kg)." : "Vacío.")}");
            Console.WriteLine($"- Peso total del barco: {GetPesoTotal()} Kg.");
        }
    }
}