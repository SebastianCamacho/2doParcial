using System;
using System.Collections.Generic;
using System.Linq;
using Datos;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace Logica
{
    public class PagoService
    {
        private readonly RegistrosContext _context;
        public PagoService(RegistrosContext context)
        {
            _context = context;
        }
        public GuardarPagoResponse Guardar(Pago pago)
        {
            try
            {
                var PagoBuscado = _context.Pagos.Find(pago.IdDePago);
                if (PagoBuscado != null)
                {
                    return new GuardarPagoResponse("Error, el Pago ya se encuentra registrado.");
                }

                _context.Pagos.Attach(pago);
                _context.Pagos.Add(pago);
                _context.SaveChanges();

                return new GuardarPagoResponse(pago);
            }
            catch (Exception e)
            {
                return new GuardarPagoResponse($"Error de la Aplicacion: {e.Message}");
            }
        }



        public Pago BuscarPorNumeroDeDocumento(string IdDePago)
        {
            Pago pago = _context.Pagos.Find(IdDePago);
            return pago;
        }

        public int Totalizar()
        {
            return _context.Pagos.Count();
        }
        public List<Pago> ConsultarTodos()
        {
            List<Pago> pagos = _context.Pagos.Include("persona").ToList();
            return pagos;
        }

    }
    public class GuardarPagoResponse
    {
        public GuardarPagoResponse(Pago pago)
        {
            Error = false;
            Pago = pago;
        }
        public GuardarPagoResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Pago Pago { get; set; }
    }
}


