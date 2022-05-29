using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCajero
{
    class Cliente
    {
        private int numeroCliente;
        private string nombreCliente, fechadeNacimientoCliente, emailCliente, rfc, curp;

       
        public Cliente()
        {
            numeroCliente = 0;
            nombreCliente = "";
            fechadeNacimientoCliente = "";
            emailCliente = "";
            rfc = "";
            curp = "";
        }

        public int NumeroCliente { get => numeroCliente; set => numeroCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string FechadeNacimientoCliente { get => fechadeNacimientoCliente; set => fechadeNacimientoCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Rfc { get => rfc; set => rfc = value; }
        public string Curp { get => curp; set => curp = value; }

        public void Agregar()
        {
            int contador = 0;

            foreach (Cliente item in FormAdminCajero.clientes)
            {      
                if(item != null)
                {
                    contador++;
                }
                else
                {
                    break;
                }
            }
            this.numeroCliente = (contador + 1);
            FormAdminCajero.clientes[contador] = this;
        }
    }
}
