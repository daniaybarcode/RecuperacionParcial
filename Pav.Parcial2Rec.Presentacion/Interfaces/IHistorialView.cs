using System;
using System.Collections.Generic;
using Pav.Parcial2Rec.Dominio.Entidades;

namespace Pav.Parcial2Rec.Presentacion.Interfaces
{
    public interface IHistorialView : IView
    {
        void MostrarHistorial(List<Registro> registros);
    }
}
