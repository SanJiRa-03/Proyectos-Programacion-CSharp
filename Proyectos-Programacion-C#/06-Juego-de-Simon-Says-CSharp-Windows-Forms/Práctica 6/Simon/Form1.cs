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
        public void Simon_Secuencias()
        {
            secuencia = true;
            Thread.Sleep(200);
            //Creamos un foreach para recorrer la lista de secuencias.
            foreach (int i in lista)
            {             
                //Un switch que muestra la imagen iluminada del color correspondiente.
                switch (i)
                {
                    case 1:
                        //Nota: el Thread.Sleep sirve para detener la ejecución durante x milisegundos, en este caso 200.
                        pictureBox_1.Image = Properties.Resources.cr2;
                        Thread.Sleep(200);
                        pictureBox_1.Image = Properties.Resources.cr1;
                        break;
                    case 2:
                        pictureBox_2.Image = Properties.Resources.cam2;
                        Thread.Sleep(200);
                        pictureBox_2.Image = Properties.Resources.cam1;
                        break;
                    case 3:
                        pictureBox_3.Image = Properties.Resources.cv2;
                        Thread.Sleep(200);
                        pictureBox_3.Image = Properties.Resources.cv1;
                        break;
                    case 4:
                        pictureBox_4.Image = Properties.Resources.ca2;
                        Thread.Sleep(200);
                        pictureBox_4.Image = Properties.Resources.ca1;
                        break;
                }
                Thread.Sleep(200);
            }
            secuencia = false;
        }
        //Esta función se usa para verificar si el usuario ha seleccionado la secuencia correcta.
        public void Verificar_Secuencia(int btn_presionado)
        {
            if (secuencia == false && lista.Count > 0)
            {
                if (cont == lista.Count)
                {
                    MessageBox.Show("Ganaste el juego! No hay mas secuencias para ti :)");
                    cont = 0;
                    lista.Clear();
                }
                else
                {
                    if (btn_presionado >= lista[cont])
                    {
                        cont++;
                    }
                    else
                    {
                        MessageBox.Show("Fallo! Fin de la partida");
                        cont = 0;
                        lista.Clear();
                    }
                }                
            }
        }
        //Añadimos las funciones al botón de "New Game".
        private void button1_Click(object sender, EventArgs e)
        {
            //Añadimos al label2 que es el de puntuación un contador para que vaya incrementando la puntuación del usuario.
            label2.Text = "Points: " + cont;            
            lista.Add(random.Next(0, 4));
            new Thread(Simon_Secuencias).Start();
            cont = 0;
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
            pictureBox_1.Image = Properties.Resources.cr2;
        }
        //Cuadrado rojo
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox_1.Image = Properties.Resources.cr1;
        }
        //Cuadrado amarillo seleccionado
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox_2.Image = Properties.Resources.cam2;
        }
        //Cuadrado amarillo
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox_2.Image = Properties.Resources.cam1;
        }
        //Cuadrado verde seleccionado
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox_3.Image = Properties.Resources.cv2;
        }
        //Cuadrado verde
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox_3.Image = Properties.Resources.cv1;
        }
        //Cuadrado azul seleccionado
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox_4.Image = Properties.Resources.ca2;
        }
        //Cuadrado azul
        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox_4.Image = Properties.Resources.ca1;
        }
        //Se utiliza para manejar los eventos de clic de los cuadrados de colores.
        private void pb1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;            

            Verificar_Secuencia(int.Parse(pictureBox.Name.ToString().Split('_')[1]));
        }
    }
}
