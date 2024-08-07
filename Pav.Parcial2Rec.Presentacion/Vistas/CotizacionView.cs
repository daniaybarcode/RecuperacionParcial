using System;
using System.Collections.Generic;
using System.Drawing; // Asegúrate de importar el espacio de nombres para el manejo de colores.
using System.Windows.Forms;
using Pav.Parcial2Rec.Presentacion.Vistas;
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Presentadores;
using SimuladorCotizacion;
using Pav.Parcial2Rec.Dominio.Entidades;

namespace Pav.Parcial2Rec.Presentacion.Vistas
{
    public partial class CotizacionView : CotizacionViewWithPresenter, ICotizacionView
    {
        private double _ultimaCotizacion;
        private double _maxCotizacion = double.MinValue;
        private double _minCotizacion = double.MaxValue;

        private Registro _registroActual;

        private CotizacionControl _maxCotizacionControl;
        private CotizacionControl _minCotizacionControl;

        public CotizacionView()
        {
            InitializeComponent();
        }

        //este método era solo una prueba
        private void btnAgregarCotizacion_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var cotizacionControl = new CotizacionControl
            {
                FechaHora = DateTime.Now,
                Valor = random.Next(100, 1000)
            };
            cotizacionControl.Location = new System.Drawing.Point(0, panel.Controls.Count * cotizacionControl.Height);
            panel.Controls.Add(cotizacionControl);
        }

        private void btnIniciarCotizaciones_Click(object sender, EventArgs e)
        {
            Simulador.Cotizacion.CotizacionModificada += Simulador_CotizacionModificada;
            Simulador.Cotizacion.Conectar(2);
            _registroActual = new Registro
            {
                FechaHoraInicio = DateTime.Now,
            };
            Presentador.AgregarRegistro(_registroActual);
            //MessageBox.Show("hola" + _registroActual.Id);
        }

        private void btnDetenerCotizaciones_Click(object sender, EventArgs e)
        {
            Simulador.Cotizacion.CotizacionModificada -= Simulador_CotizacionModificada;
            Simulador.Cotizacion.Desconectar();
        }

        private void Simulador_CotizacionModificada(double cotizacion)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Simulador_CotizacionModificada(cotizacion)));
                return;
            }

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
                _maxCotizacionControl.BackColor = Color.Red;
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
                _minCotizacionControl.BackColor = Color.Yellow;
                lblMinCotizacion.Text = $"Mínima Cotización: {_minCotizacion}";
            }
            panel.Controls.Add(cotizacionControl);

            Presentador.AgregarCotizacion(new Cotizacion
            {
                RegistroId = _registroActual.Id,
                FechaHora = DateTime.Now,
                Valor = (decimal)_ultimaCotizacion
            });

           // listBoxCotizaciones.Items.Add($"Cotización: {_ultimaCotizacion} - {DateTime.Now}");
        }

        private void Simulador_CotizacionModificadaPrueba(double cotizacion)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Simulador_CotizacionModificadaPrueba(cotizacion)));
                return;
            }

            _ultimaCotizacion = cotizacion;




            listBoxCotizaciones.Items.Add($"Cotización: {_ultimaCotizacion} - {DateTime.Now}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simulador.Cotizacion.CotizacionModificada += Simulador_CotizacionModificadaPrueba;
            Simulador.Cotizacion.Conectar(2);
        }
    }

    public class CotizacionViewWithPresenter : ViewBase<CotizacionPresenter> { }
}
