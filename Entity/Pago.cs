using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Pago
    {
        [Key]
        public string IdDePago { get; set; }
        public string  TipoDePago { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal ValorDePago { get; set; }
        public Decimal ValorIva { get; set; }
    }
}