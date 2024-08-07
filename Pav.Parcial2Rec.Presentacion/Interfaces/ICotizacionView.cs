using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Windows.Forms;
using Pav.Parcial2Rec.Presentacion.Vistas;

namespace Pav.Parcial2Rec.Presentacion.Interfaces
{
    public interface ICotizacionView : IView
    {
        Panel Panel { get; }

        void Invoke(Action action);
        void MostrarCotizacion(double cotizacion);
    }
}
