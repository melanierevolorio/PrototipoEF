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
    public partial class frmMovimientoInventarios : Form
    {
        public frmMovimientoInventarios()
        {
            InitializeComponent();
        }

        private void frmMovimientoInventarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dataSet1.producto);

        }
    }
}
