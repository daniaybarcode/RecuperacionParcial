using System;
using System.Collections.Generic;
using System.Drawing; // Asegúrate de importar el espacio de nombres para el manejo de colores.
using System.Windows.Forms;
using Pav.Parcial2Rec.Presentacion.Vistas;
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Presentadores;
using SimuladorCotizacion;
using Pav.Parcial2Rec.Dominio.Entidades;

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
        private double _maxCotizacion = double.MinValue;
        private double _minCotizacion = double.MaxValue;

        private CotizacionControl _maxCotizacionControl;
        private CotizacionControl _minCotizacionControl;

        public CotizacionView()
        {
            InitializeComponent();
        }

        public Panel Panel => panel;

        public void MostrarCotizacion(double cotizacion)
        {
            _ultimaCotizacion = cotizacion;

            var cotizacionControl = new CotizacionControl
            {
                FechaHora = DateTime.Now,
                Valor = (decimal)_ultimaCotizacion
            };
            cotizacionControl.Location = new System.Drawing.Point(0, panel.Controls.Count * cotizacionControl.Height);

            if (_ultimaCotizacion > _maxCotizacion)
            {
                if (_maxCotizacionControl != null)
                {
                    _maxCotizacionControl.BackColor = SystemColors.Control;
                }

                _maxCotizacion = _ultimaCotizacion;
                _maxCotizacionControl = cotizacionControl;
                _maxCotizacionControl.BackColor = System.Drawing.Color.Red;
                lblMaxCotizacion.Text = $"Máxima Cotización: {_maxCotizacion}";
            }

            if (_ultimaCotizacion < _minCotizacion)
            {
                if (_minCotizacionControl != null)
                {
                    _minCotizacionControl.BackColor = SystemColors.Control;
                }

                _minCotizacion = _ultimaCotizacion;
                _minCotizacionControl = cotizacionControl;
                _minCotizacionControl.BackColor = System.Drawing.Color.Yellow;
                lblMinCotizacion.Text = $"Mínima Cotización: {_minCotizacion}";
            }

            panel.Controls.Add(cotizacionControl);
        }

        private void btnAgregarCotizacion_Click(object sender, EventArgs e)
        {
            Presentador.IniciarSimulacion();
        }

        private void btnDetenerCotizaciones_Click(object sender, EventArgs e)
        {
            Presentador.DetenerSimulacion();
        }
    }

    public class CotizacionViewWithPresenter : ViewBase<CotizacionPresenter> { }
}