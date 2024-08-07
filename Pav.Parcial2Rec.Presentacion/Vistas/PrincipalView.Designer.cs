﻿namespace Pav.Parcial2Rec.Presentacion.Vistas
{
    partial class PrincipalView
{
    private System.ComponentModel.IContainer components = null;

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
            menuStrip = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            iniciarToolStripMenuItem = new ToolStripMenuItem();
            historialToolStripMenuItem = new ToolStripMenuItem();
            tablaDeCotizacionesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(933, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { iniciarToolStripMenuItem, historialToolStripMenuItem, tablaDeCotizacionesToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(69, 20);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // iniciarToolStripMenuItem
            // 
            iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            iniciarToolStripMenuItem.Size = new Size(141, 22);
            iniciarToolStripMenuItem.Text = "Cotizaciones";
            iniciarToolStripMenuItem.Click += iniciarToolStripMenuItem_Click;
            // 
            // historialToolStripMenuItem
            // 
            historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            historialToolStripMenuItem.Size = new Size(141, 22);
            historialToolStripMenuItem.Text = "Registros";
            // 
            // tablaDeCotizacionesToolStripMenuItem
            // 
            tablaDeCotizacionesToolStripMenuItem.Name = "tablaDeCotizacionesToolStripMenuItem";
            tablaDeCotizacionesToolStripMenuItem.Size = new Size(141, 22);
            tablaDeCotizacionesToolStripMenuItem.Text = "Acerca de";
            // 
            // PrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "PrincipalView";
            Text = "Cotización de Moneda Extranjera";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tablaDeCotizacionesToolStripMenuItem;
}
}
