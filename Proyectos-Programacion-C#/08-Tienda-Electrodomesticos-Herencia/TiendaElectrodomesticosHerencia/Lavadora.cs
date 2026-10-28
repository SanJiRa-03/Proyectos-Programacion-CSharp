using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaElectrodomesticosHerencia
{
     class Lavadora : Electrodomestico
    {
        // Atributos
        private string marca, modelo;
        private int energia, año, seFabrica, numLavados;
        // Constructores
        // Constructor vacío
        public Lavadora() { }
        // Constructor parametrizado
        public Lavadora(string marca, string modelo, int energia, int año, int seFabrica, int numLavados) : base(marca, modelo, energia, año, seFabrica)
        {
            this.numLavados = numLavados;
            this.marca = marca;
            this.modelo = modelo;
            this.energia = energia;
            this.año = año;
            this.seFabrica = seFabrica;
        }
        // Accesores y Mutadores 
        public int Get_numLavados()
        {
            return numLavados;
        }
        public void Set_numLavados(int numLavados)
        {
            this.numLavados = numLavados;
        }
        // Mostrar
        public override void MostrarInfo()
        {
            Console.WriteLine("| LAVADORA |");
            base.MostrarInfo();
            VerificarInteligencia();
            Console.WriteLine("\n");
        }
        // Método de lavadora
        public void VerificarInteligencia()
        {
            if (numLavados > 3 && energia == 1)
            {
                Console.WriteLine("Es una lavadora inteligente.");
            }
            else
            {
                Console.WriteLine("No es una lavadora inteligente.");
            }
        }
    }
}
