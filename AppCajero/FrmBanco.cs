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
    public partial class FrmBanco : Form
    {
        public FrmBanco()
        {
            InitializeComponent();
            //BtnSiguienteBanco.DialogResult = DialogResult.OK;

        }

        private void BtnSiguienteBanco_Click(object sender, EventArgs e)
        {
            Banco banco1 = new Banco();
            banco1.Nombre = txtNombreBanco.Text;
            banco1.NumeroBanco = txtNumeroBanco.TextLength;
            banco1.Agregar();
            MessageBox.Show("Numero de Banco Agregado Correctamente");
            txtNombreBanco.Text = "";
            txtNumeroBanco.Text = "";
            this.Close();
        }

        private void BtnSalirBanco_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmBanco_Load(object sender, EventArgs e)
        {

        }
    }
}
