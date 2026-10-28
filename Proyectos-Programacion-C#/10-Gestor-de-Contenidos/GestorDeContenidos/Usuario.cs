using System;
using System.IO;

namespace GestorDeContenidos
{
    class Usuario
    {
        private string nombre, contraseña;

        public Usuario() { }
        public Usuario(string nombre, string contraseña)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
        }

        public string Get_Nombre() { return this.nombre; }
        public string Get_Contraseña() { return this.contraseña; }

        public void Set_Nombre(string nombre) { this.nombre = nombre; }
        public void Set_Contraseña(string pswrd) { this.contraseña = pswrd; }   
    }
}
