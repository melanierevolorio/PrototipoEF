using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovimientoInventarios.Modelo
{
    public class InventarioSucursal
    {
        public class MovimientoInventarios
        {
            public int idInventarioSucursal { get; set; }
            public int idSucursal { get; set; }
            public int idProducto { get; set; }
            public int cantidad { get; set; }
        }
    }
}
