using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_N_capas_1
{
    public partial class Contactos : Form
    {
        public object DataGrid { get; internal set; }

        public Contactos()
        {
            InitializeComponent();

            
        }

        public Contactos(string nombre, string apellido, string edad, string fechanacimiento, string correo, string telefono, string pais, string provincia, string direccion)
        {
            int n = dtgvcontactos.Rows.Add();
            dtgvcontactos.Rows[n].Cells[0].Value = nombre;
            dtgvcontactos.Rows[n].Cells[1].Value = apellido;
            dtgvcontactos.Rows[n].Cells[2].Value = edad;
            dtgvcontactos.Rows[n].Cells[3].Value = fechanacimiento;
            dtgvcontactos.Rows[n].Cells[4].Value = correo;
            dtgvcontactos.Rows[n].Cells[5].Value = telefono;
            dtgvcontactos.Rows[n].Cells[6].Value = pais;
            dtgvcontactos.Rows[n].Cells[7].Value = provincia;
            dtgvcontactos.Rows[n].Cells[8].Value = direccion;
            dtgvcontactos.Rows[n].Cells[8].Value = nombre;




        }

        public void DataGridView1(object sender, DataGridViewCellEventArgs e)
        {
              
        }


      


            public void Button1_Click(object sender, EventArgs e)
        {
            
            
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dtgvcontactos);

            fila.Cells[0].Value = txt_nombre;
            fila.Cells[1].Value = txt_apellido;
            fila.Cells[2].Value = txt_edad;
            fila.Cells[3].Value = txt_fechanacimiento;
            fila.Cells[4].Value = txt_correo;
            fila.Cells[5].Value = txt_telefono;
            fila.Cells[6].Value = txt_pais;
            fila.Cells[7].Value = txt_provincia;
            fila.Cells[8].Value = txt_direccion;
            dtgvcontactos.Rows.Add(fila);


            txt_apellido.Text = "";
            txt_nombre.Text = "";
            txt_edad.Text = "";
            txt_fechanacimiento.Text = "";
            txt_pais.Text = "";
            txt_provincia.Text = "";
            txt_direccion.Text = "";

            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form1 p = new Form1();
            p.Show();

            this.Hide();
        }

        public void Form2_Load(object sender, EventArgs e)
        {

        }
        
        

        private void Button6_Click(object sender, EventArgs e)
        {
            alertacontactos ac = new alertacontactos();
            ac.Show();


        }

        public void dtgvcontactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        { 
            
         }

        private void Button4_Click(object sender, EventArgs e)
        {
            dtgvcontactos.Rows.Remove(dtgvcontactos.CurrentRow);
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dtgvcontactos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
