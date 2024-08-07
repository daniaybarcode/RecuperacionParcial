namespace Pav.Parcial2Rec.Presentacion.Vistas
{
    partial class CotizacionView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnAgregarCotizacion;
        private System.Windows.Forms.Button btnIniciarCotizaciones;
        private System.Windows.Forms.Button btnDetenerCotizaciones;
        private System.Windows.Forms.ListBox listBoxCotizaciones;
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
            btnAgregarCotizacion = new Button();
            btnIniciarCotizaciones = new Button();
            btnDetenerCotizaciones = new Button();
            listBoxCotizaciones = new ListBox();
            lblMaxCotizacion = new Label();
            lblMinCotizacion = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.BackColor = SystemColors.Control;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Location = new Point(23, 90);
            panel.Name = "panel";
            panel.Size = new Size(473, 386);
            panel.TabIndex = 0;
            // 
            // btnAgregarCotizacion
            // 
            btnAgregarCotizacion.Anchor = AnchorStyles.None;
            btnAgregarCotizacion.Location = new Point(548, 578);
            btnAgregarCotizacion.Name = "btnAgregarCotizacion";
            btnAgregarCotizacion.Size = new Size(270, 37);
            btnAgregarCotizacion.TabIndex = 1;
            btnAgregarCotizacion.Text = "Agregar componente aleatorio (Prueba)";
            btnAgregarCotizacion.UseVisualStyleBackColor = true;
            btnAgregarCotizacion.Click += btnAgregarCotizacion_Click;
            // 
            // btnIniciarCotizaciones
            // 
            btnIniciarCotizaciones.Anchor = AnchorStyles.None;
            btnIniciarCotizaciones.Location = new Point(185, 519);
            btnIniciarCotizaciones.Name = "btnIniciarCotizaciones";
            btnIniciarCotizaciones.Size = new Size(148, 40);
            btnIniciarCotizaciones.TabIndex = 2;
            btnIniciarCotizaciones.Text = "Iniciar Cotizaciones";
            btnIniciarCotizaciones.UseVisualStyleBackColor = true;
            btnIniciarCotizaciones.Click += btnIniciarCotizaciones_Click;
            // 
            // btnDetenerCotizaciones
            // 
            btnDetenerCotizaciones.Anchor = AnchorStyles.None;
            btnDetenerCotizaciones.Location = new Point(185, 576);
            btnDetenerCotizaciones.Name = "btnDetenerCotizaciones";
            btnDetenerCotizaciones.Size = new Size(148, 41);
            btnDetenerCotizaciones.TabIndex = 3;
            btnDetenerCotizaciones.Text = "Detener Cotizaciones";
            btnDetenerCotizaciones.UseVisualStyleBackColor = true;
            btnDetenerCotizaciones.Click += btnDetenerCotizaciones_Click;
            // 
            // listBoxCotizaciones
            // 
            listBoxCotizaciones.FormattingEnabled = true;
            listBoxCotizaciones.ItemHeight = 15;
            listBoxCotizaciones.Location = new Point(83, 40);
            listBoxCotizaciones.Name = "listBoxCotizaciones";
            listBoxCotizaciones.Size = new Size(197, 334);
            listBoxCotizaciones.TabIndex = 4;
            // 
            // lblMaxCotizacion
            // 
            lblMaxCotizacion.AutoSize = true;
            lblMaxCotizacion.Font = new Font("Segoe UI", 10F);
            lblMaxCotizacion.Location = new Point(23, 20);
            lblMaxCotizacion.Name = "lblMaxCotizacion";
            lblMaxCotizacion.Size = new Size(127, 19);
            lblMaxCotizacion.TabIndex = 5;
            lblMaxCotizacion.Text = "Máxima Cotización:";
            // 
            // lblMinCotizacion
            // 
            lblMinCotizacion.AutoSize = true;
            lblMinCotizacion.Font = new Font("Segoe UI", 10F);
            lblMinCotizacion.Location = new Point(23, 45);
            lblMinCotizacion.Name = "lblMinCotizacion";
            lblMinCotizacion.Size = new Size(125, 19);
            lblMinCotizacion.TabIndex = 6;
            lblMinCotizacion.Text = "Mínima Cotización:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.5573769F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.4426231F));
            tableLayoutPanel1.Controls.Add(lblMinCotizacion, 0, 1);
            tableLayoutPanel1.Controls.Add(btnDetenerCotizaciones, 0, 4);
            tableLayoutPanel1.Controls.Add(btnIniciarCotizaciones, 0, 3);
            tableLayoutPanel1.Controls.Add(lblMaxCotizacion, 0, 0);
            tableLayoutPanel1.Controls.Add(panel, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 1, 2);
            tableLayoutPanel1.Controls.Add(btnAgregarCotizacion, 1, 4);
            tableLayoutPanel1.Controls.Add(button1, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.8378372F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.1621628F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 424F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.Size = new Size(888, 719);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(listBoxCotizaciones);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(502, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 418);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(105, 22);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 5;
            label1.Text = "Prueba del Simulador";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(608, 525);
            button1.Name = "button1";
            button1.Size = new Size(150, 28);
            button1.TabIndex = 8;
            button1.Text = "Probar el simulador";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CotizacionView
            // 
            ClientSize = new Size(888, 719);
            Controls.Add(tableLayoutPanel1);
            Name = "CotizacionView";
            Text = "Cotización";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Button button1;
    }
}
