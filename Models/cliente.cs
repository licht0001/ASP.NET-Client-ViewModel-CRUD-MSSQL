//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class cliente
    {
        public int id_cli { get; set; }
        public string nombre_cli { get; set; }
        public string cedula_cli { get; set; }
        public string correo { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public byte[] foto { get; set; } 
    }
}
