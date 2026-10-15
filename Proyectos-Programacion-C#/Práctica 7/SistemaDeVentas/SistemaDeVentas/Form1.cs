using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaDeVentas
{
    public partial class Form1 : Form
    {
        int i = 1;
        int posicion;
        public Form1()
        {
            InitializeComponent();
            limpiar();
        }       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string producto, codigodebarras, denominacion, precio, stock;

            producto = txtproducto.Text;
            codigodebarras = txtcodigodebarras.Text;
            denominacion = txtdenominacion.Text;
            precio = txtprecio.Text;
            stock = txtstock.Text;
            dataGridView1.Rows.Add(i+ "",producto, codigodebarras, denominacion, precio, stock);
            i = i +1;
            limpiar();
            txtproducto.Focus();

            button1.Enabled = true;
            button2.Enabled = false;
            btnGuardar.Enabled = false;
        }
        void limpiar()
        {
            button2.Enabled = false;
            btnGuardar.Enabled = false;
            txtproducto.Text = "";
            txtcodigodebarras.Text = "";
            txtdenominacion.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentRow.Index;
            txtproducto.Text = dataGridView1[1, posicion].Value.ToString();
            txtcodigodebarras.Text = dataGridView1[2, posicion].Value.ToString();
            txtdenominacion.Text = dataGridView1[3, posicion].Value.ToString();
            txtprecio.Text = dataGridView1[4, posicion].Value.ToString();
            txtstock.Text = dataGridView1[5, posicion].Value.ToString();
            button1.Enabled = true;
            button2.Enabled = true;
            btnGuardar.Enabled = true;
            txtproducto.Focus();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*string producto, codigodebarras, denominacion, precio, stock;

            producto = txtproducto.Text;
            codigodebarras = txtcodigodebarras.Text;
            denominacion = txtdenominacion.Text;
            precio = txtprecio.Text;
            stock = txtstock.Text;
            */
            dataGridView1[1, posicion].Value = txtproducto.Text;
            dataGridView1[2, posicion].Value = txtcodigodebarras.Text;
            dataGridView1[3, posicion].Value = txtdenominacion.Text;
            dataGridView1[4, posicion].Value = txtprecio.Text;
            dataGridView1[5, posicion].Value = txtstock.Text;

            MessageBox.Show("Guardado corrrectamente.");

            limpiar();
            txtproducto.Focus();

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(posicion);
            txtproducto.Focus();
            button2.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
