using Pav.Parcial2Rec.Presentacion.Tareas;
using Pav.Parcial2Rec.Presentacion.Presentadores;

namespace Pav.Parcial2Rec.Presentacion.Tareas
{
    public class HistorialTarea : TaskBase
    {
        public HistorialTarea(Navigator navigator) : base(navigator)
        {
        }

        public override void Iniciar()
        {
            Navigator.NavegarA<HistorialPresenter>();
        }
    }
}
