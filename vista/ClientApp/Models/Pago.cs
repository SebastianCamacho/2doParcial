using System;
using Entity;

namespace vista
{
     public class PagoInputModel
    {
        public string IdDePago { get; set; }
        public string  TipoDePago { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal ValorDePago { get; set; }
        public Decimal ValorIva { get; set; }
        
    }
    public class PagoViewModel : PagoInputModel
    {
        public PagoViewModel(){ }
        public PagoViewModel(Pago pago)
        {
            IdDePago = pago.IdDePago;
            TipoDePago = pago.TipoDePago;
            Fecha = pago.Fecha;
            ValorDePago = pago.ValorDePago;
            ValorIva = pago.ValorIva;
            
            
        }
    }
}