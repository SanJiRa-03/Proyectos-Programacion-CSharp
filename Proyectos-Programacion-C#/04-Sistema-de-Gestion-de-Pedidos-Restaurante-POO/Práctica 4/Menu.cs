using System;

namespace Examen_CE
{
    public class Menu
    {
        protected string bebida, principal;
        protected int numeroPedido;
        protected double precio = 0;
        protected string estado = "En preparación.";

        public Menu() { }

        public Menu(string bebida, string principal, int numeroPedido, double precio, string estado)
        {
            this.bebida = bebida;
            this.principal = principal;
            this.numeroPedido = numeroPedido;
            this.precio = precio;
            this.estado = estado;
        }

        public void SetBebida(string bebida) => this.bebida = bebida;
        public string GetBebida() => bebida;

        public void SetPrincipal(string principal) => this.principal = principal;
        public string GetPrincipal() => principal;

        public void SetNumeroPedido(int numeroPedido) => this.numeroPedido = numeroPedido;
        public int GetNumeroPedido() => numeroPedido;

        public void SetPrecio(double precio) => this.precio = precio;
        public double GetPrecio() => precio;

        public void SetEstado(string estado) => this.estado = estado;
        public string GetEstado() => estado;

        public virtual void PedirInfo()
        {
            Console.WriteLine("Inserte el número del pedido:");
            numeroPedido = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte la bebida:");
            bebida = Console.ReadLine();
            precio += 1.50;

            Console.WriteLine("Inserte el principal:");
            principal = Console.ReadLine();
            precio += 4.25;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine("Número de pedido: " + numeroPedido);
            Console.WriteLine("Bebida: " + bebida);
            Console.WriteLine("Principal: " + principal);
            Console.WriteLine("Estado: " + estado);
        }
    }
}