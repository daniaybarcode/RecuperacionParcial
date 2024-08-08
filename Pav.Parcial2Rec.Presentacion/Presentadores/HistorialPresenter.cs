using System;
using System.Collections.Generic;
using Pav.Parcial2Rec.Dominio.Entidades;
using Pav.Parcial2Rec.Dominio.Repositorios;
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Tareas;

namespace Pav.Parcial2Rec.Presentacion.Presentadores
{
    public class HistorialPresenter : PresenterBase<HistorialTarea, IHistorialView>
    {
        private readonly IRepositorio<Registro> _repositorio;

        public HistorialPresenter(IHistorialView vista, IRepositorio<Registro> repositorio) : base(vista)
        {
            _repositorio = repositorio;
            vista.MostrarHistorial(_repositorio.ListarTodos());
            //CargarHistorial();
        }

        public void CargarHistorial()
        {
            var registros = _repositorio.ListarTodos()
                .Select(registro => new
                {
                    Registro = registro,
                    ValorMaximo = registro.Cotizaciones.Any() ? registro.Cotizaciones.Max(c => c.Valor) : 0,
                    ValorMinimo = registro.Cotizaciones.Any() ? registro.Cotizaciones.Min(c => c.Valor) : 0,
                    PromedioCotizaciones = registro.Cotizaciones.Any() ? registro.Cotizaciones.Average(c => c.Valor) : 0,

                    CantidadCotizaciones = registro.Cotizaciones.Count
                })
                .ToList();

            var registrosConValores = registros.Select(r => new Registro
            {
                Id = r.Registro.Id,
                FechaHoraInicio = r.Registro.FechaHoraInicio,
                FechaHoraFin = r.Registro.FechaHoraFin,
                Cotizaciones = r.Registro.Cotizaciones,
                //PromedioCotizaciones= r.PromedioCotizaciones,
               // ValorMaximo = r.ValorMaximo,
              //  ValorMinimo = r.ValorMinimo
            }).ToList();

            Vista.MostrarHistorial(registrosConValores);
        }


        public void AgregarRegistro(Registro registro)
        {
            _repositorio.Agregar(registro);
            MessageBox.Show("registro Agregado");
            //Vista.MostrarMensaje("registro agregado");
        }


        protected override void Dispose(bool disposing)
        {
            // eliminar el contexto
            _repositorio.Dispose();
            base.Dispose(disposing);
        }
    }
}
