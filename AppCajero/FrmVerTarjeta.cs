using System;
using System.Windows.Forms;

namespace AppCajero
{
    public partial class FrmVerTarjeta : Form
    {
        private static Tarjeta[] tarjetas;

        public FrmVerTarjeta()
        {
            InitializeComponent();
            tarjetas = new Tarjeta[100];

        }

        internal static Tarjeta[] Tarjeta { get => tarjetas; set => tarjetas = value; }

        private void FrmVerTarjeta_Load(object sender, EventArgs e)
        {
            CargarTarjeta();
        }

        private void CargarTarjeta()
        {
            if (Tarjeta != null)
            {
                lstvVertarjeta.Items.Clear();
                foreach (Tarjeta tarjeta in Tarjeta)
                {
                    if (tarjeta != null)
                    {
                        ListViewItem item = new ListViewItem(tarjeta.NumeroCliente.ToString());
                        item.SubItems.Add(tarjeta.NumeroTarjeta.ToString());
                        item.SubItems.Add(tarjeta.Nip.ToString());
                        item.SubItems.Add(tarjeta.Cvv.ToString());
                        lstvVertarjeta.Items.Add(item);

                    }
                }
            }
        }
        private void BtnAgregartarjeta_Click(object sender, EventArgs e)
        {
            FrmTarjeta agregar = new FrmTarjeta();
            DialogResult diagoresult = agregar.ShowDialog();
            if (diagoresult == DialogResult.OK)
            {
                CargarTarjeta();
            }
        }

        private void BtnBuscarTarjeta_Click(object sender, EventArgs e)
        {
            ListViewItem auxiliar = new ListViewItem();
            try
            {
                foreach (ListViewItem item in lstvVertarjeta.Items)
                {
                    if (txtBuscadorTarjeta.Text.Trim() == item.SubItems[1].Text.Trim())
                    {
                        auxiliar = (ListViewItem)item.Clone();
                    }
                    lstvVertarjeta.Items.Clear();
                    lstvVertarjeta.Items.Add(auxiliar);
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

        private void BtnEliminarTarjeta_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstvVertarjeta.SelectedItems)
            {
                for (int i = 0; i < FormAdminCajero.clientes.Length; i++)
                {
                    Cliente cliente = FormAdminCajero.clientes[i];
                    if (cliente != null)
                    {
                        if (cliente.NumeroCliente == int.Parse(item.SubItems[0].Text))
                        {
                            FormAdminCajero.clientes[i] = null;
                        }
                    }

                }
            }
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lstvVertarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnModificarTarjeta_Click(object sender, EventArgs e)
        {

        }
    }
}
