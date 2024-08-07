using System;

namespace Pav.Parcial2Rec.Dominio.Entidades
{
    public class Cotizacion : EntityBase
    {
        public DateTime FechaHora { get; set; }
        public decimal Valor { get; set; }
        public Guid RegistroId { get; set; }  // Relación con Registro
    }
}
