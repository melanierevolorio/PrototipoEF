﻿using System;
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
    public partial class frmOrdenCompra : Form
    {
        public frmOrdenCompra()
        {
            InitializeComponent();
        }

        private void frmOrdenCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet9.ordencompra' Puede moverla o quitarla según sea necesario.
            this.ordencompraTableAdapter.Fill(this.dataSet9.ordencompra);

        }
    }
}
