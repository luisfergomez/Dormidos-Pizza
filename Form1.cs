using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_final_de_progra_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numero = 0;
        int id;

        private void agregarbtn_Click(object sender, EventArgs e)
        {
            string nombre = nom.Text;
            string precio = pre.Text;
            string ubicacion = suc.Text;
            string descripcion = des.Text;

            numero = dataGridView1.Rows.Add();
            dataGridView1.Rows[numero].Cells[0].Value = numero + 1;
            dataGridView1.Rows[numero].Cells[1].Value = nombre;
            dataGridView1.Rows[numero].Cells[2].Value = precio;
            dataGridView1.Rows[numero].Cells[3].Value = ubicacion;
            dataGridView1.Rows[numero].Cells[4].Value = descripcion;

            pizza nuevapizza = new pizza(numero,nombre, precio, ubicacion, descripcion);
            numero = numero + 1;
            MessageBox.Show("Se agrego exitosamente la pizza");

            limpiar();
        }

        private void limpiar()
        {
            nom.Clear();
            pre.Clear();
            suc.Clear();
            des.Clear();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            id = int.Parse(row.Cells[0].Value.ToString());
            nomPed.Text = row.Cells[1].Value.ToString();
            prePed.Text = row.Cells[2].Value.ToString();
            sucPed.Text = row.Cells[3].Value.ToString();
            desPed.Text = row.Cells[4].Value.ToString();
        }

        private void ordenarbtn_Click(object sender, EventArgs e)
        {
            string nombre = nomPed.Text;
            string precio = prePed.Text;
            string ubicacion = sucPed.Text;
            string descripcion = desPed.Text;

            id = dataGridView2.Rows.Add();
            dataGridView2.Rows[id].Cells[0].Value = id + 1;
            dataGridView2.Rows[id].Cells[1].Value = nombre;
            dataGridView2.Rows[id].Cells[2].Value = precio;
            dataGridView2.Rows[id].Cells[3].Value = ubicacion;
            dataGridView2.Rows[id].Cells[4].Value = descripcion;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }
    }
    class pizza
    {

        private int id = 0;
        private string nombre;
        private string precio;
        private string descripcion;
        private string ubicacion;

        public pizza(int id, string nombre, string precio, string sucursal, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.ubicacion = sucursal;
            this.descripcion = descripcion;
        }


    }
}
