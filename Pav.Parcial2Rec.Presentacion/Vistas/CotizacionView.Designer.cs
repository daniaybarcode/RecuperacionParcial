namespace Pav.Parcial2Rec.Presentacion.Vistas
{
    partial class CotizacionView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnIniciarCotizaciones;
        private System.Windows.Forms.Button btnDetenerCotizaciones;
        private System.Windows.Forms.Label lblMaxCotizacion;
        private System.Windows.Forms.Label lblMinCotizacion;

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
            panel = new Panel();
            btnIniciarCotizaciones = new Button();
            btnDetenerCotizaciones = new Button();
            lblMaxCotizacion = new Label();
            lblMinCotizacion = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblCotizacionActual = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.BackColor = SystemColors.Control;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(23, 51);
            panel.Name = "panel";
            panel.Size = new Size(427, 314);
            panel.TabIndex = 0;
            panel.Paint += panel_Paint;
            // 
            // btnIniciarCotizaciones
            // 
            btnIniciarCotizaciones.Anchor = AnchorStyles.None;
            btnIniciarCotizaciones.Location = new Point(162, 381);
            btnIniciarCotizaciones.Name = "btnIniciarCotizaciones";
            btnIniciarCotizaciones.Size = new Size(148, 37);
            btnIniciarCotizaciones.TabIndex = 2;
            btnIniciarCotizaciones.Text = "Iniciar Cotizaciones";
            btnIniciarCotizaciones.UseVisualStyleBackColor = true;
            btnIniciarCotizaciones.Click += btnAgregarCotizacion_Click;
            // 
            // btnDetenerCotizaciones
            // 
            btnDetenerCotizaciones.Anchor = AnchorStyles.None;
            btnDetenerCotizaciones.Location = new Point(162, 424);
            btnDetenerCotizaciones.Name = "btnDetenerCotizaciones";
            btnDetenerCotizaciones.Size = new Size(148, 38);
            btnDetenerCotizaciones.TabIndex = 3;
            btnDetenerCotizaciones.Text = "Detener Cotizaciones";
            btnDetenerCotizaciones.UseVisualStyleBackColor = true;
            btnDetenerCotizaciones.Click += btnDetenerCotizaciones_Click;
            // 
            // lblMaxCotizacion
            // 
            lblMaxCotizacion.Anchor = AnchorStyles.Top;
            lblMaxCotizacion.AutoSize = true;
            lblMaxCotizacion.Font = new Font("Segoe UI", 10F);
            lblMaxCotizacion.Location = new Point(173, 497);
            lblMaxCotizacion.Name = "lblMaxCotizacion";
            lblMaxCotizacion.Size = new Size(127, 19);
            lblMaxCotizacion.TabIndex = 5;
            lblMaxCotizacion.Text = "Máxima Cotización:";
            // 
            // lblMinCotizacion
            // 
            lblMinCotizacion.Anchor = AnchorStyles.None;
            lblMinCotizacion.AutoSize = true;
            lblMinCotizacion.Font = new Font("Segoe UI", 10F);
            lblMinCotizacion.Location = new Point(174, 471);
            lblMinCotizacion.Name = "lblMinCotizacion";
            lblMinCotizacion.Size = new Size(125, 19);
            lblMinCotizacion.TabIndex = 6;
            lblMinCotizacion.Text = "Mínima Cotización:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnIniciarCotizaciones, 0, 3);
            tableLayoutPanel1.Controls.Add(btnDetenerCotizaciones, 0, 4);
            tableLayoutPanel1.Controls.Add(panel, 0, 1);
            tableLayoutPanel1.Controls.Add(lblMinCotizacion, 0, 5);
            tableLayoutPanel1.Controls.Add(lblMaxCotizacion, 0, 6);
            tableLayoutPanel1.Controls.Add(lblCotizacionActual, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.58083057F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5327873F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.05744934F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.477213F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.618499F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.366608F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.366608F));
            tableLayoutPanel1.Size = new Size(473, 553);
            tableLayoutPanel1.TabIndex = 7;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // lblCotizacionActual
            // 
            lblCotizacionActual.Anchor = AnchorStyles.None;
            lblCotizacionActual.AutoSize = true;
            lblCotizacionActual.Location = new Point(186, 26);
            lblCotizacionActual.Name = "lblCotizacionActual";
            lblCotizacionActual.Size = new Size(100, 15);
            lblCotizacionActual.TabIndex = 7;
            lblCotizacionActual.Text = "Cotización Actual";
            // 
            // CotizacionView
            // 
            ClientSize = new Size(473, 553);
            Controls.Add(tableLayoutPanel1);
            Name = "CotizacionView";
            Text = "Cotización";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblCotizacionActual;
    }
}
