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
    public partial class FormLoginAdmin : Form
    {
        public FormLoginAdmin()
        {
            InitializeComponent();
        }

        private void BtnCancelarAdmin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnSiguienteAdmin_Click(object sender, EventArgs e)
        {
            string usuario;
            string clave;

            usuario = textUsuarioAdmin.Text.Trim();
            clave = textClaveAdmin.Text.Trim();
            if (usuario == "" && clave == "") 
            {
                MessageBox.Show("Introduce el Usuario y Clave");
            }
            else
            {
                if (usuario == "Alan" && clave == "1234")
                {
                    FormAdminCajero Admin = new FormAdminCajero();
                    Admin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acceso Denegado");
                } 


                
            }
        }

        private void FormLoginAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
