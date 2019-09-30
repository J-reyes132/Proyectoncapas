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
    public partial class alertacontactos : Form
    {
        public alertacontactos()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
