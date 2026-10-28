using System;
using System.Collections.Generic;

namespace Deportistas
{
     class Natación : Deportista
    {
        // Atributos
        private int pulsaciones;
        // Constructores
        // Constructor vacío
        public Natación() { }
        // Constructor parametrizado
        public Natación(string nombre, int edad, double altura, double peso, float velocidad) : base(nombre, edad, altura, peso)
        {
            this.pulsaciones = pulsaciones;
        }
        // Mutadores y accesores
        public float Get_pulsaciones()
        {
            return this.pulsaciones;
        }
        public void Set_pulsaciones(int pulsaciones)
        {
            this.pulsaciones = pulsaciones;
        }
        // Método
        public void VerificarPulsaciones()
        {
            if (pulsaciones == 1)
            {
                Console.WriteLine("Frecuencia baja.\n");
            }
            else if (pulsaciones == 2)
            {
                Console.WriteLine("Frecuencia media.\n");
            }
            else if(pulsaciones == 3)
            {
                Console.WriteLine("Frecuencia alta.\n");
            }            
        }        
        // Mostrar
        public void Mostrar()
        {
            Console.WriteLine("Tipo de deporte: NATACIÓN\n");
            base.Mostrar();
            Console.WriteLine("Número de pulsaciones por minuto:\n" + Get_pulsaciones());
            VerificarPulsaciones();
        }
    }
}
