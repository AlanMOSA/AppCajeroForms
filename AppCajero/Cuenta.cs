using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCajero
{
    class Cuenta
    {
        private int numeroCuenta, clave, numeroCliente, numeroBanco;
        float saldo = 0;

        public Cuenta()
        {
            numeroBanco = numeroCuenta = numeroCliente = clave = 0;
            saldo = 0;
        }

        public int NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public int Clave { get => clave; set => clave = value; }
        public int NumeroCliente { get => numeroCliente; set => numeroCliente = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public int NumeroBanco { get => numeroBanco; set => numeroBanco = value; }

        public void Agregar()
        {

            int contador = 0;

            foreach (Cuenta item in FrmVerCuenta.Cuentas)
            {
                if (item != null)
                {
                    contador++;
                }
                else
                {
                    break;
                }
            }
            this.NumeroCliente = (contador + 1);
            FrmVerCuenta.Cuentas[contador] = this;
        }
    }
}
