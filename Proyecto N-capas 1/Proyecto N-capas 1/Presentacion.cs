﻿using System;
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

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {




            this.Hide();

            Contactos C = new Contactos();
            C.Show();

           

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
