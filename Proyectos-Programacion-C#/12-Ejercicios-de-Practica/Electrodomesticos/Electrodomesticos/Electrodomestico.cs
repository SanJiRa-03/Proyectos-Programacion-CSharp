using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    public class Electrodomestico
    {
        //Atributos        
        protected string marca, modelo, energia, fabricacion;
        protected int año;
        //Constructores
        //Constructor vacío
        public Electrodomestico() { }
        //Constructor parametrizado
        public Electrodomestico(string marca, string modelo, string energia, int año, string fabricacion)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.energia = energia;
            this.año = año;
            this.fabricacion = fabricacion;
        }
        //Mutadores y accesores
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        public string GetMarca()
        {
            return marca;
        }
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string GetModelo()
        {
            return modelo;
        }
        public void SetEnergia(string energia)
        {
            this.energia = energia;
        }
        public string GetEnergia()
        {
            return energia;
        }
        public void SetAño(int año)
        {
            this.año = año;
        }
        public int GetAño()
        {
            return año;
        }
        public void SetFabricacion(string fabricacion)
        {
            this.fabricacion = fabricacion;
        }
        public string GetFabricacion()
        {
            return fabricacion;
        }
        //Métodos
        //POLIMORFISMO PARAMÉTRICO Y POLIMORFISMO DE SOBRECARGA
        public virtual void PedirInfo()
        {
            Console.WriteLine("Inserte la marca del electrodoméstico:");
            string marca = Console.ReadLine();
            Console.WriteLine("Inserte el modelo:");
            string modelo = Console.ReadLine();
            Console.WriteLine("¿Ahorra energía?");
            string energia = (Console.ReadLine());
            Console.WriteLine("Inserte el año de fabricación:");
            int año = int.Parse(Console.ReadLine());

            this.marca = marca;
            this.modelo = modelo;
            this.energia = energia;
            this.año = año;
        }
        public virtual void MostrarInfo()
        {
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Ahorro de energía: " + energia);
            Console.WriteLine("Año de fabricación: " + año);
            if(año < 2023)
            {
                fabricacion = "No";
            }
            else
            {
                fabricacion = "Sí";
            }
            Console.WriteLine("Descatalogado: " + fabricacion);
        }
        public virtual string EscribirInfo()
        {
            char sep = ';';
            string s = (marca + sep + modelo + sep + energia + sep + año + sep + fabricacion);
            return s;
        }
    }
}
