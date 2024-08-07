using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Tareas;
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Presentadores;
using Pav.Parcial2Rec.Presentacion.Tareas;
using System.Collections.Generic;

namespace Pav.Parcial2Rec.Presentacion.Presentadores
{
    public class PrincipalPresenter : PresenterBase<PrincipalTarea, IPrincipalView>
    {
        public PrincipalPresenter(IPrincipalView vista) : base(vista)
        {
            Vista!.IniciarCotizacionClicked += Vista_IniciarCotizacionClicked;
            Vista.VerHistorialClicked += Vista_VerHistorialClicked;
            Vista.VerTablaCotizacionesClicked += Vista_VerTablaCotizacionesClicked;
        }

        private void Vista_IniciarCotizacionClicked(object? sender, EventArgs e)
        {
            Tarea!.Navigator.NavegarA<CotizacionPresenter>(true);
        }

        private void Vista_VerHistorialClicked(object? sender, EventArgs e)
        {
            Tarea!.Navigator.NavegarA<HistorialPresenter>(true);
        }

        private void Vista_VerTablaCotizacionesClicked(object? sender, EventArgs e)
        {
           // Tarea!.Navigator.NavegarA<TablaCotizacionesPresenter>(true);
        }
    }
}
