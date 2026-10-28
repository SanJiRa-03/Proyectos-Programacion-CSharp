using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruteria
{
    public class Productos
    {
        //Atributos
        public string nombre, id;
        public double precio;
        public int cantidad;
        //Constructores
        //Constructor vacío
        public Productos() { }
        //Constructor parametrizado
        public Productos(string nombre, string id, double precio, int cantidad) 
        {
            this.nombre = nombre;
            this.id = id;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        //Mutadores y accesores
        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetId()
        {
            return id;
        }
        public void SetId(string id)
        {
            this.id = id;
        }
        public double GetPrecio()
        {
            return precio;
        }
        public void SetPrecio(double precio)
        {
            this.precio = precio;
        }
        public int GetCantidad()
        {
            return cantidad;
        }
        public void SetCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }
        //Métodos
        public void PedirInfo()
        {
            Console.WriteLine("Inserta el nombre del producto:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Inserta el id del producto:");
            string id = Console.ReadLine();
            Console.WriteLine("Inserta su valor:");
            double precio = double.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuántos productos desea comprar?");
            int cantidad = int.Parse(Console.ReadLine());

            this.nombre = nombre;
            this.id = id;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        public void MostrarInfo()
        {
            Console.WriteLine("Nombre del producto: " + GetNombre());
            Console.WriteLine("Id del producto: " + GetId());
            Console.WriteLine("Precio: " + GetPrecio());
            Console.WriteLine("Cantidad: " + GetCantidad() + "\n");
        }
    }
}
