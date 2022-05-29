using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCajero
{
    class Banco : Tarjeta
    {
        private string nombre;
        private int numeroBanco;

        Tarjeta tarjeta = new Tarjeta();
        

        public Banco()
        {
            nombre = "";
            numeroBanco = 0;
        }
        public Banco(string nombre)
        {
            this.nombre = nombre;
            numeroBanco = 0;
        }

        public int NumeroBanco { get => numeroBanco; set => numeroBanco = value; }
        public string Nombre { get => nombre; set => nombre = value; }


        public new void Agregar()
        {
            int contador = 0;

            foreach (Banco item in FrmVerBanco.Bancos)
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
            FrmVerBanco.Bancos[contador] = this;
        }

    }
}
