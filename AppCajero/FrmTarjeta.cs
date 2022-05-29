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
    public partial class FrmTarjeta : Form
    {
        public FrmTarjeta()
        {
            InitializeComponent();
            BtnAceptarTarjeta.DialogResult = DialogResult.OK;
        }

        private void BtnVerTarjetas_Click(object sender, EventArgs e)
        {
            FrmVerTarjeta vertarjeta = new FrmVerTarjeta();
            vertarjeta.Show();
        }

        private void BtnAceptarTarjeta_Click(object sender, EventArgs e)
        {
            Tarjeta tarjeta = new Tarjeta();
            tarjeta.Cvv = txtCVV.TextLength;
            tarjeta.Nip = txtNIP.TextLength;
            tarjeta.NumeroTarjeta = txtNumTarjeta1.TextLength;
            tarjeta.NumeroCuenta = txtNumCuenta1.TextLength;
            tarjeta.Agregar();
            MessageBox.Show("Tarjeta Agregada Correctamente");
            this.Close();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }
       

        private void FrmTarjeta_Load(object sender, EventArgs e)
        {

        }

       
    }
}
