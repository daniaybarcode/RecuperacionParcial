using System;
using System.Drawing;
using System.Windows.Forms;
using Pav.Parcial2Rec.Dominio.Entidades;
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Presentadores;

namespace Pav.Parcial2Rec.Presentacion.Vistas
{
    public partial class CotizacionView : CotizacionViewWithPresenter, ICotizacionView
    {
        private double _ultimaCotizacion;

        public CotizacionView()
        {
            InitializeComponent();
        }

        public Panel Panel => panel;

        public void MostrarCotizacion(double cotizacion, bool esMaxima, bool esMinima)
        {
            _ultimaCotizacion = cotizacion;

            var cotizacionControl = new CotizacionControl
            {
                FechaHora = DateTime.Now,
                Valor = (decimal)_ultimaCotizacion
            };
            cotizacionControl.Location = new Point(0, panel.Controls.Count * cotizacionControl.Height);

            if (esMaxima)
            {
                cotizacionControl.BackColor = Color.Red;
            }
            else if (esMinima)
            {
                cotizacionControl.BackColor = Color.Yellow;
            }

            panel.Controls.Add(cotizacionControl);
            ActualizarLabelCotizacionActual();
        }

        public void ActualizarMaximaCotizacion(double maxCotizacion)
        {
            lblMaxCotizacion.Text = $"Máxima Cotización: {maxCotizacion}";
        }

        public void ActualizarMinimaCotizacion(double minCotizacion)
        {
            lblMinCotizacion.Text = $"Mínima Cotización: {minCotizacion}";
        }

        public void ActualizarCotizacionActual(double cotizacion) // Implementar este método
        {
            _ultimaCotizacion = cotizacion;
            ActualizarLabelCotizacionActual();
        }

        private void ActualizarLabelCotizacionActual()
        {
            lblCotizacionActual.Text = $"Cotización Actual: {_ultimaCotizacion}";
        }

        private void btnAgregarCotizacion_Click(object sender, EventArgs e)
        {
            Presentador.IniciarSimulacion();
        }

        private void btnDetenerCotizaciones_Click(object sender, EventArgs e)
        {
            Presentador.DetenerSimulacion();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }

    public class CotizacionViewWithPresenter : ViewBase<CotizacionPresenter> { }
}
