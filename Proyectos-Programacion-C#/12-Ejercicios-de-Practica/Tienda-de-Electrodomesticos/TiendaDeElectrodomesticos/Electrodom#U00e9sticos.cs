using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeElectrodomesticos
{
    public class Electrodomésticos
    {
        //Atributos
        protected string marca, modelo, energia;
        protected int año;
        protected bool fabricado;
        //Constructores
        //Constructor vacío
        public Electrodomésticos(){}
        //Constructor parametrizado
        public Electrodomésticos(string marca, string modelo, int año, string energia, bool fabricado)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
            this.energia = energia;
            this.fabricado = fabricado;
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
        public void SetAño(int año)
        {
            this.año = año;
        }
        public int GetAño()
        {
            return año;
        }
        public void SetEnergia(string energia)
        {
            this.energia = energia;
        }
        public string GetEnergia()
        {
            return energia;
        }
        public void SetFabricado(bool fabricado)
        {
            this.fabricado = fabricado;
        }
        public bool GetFabricado()
        {
            return fabricado;
        }
        //Métodos
        public virtual void PedirInfo()
        {
            Console.WriteLine("Inserte la marca:");
            string marca = Console.ReadLine();
            Console.WriteLine("Inserte el modelo:");
            string modelo = Console.ReadLine();
            Console.WriteLine("Inserte su año de fabricación:");
            int año = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Ahorra energía? (s/n)");
            string energia = Console.ReadLine();

            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
            this.energia = energia;
        }
        public string Fabricado(int año)
        {
            string f;
            if(año >= 2020)
            {
                f = "sí";
                SetFabricado(true);
            }
            else
            {
                f = "no";
                SetFabricado(false);
            }
            return f;
        }
        public virtual void MostrarInfo()
        {
            Console.WriteLine("Marca: " + GetMarca());
            Console.WriteLine("Modelo: " + GetModelo());
            Console.WriteLine("Año de fabricación: " + GetAño());
            Console.WriteLine("Ahorro de energía: " + GetEnergia());
            Console.WriteLine("¿Se sigue fabricando?: " + Fabricado(GetAño()));
        }
    }
}
