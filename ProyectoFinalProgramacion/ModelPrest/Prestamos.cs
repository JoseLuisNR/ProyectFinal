using System;
using System.Collections.Generic;
using System.Text;

namespace ModelPrest
{
    class Prestamos
    {
        public int IdPrestamo { get; set; }
        public string IdEstudiante { get; set; }
        public string IdLibro { get; set; }
        public string FechaPrestado { get; set; }
        public string FechaEntregar { get; set; }
    }
}
