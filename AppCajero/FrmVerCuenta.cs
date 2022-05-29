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
    public partial class FrmVerCuenta : Form
    {
        private static Cuenta[] cuentas;

        public FrmVerCuenta()
        {
            InitializeComponent();
            cuentas = new Cuenta[100];
        }

        internal static Cuenta[] Cuentas { get => cuentas; set => cuentas = value; }

        private void FrmVerCuenta_Load(object sender, EventArgs e)
        {
            CargaCuenta();
        }

        private void CargaCuenta()
        {
            if (Cuentas != null)
            {
                lstvVercuenta.Items.Clear();

                foreach (Cuenta cuentas in Cuentas)
                {
                    //puede ser nulos y puedes utilizar lo sig:
                    if (cuentas != null)
                    {
                        ListViewItem item = new ListViewItem(cuentas.NumeroCliente.ToString());
                        item.SubItems.Add(cuentas.Clave.ToString());
                    }
                }
            }
        }
       
        private void BtnAgregarCuenta_Click(object sender, EventArgs e)
        {
            FrmCuenta agregar = new FrmCuenta();
            DialogResult diagoresult = agregar.ShowDialog();
            if (diagoresult == DialogResult.OK)
            {
                CargaCuenta();
            }
        }

        private void BtnBuscadorCuenta_Click(object sender, EventArgs e)
        {
            ListViewItem auxiliar = new ListViewItem();
            try
            {
                foreach (ListViewItem item in lstvVercuenta.Items)
                {
                    if (txtBuscadorCuenta.Text.Trim() == item.SubItems[1].Text.Trim())
                    {
                        auxiliar = (ListViewItem)item.Clone();
                    }
                    lstvVercuenta.Items.Clear();
                    lstvVercuenta.Items.Add(auxiliar);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error, No existen elementos");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button3BtnEliminarCuenta_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult mr = MessageBox.Show("¿Seguro que quieres borrar los datos seleccionados?", "Titulo", botones, MessageBoxIcon.Asterisk);
            if (mr == DialogResult.Yes)
            {
                foreach (ListViewItem item in lstvVercuenta.SelectedItems)
                {
                    item.Remove();
                }
            }
        }

        private void BtnSalirCuenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lstvVercuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //otravez >:(
        }

     
    }
}
