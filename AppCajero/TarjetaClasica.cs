using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCajero
{
    class TarjetaClasica : Tarjeta
    {
        public TarjetaClasica() : base()
        { 
            cantidadPerimitida = 4000;
            canitdadBilletes = 25;  
        }
    }
}
