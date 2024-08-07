using Pav.Parcial2Rec.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Parcial2Rec.Presentacion.Tareas
{
    public class CotizacionTarea : TaskBase
    {
        public CotizacionTarea(Navigator navigator) : base(navigator)
        {
        }

        public override void Iniciar()
        {
            Navigator.NavegarA<CotizacionPresenter>();
        }
    }
}
