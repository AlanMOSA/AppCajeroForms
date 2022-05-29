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
    public partial class FormInicioCajero : Form
    {
        public FormInicioCajero()
        {
            InitializeComponent();
        }

        private void btnSiguienteInicioCajero_Click(object sender, EventArgs e)
        {
            string LoginInicio, LoginInicio2;
            LoginInicio = txtNumeroNipInicio.Text.Trim();
            LoginInicio2 = txtNumTarjetaInicio.Text.Trim();

            if (LoginInicio == "")
            {
                MessageBox.Show("Introduce los datos");
            }
            else
            {
                FormInterfazCajero interfaz = new FormInterfazCajero();
                interfaz.ShowDialog();
            }
        }

        private void btnCancelarInicioCajero_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormInicioCajero_Load(object sender, EventArgs e)
        {

        }
    }
}
