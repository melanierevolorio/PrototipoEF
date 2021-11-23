using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovimientoInventarios.Modelo
{
    public class FacturaDetalle
    {
        public class MovimientoInventarios
        {
            public int idFacturaDetalle { get; set; }
            public int idFactura { get; set; }
            public int idInventarioSucursal { get; set; }
        }
    }
}
