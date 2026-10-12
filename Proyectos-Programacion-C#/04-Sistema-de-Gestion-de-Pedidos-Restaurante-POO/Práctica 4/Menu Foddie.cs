using System;

namespace Examen_CE
{
    public class Menu_Foddie : Menu
    {
        private string segundoPlato, complemento1, postre;

        public Menu_Foddie() { }

        public override void PedirInfo()
        {
            base.PedirInfo();

            Console.WriteLine("Inserte el segundo plato:");
            segundoPlato = Console.ReadLine();
            precio += 5.50;

            Console.WriteLine("Inserte el complemento:");
            complemento1 = Console.ReadLine();
            precio += 1.00;

            Console.WriteLine("Inserte el postre:");
            postre = Console.ReadLine();
            precio += 1.75;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine("- MENÚ FODDIE -");
            base.MostrarInfo();
            Console.WriteLine("Segundo plato: " + segundoPlato);
            Console.WriteLine("Complemento: " + complemento1);
            Console.WriteLine("Postre: " + postre);
            Console.WriteLine("Precio Total: " + precio.ToString("0.00") + " euros.");
        }
    }
}