using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwatPortal.Entidades
{
    [Table("Contacto")]
    public partial class Contacto
    {
        public int IdContacto { get; set; }
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public int Id_ciudad { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public bool Estado { get; set; }
    }
}
