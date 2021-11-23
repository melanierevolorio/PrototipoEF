using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovimientoInventarios.Modelo
{
    public class InventarioBodega
    {
        public class MovimientoInventarios
        {
            public int idInventarioBodega { get; set; }
            public int idBodega { get; set; }
            public int idProducto { get; set; }
            public string cantidad { get; set; }
        }
    }
}
