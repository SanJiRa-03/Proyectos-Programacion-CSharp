using System;

namespace Examen_CE
{
    public class Menu_Light : Menu
    {
        private string postreTexto = "No.";

        public Menu_Light() { }

        public override void PedirInfo()
        {
            base.PedirInfo();

            Console.WriteLine("¿Desea postre? (s/n):");
            if (Console.ReadLine().ToLower() == "s")
            {
                postreTexto = "Sí.";
                precio += 1.75;
            }
        }

        public override void MostrarInfo()
        {
            Console.WriteLine("- MENÚ LIGHT -");
            base.MostrarInfo();
            Console.WriteLine("Postre: " + postreTexto);
            Console.WriteLine("Precio Total: " + precio.ToString("0.00") + " euros.");
        }
    }
}