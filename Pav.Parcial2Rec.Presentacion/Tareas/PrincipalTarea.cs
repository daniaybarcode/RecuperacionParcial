using Pav.Parcial2Rec.Presentacion.Presentadores;
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Tareas;

namespace Pav.Parcial2Rec.Presentacion.Tareas
{
    public class PrincipalTarea : TaskBase
    {
        public PrincipalTarea(Navigator navigator) : base(navigator)
        {
        }

        public override void Iniciar()
        {
            Navigator.NavegarA<PrincipalPresenter>();
        }
    }
}
