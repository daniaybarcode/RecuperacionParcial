using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Pav.Parcial2Rec.Dominio.Entidades;
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Presentadores;

namespace Pav.Parcial2Rec.Presentacion.Vistas
{
    public partial class HistorialView : HistorialViewWithPresenter, IHistorialView
    {
        public HistorialView()
        {
            InitializeComponent();
        }

        public void MostrarHistorial(List<Registro> registros)
        {
            //registroBindingSource.DataSource = registros;
            //bindingSource1.DataSource = registros;
            bindingSource3.DataSource = registros.Select(r => new
            {
                r.Id,
                r.FechaHoraInicio,
                r.FechaHoraFin,
                r.ValorMaximo,
                r.ValorMinimo,
                r.PromedioCotizaciones,
 
                CantidadCotizaciones = r.Cotizaciones.Count
            }).ToList();
        }

        public void MostrarRegistros(List<Registro> registros)
        {
            registroBindingSource.DataSource = registros;
        }
    }

    public class HistorialViewWithPresenter : ViewBase<HistorialPresenter> { }
}
