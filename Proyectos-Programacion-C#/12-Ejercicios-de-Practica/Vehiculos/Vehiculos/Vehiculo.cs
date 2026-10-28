using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public abstract class Vehiculo
    {
        protected string marca, matricula;

        public Vehiculo() { }
        public Vehiculo(string marca, string matricula)
        {
            this.marca = marca;
            this.matricula = matricula;
        }
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        public string GetMarca()
        {
            return marca;
        }
        public void SetMatricula(string matricula)
        {
            this.matricula = matricula;
        }
        public string GetMatricula()
        {
            return matricula;
        }
        public virtual void PedirInfo()
        {
            Console.WriteLine("Inserta la marca del vehículo: ");
            marca = Console.ReadLine();
            Console.WriteLine("Inserta la matrícula: ");
            matricula = Console.ReadLine();
        }
        public virtual void MostrarInfo()
        {
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Matrícula: " + matricula);
        }
        public virtual string EscribirFichero()
        {
            char sep = ';';
            string s = (marca + sep + matricula);
            return s;
        }
    }
}
