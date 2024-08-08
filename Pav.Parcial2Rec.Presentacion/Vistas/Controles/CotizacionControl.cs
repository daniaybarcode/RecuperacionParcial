using System;
using System.Windows.Forms;

namespace Pav.Parcial2Rec.Presentacion.Vistas
{
    public class CotizacionControl : UserControl
    {
        private Label lblFechaHora;
        private Label lblValor;

        public DateTime FechaHora
        {
            get => DateTime.Parse(lblFechaHora.Text);
            set => lblFechaHora.Text = value.ToString("G");
        }

        public decimal Valor
        {
            get => decimal.Parse(lblValor.Text);
            set => lblValor.Text = value.ToString("F2");
        }

        public CotizacionControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblFechaHora = new Label();
            lblValor = new Label();
            SuspendLayout();
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(17, 9);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(38, 15);
            lblFechaHora.TabIndex = 0;
            lblFechaHora.Text = "Fecha";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(189, 9);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 1;
            lblValor.Text = "Valor";
            // 
            // CotizacionControl
            // 
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblValor);
            Controls.Add(lblFechaHora);
            Name = "CotizacionControl";
            Size = new Size(288, 33);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
