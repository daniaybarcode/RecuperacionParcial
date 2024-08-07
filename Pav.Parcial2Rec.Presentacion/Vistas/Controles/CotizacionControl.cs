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
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Location = new System.Drawing.Point(3, 9);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(38, 15);
            this.lblFechaHora.TabIndex = 0;
            this.lblFechaHora.Text = "Fecha";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(200, 9);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(33, 15);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor";
            // 
            // CotizacionControl
            // 
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblFechaHora);
            this.Name = "CotizacionControl";
            this.Size = new System.Drawing.Size(300, 30);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
