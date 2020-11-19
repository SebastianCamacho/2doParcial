using System.Net;
using System.Collections.Generic;
using System.Linq;
using Datos;
using Entity;
using Logica;
using Microsoft.AspNetCore.Mvc;

namespace vista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagoController:ControllerBase
    {
         private readonly PagoService _pagoService;
        public PagoController(RegistrosContext _context)
        {
            _pagoService = new PagoService(_context);
        }

        [HttpGet]
        public IEnumerable<PagoViewModel> Gets()
        {
            var pago = _pagoService.ConsultarTodos().Select(p => new PagoViewModel(p));
            return pago;
        }

        // GET: api/pago/5
        [HttpGet("{IdDePago}")]
        public ActionResult<PagoViewModel> Get(string idDePago)
        {
            var pago = _pagoService.BuscarPorNumeroDeDocumento(idDePago);
            if (pago == null) return NotFound();
            var pagoViewModel = new PagoViewModel(pago);
            return pagoViewModel;
        }

        [HttpPost]
        public ActionResult<PagoViewModel> Post(PagoInputModel pagoInput)
        {
            Pago pago = MapearPago(pagoInput);
            var response = _pagoService.Guardar(pago);
            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Pago);
        }

        private Pago MapearPago(PagoInputModel pagoInput)
        {
            var pago = new Pago
            {
            IdDePago = pagoInput.IdDePago,
            TipoDePago = pagoInput.TipoDePago,
            Fecha = pagoInput.Fecha,
            ValorDePago = pagoInput.ValorDePago,
            ValorIva = pagoInput.ValorIva,
            persona=pagoInput.persona
        };
            return pago;
        }
    }
}