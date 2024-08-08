using Pav.Parcial2Rec.Dominio.Entidades;
using Pav.Parcial2Rec.Dominio.Repositorios;
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Tareas;
using SimuladorCotizacion;
using System;

namespace Pav.Parcial2Rec.Presentacion.Presentadores
{
    public class CotizacionPresenter : PresenterBase<CotizacionTarea, ICotizacionView>
    {
        private readonly IRepositorio<Registro> _repositorio;
        private readonly IRepositorio<Cotizacion> _repositorioCotizacion;
        private readonly Simulador _simulador;
        private Registro _registroActual;

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
            Vista.MostrarCotizacion(cotizacion);

            var nuevaCotizacion = new Cotizacion
            {
                RegistroId = _registroActual.Id,
                FechaHora = DateTime.Now,
                Valor = (decimal)cotizacion
            };

            AgregarCotizacion(nuevaCotizacion);
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
