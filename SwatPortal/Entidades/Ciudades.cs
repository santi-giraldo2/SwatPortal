using System;
using System.Collections.Generic;

namespace SwatPortal.Entidades
{
    public partial class Ciudades
    {
        public int IdCiudad { get; set; }
        public int? IdDepartamento { get; set; }
        public string Ciudad { get; set; }
        public string Activo { get; set; }
        public string CodigoCiu { get; set; }
    }
}
