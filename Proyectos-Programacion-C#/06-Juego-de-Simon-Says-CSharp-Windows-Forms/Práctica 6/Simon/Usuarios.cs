using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon
{
    internal class Usuarios
    {
        List<Usuarios> usuarios = new List<Usuarios>();
        //Variables
        string usuario, contraseña;
        //Constructores
        //Constructor vacío
        public Usuarios() { }
        //Constructor parametrizado
        public Usuarios(string usuario, string contraseña)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;            
        }
        //Mutadores y accesores
        public void SetUsuario(string usuario)
        {
            this.usuario = usuario;
        }
        public string GetUsuario()
        {
            return this.usuario;
        }
        public void SetContraseña(string contraseña)
        {
            this.contraseña = contraseña;
        }
        public string GetContraseña()
        {
            return this.contraseña;
        }
    }
}
