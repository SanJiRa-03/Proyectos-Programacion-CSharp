using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Simon
{
    public partial class Form1 : Form
    {
        //Variables
        int cont = 0;
        Random random;
        bool secuencia = false;
        List<int> lista;

        public Form1()
        {
            //En random se guardan números generados aleatoriamente.
            random = new Random();

            //Lista que guarda valores int de las secuencias generadas.
            lista = new List<int>();

            InitializeComponent();
        }

        //Esta función se encarga de mostrar las secuencias generadas en la ventana de juego, iluminando los cuadrados en un patrón específico.
        public async Task Simon_Secuencias()
        {
            secuencia = true;

            await Task.Delay(200);

            //Creamos un foreach para recorrer la lista de secuencias.
            foreach (int i in lista)
            {
                //Un switch que muestra la imagen iluminada del color correspondiente.
                switch (i)
                {
                    case 1:
                        //Nota: el Task.Delay sirve para esperar x milisegundos sin bloquear la interfaz, en este caso 200.
                        pictureBox_1.Image = Properties.Resources.cr2;
                        await Task.Delay(200);
                        pictureBox_1.Image = Properties.Resources.cr1;
                        break;

                    case 2:
                        pictureBox_2.Image = Properties.Resources.cam2;
                        await Task.Delay(200);
                        pictureBox_2.Image = Properties.Resources.cam1;
                        break;

                    case 3:
                        pictureBox_3.Image = Properties.Resources.cv2;
                        await Task.Delay(200);
                        pictureBox_3.Image = Properties.Resources.cv1;
                        break;

                    case 4:
                        pictureBox_4.Image = Properties.Resources.ca2;
                        await Task.Delay(200);
                        pictureBox_4.Image = Properties.Resources.ca1;
                        break;
                }

                await Task.Delay(200);
            }

            secuencia = false;
        }

        //Esta función se usa para verificar si el usuario ha seleccionado la secuencia correcta.
        public void Verificar_Secuencia(int btn_presionado)
        {
            if (secuencia || lista.Count == 0 || cont >= lista.Count)
            {
                return;
            }

            if (btn_presionado == lista[cont])
            {
                cont++;

                //Actualizamos el label2 con la puntuación.
                label2.Text = "Points: " + cont;

                if (cont == lista.Count)
                {
                    MessageBox.Show("¡Has completado la secuencia! Pulsa New Game para continuar.");
                }
            }
            else
            {
                MessageBox.Show("Fallo! Fin de la partida");

                cont = 0;
                lista.Clear();

                label2.Text = "Points: 0";
            }
        }

        //Añadimos las funciones al botón de "New Game".
        private async void button1_Click(object sender, EventArgs e)
        {
            if (secuencia)
            {
                return;
            }

            //Comprobamos que el jugador haya completado la secuencia antes de continuar.
            if (lista.Count > 0 && cont < lista.Count)
            {
                MessageBox.Show("Debes completar la secuencia actual antes de continuar.");
                return;
            }

            //Añadimos al label2 que es el de puntuación un contador para que vaya incrementando la puntuación del usuario.
            label2.Text = "Points: " + cont;

            //Añadimos un nuevo color aleatorio a la secuencia.
            lista.Add(random.Next(1, 5));

            cont = 0;

            await Simon_Secuencias();
        }

        //Función en el botón "Exit" para que salga del programa de forma correcta.
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Eventos para que al hacer click en x cuadrado se cambie de color para dar la sensación de "seleccionado".
        //Cuadrado rojo seleccionado
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (secuencia)
            {
                return;
            }

            pictureBox_1.Image = Properties.Resources.cr2;
        }

        //Cuadrado rojo
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (secuencia)
            {
                return;
            }

            pictureBox_1.Image = Properties.Resources.cr1;
        }

        //Cuadrado amarillo seleccionado
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (secuencia)
            {
                return;
            }

            pictureBox_2.Image = Properties.Resources.cam2;
        }

        //Cuadrado amarillo
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (secuencia)
            {
                return;
            }

            pictureBox_2.Image = Properties.Resources.cam1;
        }

        //Cuadrado verde seleccionado
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (secuencia)
            {
                return;
            }

            pictureBox_3.Image = Properties.Resources.cv2;
        }

        //Cuadrado verde
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            if (secuencia)
            {
                return;
            }

            pictureBox_3.Image = Properties.Resources.cv1;
        }

        //Cuadrado azul seleccionado
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if (secuencia)
            {
                return;
            }

            pictureBox_4.Image = Properties.Resources.ca2;
        }

        //Cuadrado azul
        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            if (secuencia)
            {
                return;
            }

            pictureBox_4.Image = Properties.Resources.ca1;
        }

        //Se utiliza para manejar los eventos de clic de los cuadrados de colores.
        private void pb1_Click(object sender, EventArgs e)
        {
            if (secuencia)
            {
                return;
            }

            if (sender == pictureBox_1)
            {
                Verificar_Secuencia(1);
            }
            else if (sender == pictureBox_2)
            {
                Verificar_Secuencia(2);
            }
            else if (sender == pictureBox_3)
            {
                Verificar_Secuencia(3);
            }
            else if (sender == pictureBox_4)
            {
                Verificar_Secuencia(4);
            }
        }
    }
}