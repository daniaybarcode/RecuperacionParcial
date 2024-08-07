using Pav.Parcial2Rec.Dominio.Entidades;
using Pav.Parcial2Rec.Dominio.Repositorios;
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Tareas;
using Pav.Parcial2Rec.Presentacion.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Parcial2Rec.Presentacion.Presentadores
{
    public class CotizacionPresenter : PresenterBase<CotizacionTarea, ICotizacionView>
    {
        private readonly IRepositorio<Registro> _repositorio;
        private readonly IRepositorio<Cotizacion> _repositorioCotizacion;
        public CotizacionPresenter(ICotizacionView vista, IRepositorio<Registro> repositorio, IRepositorio<Cotizacion> _repositorioCotizacion) : base(vista)
        {
            _repositorio = repositorio;
            this._repositorioCotizacion = _repositorioCotizacion;
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
        }
    }
}
