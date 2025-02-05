    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueb2Ditritibuidas.Models
{
    public class HistorialPrestamo
    {
        public string CodigoInstrumento { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public string Músico { get; set; }
        public EstadoInstrumento EstadoAntes { get; set; }
        public EstadoInstrumento EstadoDespues { get; set; }
    }
}