using System;
using System.Collections.Generic;

namespace Deportistas
{
     class Atletismo : Deportista
    {
        // Atributos
        private float velocidad;
        // Constructores
        // Constructor vacío
        public Atletismo() { }
        // Constructor parametrizado
        public Atletismo(string nombre, int edad, double altura, double peso, float velocidad) : base(nombre, edad, altura, peso)
        {
            this.velocidad = velocidad;
        }
        // Mutadores y accesores
        public float Get_velocidad()
        {
            return this.velocidad;
        }
        public void Set_velocidad(float velocidad)
        {
            this.velocidad = velocidad;
        }
        // Método
        public void VerificarVelocidad()
        {
            if(velocidad <= 20)
            {
                Console.WriteLine("Lento.\n");
            }
            else if(velocidad <= 40)
            {
                Console.WriteLine("Media.\n");
            }
            else
            {
                Console.WriteLine("Veloz.\n");
            }
        }
        // Mostrar
        public void Mostrar()
        {
            Console.WriteLine("Tipo de deporte: ATLETISMO\n");
            base.Mostrar();
            Console.WriteLine("Velocidad:\n" + Get_velocidad());
            VerificarVelocidad();
        }
    }
}
