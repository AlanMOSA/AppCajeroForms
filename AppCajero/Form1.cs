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
    public partial class Form1 : Form
    {
        //declarando Array de Objetos
        /*int Contador = 0;*/

        public Form1()
        {
            //Todo: Crear arreglo de Cilentes para
            //almacenar el alta de clientes nuevos
            InitializeComponent();
            //BtnAceptar.DialogResult = DialogResult.OK;
            //estableciendo nuemros de elementos en el array
            
            /* for (int i = 0; i < cliente.Length; i++)
             {
                 cliente[i] = new Cliente();
             }*/
        }

        internal Form1(Cliente cliente)
        {
            InitializeComponent();
            txtNombreCliente.Text = cliente.NombreCliente;
            txtEmailCliente.Text = cliente.EmailCliente;
            txtCurp.Text = cliente.Curp;
            txtRFC.Text = cliente.Rfc;
            
        }


        private void BtnAceptar_Click_1(object sender, EventArgs e)
        {
            //Agregar cliente
            Cliente cliente = new Cliente(); // Contador simplificado
            cliente.NombreCliente = txtNombreCliente1.Text;
            cliente.FechadeNacimientoCliente = "";
            cliente.EmailCliente = txtEmailCliente.Text;
            cliente.Curp = txtCurp.Text;
            cliente.Rfc = txtRFC.Text;
            cliente.Agregar(); // Contador simplificado
            MessageBox.Show("Cliente Agregado Correctamente");
            //Para Limpiar los datos
            txtNombreCliente1.Text = "";
            txtEmailCliente.Text = "";
            txtCurp.Text = "";
            txtRFC.Text = "";
            txtFechaNacimiento1.Value = DateTime.Now;
            this.Close();
        }

        private void btnCacnelar1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
