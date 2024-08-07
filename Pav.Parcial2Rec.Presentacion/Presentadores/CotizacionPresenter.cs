using Pav.Parcial2Rec.Dominio.Entidades;
using Pav.Parcial2Rec.Dominio.Repositorios;
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Tareas;
using Pav.Parcial2Rec.Dominio.Servicios;
using System;

namespace Pav.Parcial2Rec.Presentacion.Presentadores
{
    public class CotizacionPresenter : PresenterBase<CotizacionTarea, ICotizacionView>
    {
        private readonly IRepositorio<Registro> _repositorio;
        private readonly IRepositorio<Cotizacion> _repositorioCotizacion;
        private readonly SimulacionService _simulacionService;
        private Registro _registroActual;

        public CotizacionPresenter(ICotizacionView vista, IRepositorio<Registro> repositorio, IRepositorio<Cotizacion> repositorioCotizacion, SimulacionService simulacionService) : base(vista)
        {
            _repositorio = repositorio;
            _repositorioCotizacion = repositorioCotizacion;
            _simulacionService = simulacionService;
            _simulacionService.CotizacionModificada += SimulacionService_CotizacionModificada;
        }

        public void IniciarSimulacion()
        {
            _simulacionService.Conectar();
            _registroActual = new Registro
            {
                FechaHoraInicio = DateTime.Now,
            };
            AgregarRegistro(_registroActual);
        }

        public void DetenerSimulacion()
        {
            _simulacionService.Desconectar();
        }

        private void SimulacionService_CotizacionModificada(double cotizacion)
        {
            Vista.Invoke(new Action(() => ActualizarVistaConCotizacion(cotizacion)));
        }

        private void ActualizarVistaConCotizacion(double cotizacion)
        {
            // Lógica para actualizar la vista con la nueva cotización
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
                _simulacionService.CotizacionModificada -= SimulacionService_CotizacionModificada;
            }
        }
    }
}
