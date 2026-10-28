using System;
using System.Collections.Generic;


namespace Deportistas
{
     class Deportista
    {
        // Atributos
        protected string nombre;
        protected int edad;
        protected double altura, peso;
        // Constructores
        // Constructor vacío
        public Deportista() { }
        // Constructor parametrizado
        public Deportista(string nombre, int edad, double altura, double peso) 
        { 
            this.nombre = nombre;
            this.edad = edad;
            this.altura = altura;
            this.peso = peso;

        }
        // Mutadores y accesores
        public string Get_nombre()
        {
            return this.nombre;
        }
        public void Set_nombre(string nombre)
        {
            this.nombre = nombre;
        }
        public int Get_edad()
        {
            return this.edad;
        }
        public void Set_edad(int edad)
        {
            this.edad = edad;
        }
        public double Get_altura()
        {
            return this.altura;
        }
        public void Set_altura(double altura)
        {
            this.altura = altura;
        }
        public double Get_peso()
        {
            return this.peso;
        }
        public void Set_peso(double peso)
        {
            this.peso = peso;
        }
        // Mostrar
        public void Mostrar()
        {
            Console.WriteLine("Nombre:\n" + Get_nombre());
            Console.WriteLine("Edad:\n" + Get_edad());
            Console.WriteLine("Altura:\n" + Get_altura());
            Console.WriteLine("Peso:\n" + Get_peso() + "\n");
        }
    }
}
