using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace Entity
{
    public class Persona
    {
        [Key]
        public string NumeroDeDocumento { get; set; }
        public string TipoDeDocumento { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Pais { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }

        
    }
}