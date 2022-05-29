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
    public partial class FrmVerBanco : Form
    {
        private static Banco[] bancos;

        public FrmVerBanco()
        {
            InitializeComponent();
            bancos = new Banco[100];
        }

        internal static Banco[] Bancos { get => bancos; set => bancos = value; }

        private void FrmVerBanco_Load(object sender, EventArgs e)
        {
            CargaBanco();
        }

        private void CargaBanco()
        {
            if (Bancos != null)
            {
                ltsvBanco.Items.Clear();
                foreach (Banco banco in Bancos)
                {
                    if (banco != null)
                    {
                        ListViewItem item = new ListViewItem(banco.NumeroCliente.ToString());
                        item.SubItems.Add(banco.Nombre);
                        item.SubItems.Add(banco.NumeroBanco.ToString());// este lo debo cambiar por un string
                        ltsvBanco.Items.Add(item);
                    }
                }
            }
        }
        private void BtnaAgregarBanco_Click(object sender, EventArgs e)
        {
            FrmBanco agregar = new FrmBanco();
            DialogResult dialogresult = agregar.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                CargaBanco();
            }
        }
        private void BtnBuscarBanco_Click(object sender, EventArgs e)
        {
            ListViewItem auxiliar = new ListViewItem();
            try
            {
                foreach (ListViewItem item in ltsvBanco.Items)
                {
                    if (txtBuscadorBanco.Text.Trim() == item.SubItems[1].Text.Trim())
                    {
                        auxiliar = (ListViewItem)item.Clone();
                    }
                    ltsvBanco.Items.Clear();
                    ltsvBanco.Items.Add(auxiliar);
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

        private void BtnEliminarBanco_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult mr = MessageBox.Show("¿Seguro que quieres borrar los datos seleccionados?", "Titulo", botones, MessageBoxIcon.Asterisk);
            if (mr == DialogResult.Yes)
            {
                foreach (ListViewItem item in ltsvBanco.SelectedItems)
                {
                    item.Remove();
                }
            }
        }
      
        void BtnSalirVerBancos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
