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
    public partial class FrmCuenta : Form
    {
        Cliente cliente = new Cliente();

        public FrmCuenta()
        {
            InitializeComponent();
        }

        internal  FrmCuenta(Cliente cliente)
        {
            InitializeComponent();

            int numeroCuenta = int.Parse(LblNumCuenta.Text);
            FormAdminCajero.cuentas[numeroCuenta - 1] = new Cuenta();
            FormAdminCajero.cuentas[numeroCuenta - 1].NumeroCliente = cliente.NumeroCliente;
            FormAdminCajero.cuentas[numeroCuenta - 1].NumeroBanco = 1;

            //FormAdminCajero.cuentas[numeroCuenta - 1] = new Cuenta();
            //FormAdminCajero.cuentas[numeroCuenta - 1] = new Cuenta();
            //FormAdminCajero.cuentas[numeroCuenta - 1] = new Cuenta();

        }

        private void BtnSiguienteCuenta_Click(object sender, EventArgs e)
        {

            Cuenta cuenta1 = new Cuenta();
            cuenta1.Clave = txtClave.TextLength;
            this.Close();

        
            //Cuenta cuenta1 = new Cuenta();
            //cuenta1.NumeroCuenta = txtNumeroCuenta.TextLength;
            //cuenta1.Clave = txtClave.TextLength;
            //cuenta1.Saldo = txtSaldo.TextLength;
            //cuenta1.NumeroBanco = txtNumeroBanco.TextLength;
            //this.Close();
        }

        private void BtnCancelarCuenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmCuenta_Load(object sender, EventArgs e)
        {
            int contador = 1;
            if (FormAdminCajero.cuentas != null)
            {
                foreach (Cuenta cuenta in FormAdminCajero.cuentas)
                {
                    if (cuenta != null)
                    {
                        contador++;
                    }
                    else
                    {
                        break;
                    }
                }
                     LblNumeroCuenta.Text = contador.ToString();
            }
        }








    }
}