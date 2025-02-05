using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueb2Ditritibuidas.Models
{
    public class Instrumento
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public EstadoInstrumento Estado { get; set; }
    }
}