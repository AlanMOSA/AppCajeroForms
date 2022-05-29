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
    public partial class FormAdminCajero : Form
    {
        internal static Cliente[] clientes;
        internal static Cuenta[] cuentas;

        public FormAdminCajero()
        {
            InitializeComponent();
            FormAdminCajero.clientes = new Cliente[100];
            FormAdminCajero.cuentas = new Cuenta[100];
        }

        private void BtnClientesAdmin_Click(object sender, EventArgs e)
        {
            FrmVerCliente Verclientes = new FrmVerCliente();
            Verclientes.ShowDialog();
        }

        private void BtnTarjetaAdmin_Click(object sender, EventArgs e)
        {
            FrmVerTarjeta tarjeta = new FrmVerTarjeta();
            tarjeta.ShowDialog();
        }

        private void BtnBancosAdmin_Click(object sender, EventArgs e)
        {
            FrmVerBanco VerBanco = new FrmVerBanco();
            VerBanco.ShowDialog();
        }

        private void btnSalirAdmin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormAdminCajero_Load(object sender, EventArgs e)
        {

        }
    }
}
