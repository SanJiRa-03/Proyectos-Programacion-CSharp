using System;
using System.Collections.Generic;

namespace Deportistas
{
     class Ciclismo : Deportista
    {
        // Atributos
        private float kilometros;
        // Constructores
        // Constructor vacío
        public Ciclismo() { }
        // Constructor parametrizado
        public Ciclismo(string nombre, int edad, double altura, double peso, float kilometros) : base(nombre, edad, altura, peso)
        {
            this.kilometros = kilometros;
        }
        // Mutadores y accesores
        public float Get_kilometros()
        {
            return this.kilometros;
        }
        public void Set_kilometros(float kilometros)
        {
            this.kilometros = kilometros;
        }
        // Método
        public void VerificarKilometros()
        {
            if (kilometros <= 80)
            {
                Console.WriteLine("Bajo.\n");
            }
            else if (kilometros <= 100)
            {
                Console.WriteLine("Medio.\n");
            }
            else
            {
                Console.WriteLine("Alto.\n");
            }
        }
        // Mostrar
        public void Mostrar()
        {
            Console.WriteLine("Tipo de deporte: CICLISMO\n");
            base.Mostrar();
            Console.WriteLine("Kilómetros recorridos:\n" + Get_kilometros());
            VerificarKilometros();            
        }
    }
}
