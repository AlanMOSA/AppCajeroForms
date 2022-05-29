using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCajero
{
    class TarjetaPlateada:Tarjeta
    {
        public TarjetaPlateada() : base()
        {
            cantidadPerimitida = 8000;
            canitdadBilletes = 60;
        }
    }
}
