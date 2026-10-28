using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruteria
{
    public class Usuarios
    {
        //Atributos
        public string nombreUsuario, contraseña;
        //Constructores
        //Constructor vacío
        public Usuarios() { }
        //Constructor parametrizado
        public Usuarios(string nombreUsuario, string contraseña)
        {
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
        }
        //Mutadores y accesores
        public string GetNombreUsuario()
        {
            return nombreUsuario;
        }
        public void SetNombreUsuario(string nombreUsuario)
        {
            this.nombreUsuario = nombreUsuario;
        }
        public string GetContraseña()
        {
            return contraseña;
        }
        public void SetContraseña(string contraseña)
        {
            this.contraseña = contraseña;
        }
    }
}
