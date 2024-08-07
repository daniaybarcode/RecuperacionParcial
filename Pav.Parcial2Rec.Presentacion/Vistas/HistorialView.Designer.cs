namespace Pav.Parcial2Rec.Presentacion.Vistas
{
    partial class HistorialView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewRegistros;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.BindingSource registroBindingSource;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewRegistros = new DataGridView();
            bindingSource1 = new BindingSource(components);
            btnCerrar = new Button();
            bindingSource2 = new BindingSource(components);
            bindingSource3 = new BindingSource(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            cantidadCotizacionesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegistros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource3).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRegistros
            // 
            dataGridViewRegistros.AutoGenerateColumns = false;
            dataGridViewRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRegistros.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, cantidadCotizacionesDataGridViewTextBoxColumn, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewRegistros.DataSource = bindingSource3;
            dataGridViewRegistros.Location = new Point(12, 12);
            dataGridViewRegistros.Name = "dataGridViewRegistros";
            dataGridViewRegistros.RowHeadersWidth = 51;
            dataGridViewRegistros.RowTemplate.Height = 24;
            dataGridViewRegistros.Size = new Size(760, 400);
            dataGridViewRegistros.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(697, 430);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // bindingSource2
            // 
            bindingSource2.DataSource = typeof(Dominio.Entidades.Registro);
            // 
            // bindingSource3
            // 
            bindingSource3.DataSource = typeof(Dominio.Entidades.Registro);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "FechaHoraInicio";
            dataGridViewTextBoxColumn1.HeaderText = "FechaHoraInicio";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "FechaHoraFin";
            dataGridViewTextBoxColumn2.HeaderText = "FechaHoraFin";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // cantidadCotizacionesDataGridViewTextBoxColumn
            // 
            cantidadCotizacionesDataGridViewTextBoxColumn.DataPropertyName = "CantidadCotizaciones";
            cantidadCotizacionesDataGridViewTextBoxColumn.HeaderText = "CantidadCotizaciones";
            cantidadCotizacionesDataGridViewTextBoxColumn.Name = "cantidadCotizacionesDataGridViewTextBoxColumn";
            cantidadCotizacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "ValorMaximo";
            dataGridViewTextBoxColumn3.HeaderText = "ValorMaximo";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "ValorMinimo";
            dataGridViewTextBoxColumn4.HeaderText = "ValorMinimo";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            dataGridViewTextBoxColumn5.HeaderText = "Id";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // HistorialView
            // 
            ClientSize = new Size(784, 461);
            Controls.Add(btnCerrar);
            Controls.Add(dataGridViewRegistros);
            Name = "HistorialView";
            Text = "Historial de Registros";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegistros).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource3).EndInit();
            ResumeLayout(false);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn fechaHoraInicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaHoraFinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorMaximoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorMinimoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CantidadCotizaciones;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn cantidadCotizacionesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private BindingSource bindingSource3;
        private BindingSource bindingSource2;
    }
}
