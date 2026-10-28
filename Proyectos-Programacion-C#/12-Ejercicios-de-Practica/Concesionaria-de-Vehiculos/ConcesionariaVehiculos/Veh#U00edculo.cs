using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionariaVehiculos
{
    public abstract class Vehículo
    {
        //Atributos
        protected string marca, modelo;
        protected int año;
        //Constructores
        //Constructor vacío
        public Vehículo() { }
        //Constructor parametrizado
        public Vehículo(string marca, string modelo, int año)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
        }
        //Mutadores y accesores
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string GetModelo()
        {
            return this.modelo;
        }
        public void SetAño(int año)
        {
            this.año = año;
        }
        public int GetAño()
        {
            return this.año;
        }
        //Métodos
        public virtual void MostrarVehiculo()
        {
            Console.WriteLine("Marca: " + GetMarca());
            Console.WriteLine("Modelo: " + GetModelo());
            Console.WriteLine("Año: " + GetAño());
        }
        public virtual void AgregarVehiculo()
        {
            Console.WriteLine("Inserte la marca: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Inserte el modelo: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("Inserte el año: ");
            int año = int.Parse(Console.ReadLine());

            this.marca = marca;
            this.modelo = modelo;
            this.año = año;

        }
    }
}
