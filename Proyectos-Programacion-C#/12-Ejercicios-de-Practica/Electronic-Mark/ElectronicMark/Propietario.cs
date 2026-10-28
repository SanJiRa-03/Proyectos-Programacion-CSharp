using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicMark
{
    public class Propietario
    {
        //Atributos
        public string nombre, apellidos, DNI;
        public int numeroAutonomo;
        //Constructores
        //Constructor vacío
        public Propietario() { }
        //Constructor parametrizado
        public Propietario(string nombre, string apellidos, string DNI, int numeroAutonomo)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.DNI = DNI;
            this.numeroAutonomo = numeroAutonomo;
        }
        //Mutadores y accesores
        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }       
        public string GetApellidos()
        {
            return apellidos;
        }
        public void SetApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }
        public string GetDni()
        {
            return DNI;
        }
        public void SetDni(string DNI)
        {
            this.DNI = DNI;
        }
        public int GetNumeroAutonomo()
        {
            return numeroAutonomo;
        }
        public void SetNumeroAutonomo(int numAutonomo)
        {
            this.numeroAutonomo = numeroAutonomo;
        }
        //Métodos
        public void PedirDatos()
        {
            Console.WriteLine("Inserte su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Inserte sus apellidos: ");
            string apellidos = Console.ReadLine();
            Console.WriteLine("Inserte su DNI: ");
            string DNI = Console.ReadLine();
            Console.WriteLine("Inserte su número de autónomo: ");
            int numeroAutonomo = int.Parse(Console.ReadLine());
        }
        public bool VerificarDatos()
        {
            bool verificado = false;
            
            return verificado;
        }
    }
}
