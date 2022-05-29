using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCajero
{
    class Cajero : Cliente
    {

        private int numeroCajero, numeroBanco, cantidadBilleteEntregar, montoMaximoEntregar, denominacionMinimaEntregar;

        public Cajero()
        {
            numeroCajero = numeroBanco = cantidadBilleteEntregar = montoMaximoEntregar = denominacionMinimaEntregar = 0;
        }

        public int NumeroCajero { get => numeroCajero; set => numeroCajero = value; }
        public int NumeroBanco { get => numeroBanco; set => numeroBanco = value; }
        public int CantidadBilleteEntregar { get => cantidadBilleteEntregar; set => cantidadBilleteEntregar = value; }
        public int MontoMaximoEntregar { get => montoMaximoEntregar; set => montoMaximoEntregar = value; }
        public int DenominacionMinimaEntregar { get => denominacionMinimaEntregar; set => denominacionMinimaEntregar = value; }

        public new void Agregar()
        {
            int contador = 0;

            foreach (Cajero item in FrmCajero.Cajeros)
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
            FrmCajero.Cajeros[contador] = this;
        }

    }
}
