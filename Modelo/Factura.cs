using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovimientoInventarios.Modelo
{
    public class Factura
    {
        public class MovimientoInventarios
        {
            public int idFactura { get; set; }
            public DateTime fecha { get; set; }
            public int cantidad { get; set; }
        }
    }
}
