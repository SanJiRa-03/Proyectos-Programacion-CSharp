using System;

namespace Examen_CE
{
    public class Menu_Estandar : Menu
    {
        private string postre;
        private bool tieneComp1, tieneComp2;
        private string descComp1 = "No.", descComp2 = "No.";

        public Menu_Estandar() { }

        public override void PedirInfo()
        {
            base.PedirInfo();

            Console.WriteLine("Inserte el postre:");
            postre = Console.ReadLine();
            precio += 1.75;

            Console.WriteLine("¿Desea un primer complemento? (s/n)");
            if (Console.ReadLine().ToLower() == "s")
            {
                tieneComp1 = true;
                Console.WriteLine("Descripción Complemento 1:");
                descComp1 = Console.ReadLine();
                precio += 1.00;
            }

            Console.WriteLine("¿Desea un segundo complemento? (s/n)");
            if (Console.ReadLine().ToLower() == "s")
            {
                tieneComp2 = true;
                Console.WriteLine("Descripción Complemento 2:");
                descComp2 = Console.ReadLine();
                precio += 1.00;
            }
        }

        public override void MostrarInfo()
        {
            Console.WriteLine("- MENÚ ESTÁNDAR -");
            base.MostrarInfo();
            Console.WriteLine("Postre: " + postre);
            Console.WriteLine("Complemento 1: " + descComp1);
            Console.WriteLine("Complemento 2: " + descComp2);
            Console.WriteLine("Precio Total: " + precio.ToString("0.00") + " euros.");
        }
    }
}