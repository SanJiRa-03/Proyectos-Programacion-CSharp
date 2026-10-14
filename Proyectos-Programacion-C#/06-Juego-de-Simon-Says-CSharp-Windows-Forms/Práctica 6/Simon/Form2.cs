using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Simon
{
    public partial class Form2 : Form
    {
        //Variables
        bool usuarioEncontrado = false;
        //Lista de usuarios.
        List<Usuarios> usuarios = new List<Usuarios>();

        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Comprobar que no hay ningún campo vacío
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Por favor, rellene todos los campos.");
            }
            else
            {
                //Establecemos cada variable a su textBox correspondiente:
                string usuario = textBox1.Text;
                string contraseña = textBox2.Text;
                //Creamos un bool que sea true cuando el usuario se haya encontrado en la lista de usuarios.
                bool usuarioEncontrado = false;
                //Creamos un archivo .txt con la función StreamReader.
                using (StreamReader reader = new StreamReader("usuarios.txt"))
                {
                    string linea;
                    //Si la 
                    while ((linea = reader.ReadLine()) != null)
                    {
                        //Dividimos con ',' el usuario y la contraseña.
                        string[] partes = linea.Split(',');
                        //Usuario se encuantra en la primera posición del array.
                        string usuarioGuardado = partes[0];
                        //Contraseña se encuentra en la segunda posición del array.
                        string contraseñaGuardada = partes[1];
                        //Si el usuario introducido es igual al guardado en la lista y también la contraseña, usuarioEncontrado es true y muestra el juego.
                        if (usuario == usuarioGuardado && contraseña == contraseñaGuardada)
                        {
                            usuarioEncontrado = true;
                            Form1 juego = new Form1();
                            this.Hide();
                            juego.Show();
                            break;
                        }
                    }
                }
                //De otro modo si no lo encuentra, muestra el siguiente mensaje:
                if (!usuarioEncontrado)
                {
                    MessageBox.Show("No existe ese usuario o la contraseña es incorrecta.");
                }

            }
        }           
        //Botón de nuevo usuario muestra el Form3.
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 login = new Form3();
            this.Hide();
            login.Show();
        }
    }
}


