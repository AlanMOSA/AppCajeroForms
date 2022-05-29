using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCajero
{
    class TarjetaDorada:Tarjeta
    {
        public TarjetaDorada() : base()
        {
            cantidadPerimitida = 5000;
            canitdadBilletes = 40;
        }
    }
}
