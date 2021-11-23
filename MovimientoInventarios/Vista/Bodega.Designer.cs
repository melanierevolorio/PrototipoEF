namespace MovimientoInventarios.Vista
{
    partial class Bodega
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.dataSet6 = new MovimientoInventarios.DataSet6();
            this.inventariobodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventariobodegaTableAdapter = new MovimientoInventarios.DataSet6TableAdapters.inventariobodegaTableAdapter();
            this.dataSet7 = new MovimientoInventarios.DataSet7();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaTableAdapter = new MovimientoInventarios.DataSet7TableAdapters.bodegaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet8 = new MovimientoInventarios.DataSet8();
            this.bodegaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaTableAdapter1 = new MovimientoInventarios.DataSet8TableAdapters.bodegaTableAdapter();
            this.idBodegaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariobodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(325, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "BODEGA";
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "DataSet6";
            this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventariobodegaBindingSource
            // 
            this.inventariobodegaBindingSource.DataMember = "inventariobodega";
            this.inventariobodegaBindingSource.DataSource = this.dataSet6;
            // 
            // inventariobodegaTableAdapter
            // 
            this.inventariobodegaTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet7
            // 
            this.dataSet7.DataSetName = "DataSet7";
            this.dataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "bodega";
            this.bodegaBindingSource.DataSource = this.dataSet7;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBodegaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bodegaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(264, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // dataSet8
            // 
            this.dataSet8.DataSetName = "DataSet8";
            this.dataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bodegaBindingSource1
            // 
            this.bodegaBindingSource1.DataMember = "bodega";
            this.bodegaBindingSource1.DataSource = this.dataSet8;
            // 
            // bodegaTableAdapter1
            // 
            this.bodegaTableAdapter1.ClearBeforeFill = true;
            // 
            // idBodegaDataGridViewTextBoxColumn
            // 
            this.idBodegaDataGridViewTextBoxColumn.DataPropertyName = "idBodega";
            this.idBodegaDataGridViewTextBoxColumn.HeaderText = "idBodega";
            this.idBodegaDataGridViewTextBoxColumn.Name = "idBodegaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // Bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Name = "Bodega";
            this.Text = "Bodega";
            this.Load += new System.EventHandler(this.Bodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariobodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private DataSet6 dataSet6;
        private System.Windows.Forms.BindingSource inventariobodegaBindingSource;
        private DataSet6TableAdapters.inventariobodegaTableAdapter inventariobodegaTableAdapter;
        private DataSet7 dataSet7;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private DataSet7TableAdapters.bodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet8 dataSet8;
        private System.Windows.Forms.BindingSource bodegaBindingSource1;
        private DataSet8TableAdapters.bodegaTableAdapter bodegaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBodegaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}