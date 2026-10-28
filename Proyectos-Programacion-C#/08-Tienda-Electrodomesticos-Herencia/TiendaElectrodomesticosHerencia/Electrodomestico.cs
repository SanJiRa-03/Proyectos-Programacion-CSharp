using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaElectrodomesticosHerencia
{
     class Electrodomestico
    {
        // Atributos
        protected string marca, modelo;
        protected int energia, año, seFabrica;
        // Constructores
        // Constructor vacío
        public Electrodomestico() { }
        // Constructor parametrizado
        public Electrodomestico(string marca, string modelo, int energia, int año, int seFabrica)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.energia = energia;
            this.año = año;
            this.seFabrica = seFabrica;
        }
        // Accesores y Mutadores 
        public string Get_marca()
        {
            return marca;
        }
        public void Set_marca()
        {
            this.marca = marca;
        }
        public string Get_modelo()
        {
            return modelo;
        }
        public void Set_modelo()
        {
            this.modelo = modelo;
        }
        public int Get_energia()
        {
            return energia;
        }
        public void Set_energia()
        {
            this.energia = energia;
        }
        public int Get_año()
        {
            return año;
        }
        public void Set_año()
        {
            this.año = año;
        }
        public int Get_seFabrica()
        {
            return seFabrica;
        }
        public void Set_seFabrica(int seFabrica)
        {
            this.seFabrica = seFabrica;
        }
        // Mostrar
        public virtual void MostrarInfo()
        {
            Console.WriteLine("Marca: " + Get_marca());
            Console.WriteLine("Modelo: " + Get_modelo());
            string energ = "Ahorra energía.";
            if (VerificarEnergia() == false)
            {
                energ = "No ahorra energía.";
            }
            Console.WriteLine("Energía: " + energ);
            Console.WriteLine("Año de fabricación: " + Get_año());
            string seFabrica = "Se sigue fabricando.";
            if (VerificarFabrica() == false)
            {
                seFabrica = "No se sigue fabricando.";
            }
            Console.WriteLine(seFabrica);
        }
        // Métodos
        public bool VerificarEnergia()
        {
            bool energ = true;
            if (Get_energia() == 2)
            {
                energ = false;
            }
            return energ;
        }
        public bool VerificarFabrica()
        {
            bool fabrica = true;
            if (Get_seFabrica() == 2)
            {
                fabrica = false;
            }
            return fabrica;
        }
        public bool Descatalogados()
        {
            bool descatalogados = false;

            if (Get_seFabrica() == 2)
            {
                descatalogados = true;
            }                
            return descatalogados;
        }
    }
}
