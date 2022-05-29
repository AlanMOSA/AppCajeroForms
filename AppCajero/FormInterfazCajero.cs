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
    public partial class FormInterfazCajero : Form
    {
        public FormInterfazCajero()
        {
            InitializeComponent();
        }

        private void BtnSalirBase_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnVerCliente_Click(object sender, EventArgs e)
        {
            FormRetirarDinero retirarSaldo = new FormRetirarDinero();
            retirarSaldo.ShowDialog();
        }


        private void BtnCuenta_Click(object sender, EventArgs e)
        {
            FrmCuenta VerCuenta = new FrmCuenta();
            VerCuenta.ShowDialog();
        }

        private void BtnInterfazOtros_Click(object sender, EventArgs e)
        {
               FormLoginAdmin login = new FormLoginAdmin();
               login.ShowDialog();   
        }

        private void FormInterfazCajero_Load(object sender, EventArgs e)
        {

        }
    }
}
