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
    public partial class FrmCajero : Form
    {
        private static Cajero[] cajeros;

        public FrmCajero()
        {
            InitializeComponent();
            cajeros = new Cajero[100];
        }
        internal static Cajero[] Cajeros { get => cajeros; set => cajeros = value; }

        private void BtnSiguienteCajero_Click(object sender, EventArgs e)
        {
            Cajero cajero = new Cajero();
            cajero.DenominacionMinimaEntregar = txtDenomMinima.TextLength;
            cajero.MontoMaximoEntregar = txtMontoMax.TextLength;
            cajero.CantidadBilleteEntregar = txtCantidadEntregar.TextLength;
            cajero.NumeroBanco = txtNumBanco2.TextLength;
            cajero.NumeroCajero = txtNumCuenta2.TextLength;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void FrmCajero_Load(object sender, EventArgs e)
        {
         
        }
    }
}
