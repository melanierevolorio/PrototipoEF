using ConexionSQL;
using Dapper;
using MovimientoInventarios.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovimientoInventarios.BD
{
   
    public class ProductoBD
    {
        public ConexionODBC ODBC = new ConexionODBC();

        public List<Producto> mostrarProducto()
        {
            List<Producto> sqlresultado = new List<Producto>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM Producto;";
                sqlresultado = conexionODBC.Query<Producto>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}
