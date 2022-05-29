using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCajero
{
    public partial class FormRetirarDinero : Form
    {
        public FormRetirarDinero()
        {
            InitializeComponent();
        }

        private void BtnSalirBanco_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormRetirarDinero_Load(object sender, EventArgs e)
        {

        }
    }
}
