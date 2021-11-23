using CapaVistaSeguridadHSC;
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
    public partial class frmMovimientoInventario : Form
    {
        public frmMovimientoInventario()
        {
            InitializeComponent();
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBitacora form3 = new frmBitacora();
            form3.MdiParent = this.MdiParent;
            form3.Show();
        }

        private void frmMovimientoInventario_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                string user = form.usuario();
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimientoInventarios form3 = new frmMovimientoInventarios();
            form3.MdiParent = this.MdiParent;
            form3.Show();
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bodega form4 = new Bodega();
            form4.MdiParent = this.MdiParent;
            form4.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturaDetalle form5 = new frmFacturaDetalle();
            form5.MdiParent = this.MdiParent;
            form5.Show();
        }
    }
}
