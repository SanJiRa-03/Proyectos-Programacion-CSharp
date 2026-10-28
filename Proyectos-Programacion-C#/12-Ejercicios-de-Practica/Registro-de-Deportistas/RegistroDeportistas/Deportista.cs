using System;

namespace RegistroDeportistas
{
    public class Deportista
    {
        //Atributos
        protected string nombre;
        protected int edad;
        protected double altura, peso;
        //Constructores
        //Constructor vacío
        public Deportista() { }
        //Constructor parametrizado
        public Deportista(string nombre, int edad, double altura, double peso)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.altura = altura;
            this.peso = peso;
        }
        //Mutadores y accesores
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public int GetEdad()
        {
            return edad;
        }
        public void SetAltura(double altura)
        {
            this.altura = altura;
        }
        public double GetAltura()
        {
            return altura;
        }
        public void SetPeso(double peso)
        {
            this.peso = peso;
        }
        public double GetPeso()
        {
            return peso;
        }
        //Métodos
        public virtual void PedirInfo()
        {
            Console.WriteLine("Insertando un deportista...");
            Console.WriteLine("Inserta su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Inserta su edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserta su altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserta su peso: ");
            double peso = double.Parse(Console.ReadLine());

            this.nombre = nombre;
            this.edad = edad;
            this.altura = altura;
            this.peso = peso;
        }
        public virtual void MostrarInfo()
        {
            Console.WriteLine("|DEPORTISTAS|");
            Console.WriteLine("Nombre: " + GetNombre());
            Console.WriteLine("Edad: " + GetEdad());
            Console.WriteLine("Altura: " + GetAltura());
            Console.WriteLine("Peso: " + GetPeso());
        }
    }
}
