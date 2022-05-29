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
    public partial class FrmVerCliente : Form
    {
        public FrmVerCliente()
        {
            InitializeComponent();
        }
        
        private void FrmVerCliente_Load(object sender, EventArgs e)
        {
            CargaClientes();
        }

        private void CargaClientes()
        {
            if (FormAdminCajero.clientes != null)
            {
                lstvCliente.Items.Clear();

                foreach (Cliente cliente in FormAdminCajero.clientes)
                {
                    if (cliente != null)
                    {
                        ListViewItem item = new ListViewItem(cliente.NumeroCliente.ToString());
                        item.SubItems.Add(cliente.NombreCliente);
                        item.SubItems.Add(cliente.EmailCliente);
                        item.SubItems.Add(cliente.Rfc);
                        item.SubItems.Add(cliente.Curp);
                        lstvCliente.Items.Add(item);
                    }
                }
            }

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ListViewItem auxiliar = new ListViewItem();
            try
            {
                foreach (ListViewItem item in lstvCliente.Items)
                {
                    if (txtBuscador.Text.Trim() == item.SubItems[1].Text.Trim())
                    {
                        auxiliar = (ListViewItem)item.Clone();
                    }
                    lstvCliente.Items.Clear();
                    lstvCliente.Items.Add(auxiliar);
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

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            Form1 agregar = new Form1();
            DialogResult diagoresult = agregar.ShowDialog();
            if (diagoresult == DialogResult.OK)
            {
                CargaClientes();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult mr = MessageBox.Show("seguro que quieres borrar los datos seleccionados", "Titulo", botones, MessageBoxIcon.Asterisk);

            if (mr == DialogResult.Yes)
            {
                foreach (ListViewItem item in lstvCliente.SelectedItems)
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
                CargaClientes();
            }

        }


        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (lstvCliente.SelectedItems.Count == 1)
            {
                ListViewItem item = lstvCliente.SelectedItems[0];
                Cliente clienteModificar = new Cliente();
                foreach (Cliente cliente in FormAdminCajero.clientes)
                {
                    if (cliente.NumeroCliente == int.Parse(item.SubItems[0].Text))
                    {
                        clienteModificar = cliente;
                        break;
                    }
                }
                if (clienteModificar.NumeroCliente > 0)
                {
                    Form1 frm = new Form1(clienteModificar);
                    DialogResult dialogResult = frm.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        CargaClientes();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un cliente por favor");
            }
        }
    
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lstvCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        //////////Pendiente
    }
}
