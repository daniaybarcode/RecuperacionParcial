using Pav.Parcial2Rec.Dominio.Entidades;
using Pav.Parcial2Rec.Dominio.Repositorios;
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Tareas;
using Pav.Parcial2Rec.Presentacion.Vistas;
using SimuladorCotizacion;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pav.Parcial2Rec.Presentacion.Presentadores
{
    public class CotizacionPresenter : PresenterBase<CotizacionTarea, ICotizacionView>
    {
        private readonly IRepositorio<Registro> _repositorio;
        private readonly IRepositorio<Cotizacion> _repositorioCotizacion;
        private readonly Simulador _simulador;
        private Registro _registroActual;

        private CotizacionControl _controlMaximoActual;
        private CotizacionControl _controlMinimoActual;

        private double _maxCotizacion = double.MinValue;
        private double _minCotizacion = double.MaxValue;

        public CotizacionPresenter(ICotizacionView vista, IRepositorio<Registro> repositorio, IRepositorio<Cotizacion> repositorioCotizacion) : base(vista)
        {
            _repositorio = repositorio;
            _repositorioCotizacion = repositorioCotizacion;
            _simulador = Simulador.Cotizacion;
            _simulador.CotizacionModificada += Simulador_CotizacionModificada;
        }

        public void IniciarSimulacion()
        {
            _simulador.Conectar(2);
            _registroActual = new Registro
            {
                FechaHoraInicio = DateTime.Now,
            };
            AgregarRegistro(_registroActual);

            // Limpiar el panel antes de agregar nuevos controles
            Vista.Panel.Controls.Clear();
            _controlMaximoActual = null;
            _controlMinimoActual = null;
        }

        public void DetenerSimulacion()
        {
            _simulador.Desconectar();
        }

        private void Simulador_CotizacionModificada(double cotizacion)
        {
            Vista.Invoke(new Action(() => ActualizarVistaConCotizacion(cotizacion)));
        }

        private void ActualizarVistaConCotizacion(double cotizacion)
        {
            // Crear nuevo control de cotización
            var nuevoControl = CrearCotizacionControl(cotizacion);

            // Actualizar máximo y mínimo
            if (cotizacion > _maxCotizacion)
            {
                if (_controlMaximoActual != null)
                {
                    _controlMaximoActual.BackColor = SystemColors.Control; // Restablecer color del control máximo anterior
                }

                _maxCotizacion = cotizacion;
                _controlMaximoActual = nuevoControl;
                _controlMaximoActual.BackColor = Color.Red;
                Vista.ActualizarMaximaCotizacion(_maxCotizacion);
            }
            else if (cotizacion < _minCotizacion)
            {
                if (_controlMinimoActual != null)
                {
                    _controlMinimoActual.BackColor = SystemColors.Control; // Restablecer color del control mínimo anterior
                }

                _minCotizacion = cotizacion;
                _controlMinimoActual = nuevoControl;
                _controlMinimoActual.BackColor = Color.Yellow;
                Vista.ActualizarMinimaCotizacion(_minCotizacion);
            }
            else
            {
                // Si no es ni máximo ni mínimo, solo agregar el control
                Vista.Panel.Controls.Add(nuevoControl);
            }

            var nuevaCotizacion = new Cotizacion
            {
                RegistroId = _registroActual.Id,
                FechaHora = DateTime.Now,
                Valor = (decimal)cotizacion
            };

            AgregarCotizacion(nuevaCotizacion);
        }

        private CotizacionControl CrearCotizacionControl(double cotizacion)
        {
            var cotizacionControl = new CotizacionControl
            {
                FechaHora = DateTime.Now,
                Valor = (decimal)cotizacion,
                BackColor = SystemColors.Control
            };

            // Posicionar el nuevo control
            cotizacionControl.Location = new Point(0, Vista.Panel.Controls.Count * cotizacionControl.Height);
            Vista.Panel.Controls.Add(cotizacionControl);
            cotizacionControl.BringToFront(); // Asegura que el nuevo control se muestre sobre otros controles
            return cotizacionControl;
        }

        public void AgregarRegistro(Registro registro)
        {
            _repositorio.Agregar(registro);
        }

        public void AgregarCotizacion(Cotizacion cotizacion)
        {
            _repositorioCotizacion.Agregar(cotizacion);
        }

        public void ActualizarRegistro(Registro registro)
        {
            _repositorio.Actualizar(registro);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
                _simulador.CotizacionModificada -= Simulador_CotizacionModificada;
            }
        }
    }
}
