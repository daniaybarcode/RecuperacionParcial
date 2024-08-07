using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Parcial2Rec.Presentacion.Interfaces
{
    public interface IPrincipalView : IView
    {
        event EventHandler IniciarCotizacionClicked;
        event EventHandler VerHistorialClicked;
        event EventHandler VerTablaCotizacionesClicked;
    }
}
