using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovimientoInventarios.Modelo
{
    public class OrdenCompraDetalle
    {
        public class MovimientoInventarios
        {
            public int idOrdenCompraDetalle { get; set; }
            public int idOrdenCOmpra { get; set; }
            public int idInventarioBodega { get; set; }
            public int cantidad { get; set; }
        }
    }
}
