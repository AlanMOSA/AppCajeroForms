using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCajero
{
    class Tarjeta
    {
        private int numeroCliente, nip, vigencia, cvv, numeroCuenta, numeroTarjeta;
        protected float cantidadPerimitida;
        protected int canitdadBilletes;

        public Tarjeta()
        {
            numeroCliente = 0;
            nip = 0;
            vigencia = 0;
            cvv = 0;
            numeroCuenta = 0;
            numeroTarjeta = 0;
            cantidadPerimitida = 6000;
            canitdadBilletes = 30;
        }

   
        public Tarjeta(int numeroCuenta)
        {
            numeroCliente = 0;
            numeroTarjeta = 0;
            nip = 0;
            vigencia = 0;
            cvv = 0;
            cantidadPerimitida = 6000;
            canitdadBilletes = 30;
            this.numeroCuenta = numeroCuenta;
        }

        public int NumeroCliente { get => numeroCliente; set => numeroCliente = value; } //este no*/
        public int Nip { get => nip; set => nip = value; }
        public int Vigencia { get => vigencia; set => vigencia = value; }
        public int Cvv { get => cvv; set => cvv = value; }
        public int NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public int NumeroTarjeta { get => numeroTarjeta; set => numeroTarjeta = value; }

        public void Agregar()
        {
            int contador = 0;

            foreach (Tarjeta item in FrmVerTarjeta.Tarjeta)
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
            this.numeroCliente = (contador + 1);
            FrmVerTarjeta.Tarjeta[contador] = this;
        }

    }
}
