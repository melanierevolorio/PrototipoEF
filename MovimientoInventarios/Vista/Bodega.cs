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
    public partial class Bodega : Form
    {
        public Bodega()
        {
            InitializeComponent();
        }

        private void Bodega_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet8.bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter1.Fill(this.dataSet8.bodega);
            // TODO: esta línea de código carga datos en la tabla 'dataSet7.bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.dataSet7.bodega);
            // TODO: esta línea de código carga datos en la tabla 'dataSet6.inventariobodega' Puede moverla o quitarla según sea necesario.
            this.inventariobodegaTableAdapter.Fill(this.dataSet6.inventariobodega);

        }
    }
}
