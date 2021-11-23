using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovimientoInventarios.Vista
{
    public partial class frmFacturaDetalle : Form
    {
        public frmFacturaDetalle()
        {
            InitializeComponent();
        }

        private void frmFacturaDetalle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.dataSet2.factura);

        }
    }
}
