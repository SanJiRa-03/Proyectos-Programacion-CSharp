using System;

namespace Práctica_1
{
    abstract class Barcos
    {
        protected string codigo;
        protected string bandera;
        protected string origen;
        protected string destino;

        public Barcos()
        {
            codigo = "";
            bandera = "";
            origen = "";
            destino = "";
        }

        public string GetCodigo()
        {
            return codigo;
        }

        public virtual void InsertarBarco()
        {
            Console.WriteLine("Inserte el código de identificación:");
            codigo = Console.ReadLine();
            Console.WriteLine("Inserte la nacionalidad/bandera:");
            bandera = Console.ReadLine();
            Console.WriteLine("Inserte el origen:");
            origen = Console.ReadLine();
            Console.WriteLine("Inserte el destino:");
            destino = Console.ReadLine();
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"- Código de identificación: {codigo}");
            Console.WriteLine($"- Nacionalidad/Bandera: {bandera}");
            Console.WriteLine($"- Origen: {origen}");
            Console.WriteLine($"- Destino: {destino}");
        }

        // Método para obtener el peso total individual de este barco
        public abstract double GetPesoTotal();

        // Métodos virtuales para permitir la actualización de estados desde la clase Puerto
        public virtual void SetZonaUnica(bool estado, double peso) { }
        public virtual void SetZonaDoble(bool z1, double p1, bool z2, double p2) { }
        public virtual void SetCargasTransporte(bool z1, double p1, bool z2, double p2, bool z3, double p3) { }
        public virtual void SetCargasContenedor(bool z1, double p1, bool z2, double p2, bool z3, double p3, bool z4, double p4) { }
    }
}