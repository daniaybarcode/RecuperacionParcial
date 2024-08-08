using System;
using System.Collections.Generic;
using System.Linq;

namespace Pav.Parcial2Rec.Dominio.Entidades
{
    public class Registro : EntityBase
    {
        public DateTime FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }

        public ICollection<Cotizacion> Cotizaciones { get; set; } = new List<Cotizacion>();

        public int CantidadCotizaciones => Cotizaciones.Count;
        public decimal ValorMaximo => Cotizaciones.Any() ? Cotizaciones.Max(c => c.Valor) : 0;

        public decimal ValorMinimo => Cotizaciones.Any() ? Cotizaciones.Min(c => c.Valor) : 0;
        public decimal PromedioCotizaciones => Cotizaciones.Any() ? Cotizaciones.Average(c => c.Valor) : 0;


    }
}
