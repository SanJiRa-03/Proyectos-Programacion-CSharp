using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Comprobar que no hay ningún campo vacío
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Por favor, rellene todos los campos.");
            }
            //Si los textBox de las contraseñas son diferentes quiere decir que las contraseñas son incorrectas.
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden, inténtalo de nuevo.");
            }
            else
            {
                //Carga la lista de usuarios existente del archivo
                List<Usuarios> listausuarios = new List<Usuarios>();
                string archivoUsuarios = "usuarios.txt";
                //Comprobamos primero si el fichero existe:
                if (File.Exists(archivoUsuarios))
                {
                    using (StreamReader reader = new StreamReader(archivoUsuarios))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] partes = line.Split(',');
                            //Si la línea contiene exactamente dos partes (usuario y contraseña), crea un nuevo objeto 'Usuarios' y se agrega a la lista.
                            if (partes.Length == 2)
                            {
                                listausuarios.Add(new Usuarios(partes[0], partes[1]));
                            }
                        }
                    }
                }
                //Muestra un mensaje del usuario que acabamos de registrar si se ha hecho correctamente.
                MessageBox.Show("Usuario registrado: " + textBox1.Text);
                //Agrega el nuevo usuario a la lista
                Usuarios nuevoUsuario = new Usuarios(textBox1.Text, textBox2.Text);
                listausuarios.Add(nuevoUsuario);

                //Escribe la lista completa de usuarios en el archivo
                using (StreamWriter writer = new StreamWriter(archivoUsuarios))
                {
                    foreach (Usuarios usuario in listausuarios)
                    {
                        //Escribe el usuario y la contraseña en el archivo separado con una coma.
                        writer.WriteLine(usuario.GetUsuario() + "," + usuario.GetContraseña());
                    }
                }
                //Mostramos el login
                Form2 login = new Form2();
                this.Hide();
                login.Show();
            }            
        }
    }
}