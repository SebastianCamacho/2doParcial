using System.Collections.Generic;
using System.Linq;
using Datos;
using Entity;
using Logica;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using vista;

namespace vista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly PersonaService _personaService;
        public PersonaController(RegistrosContext _context)
        {
            _personaService = new PersonaService(_context);
        }
        
        [HttpGet]
        public IEnumerable<PersonaViewModel> Get()
        {
            var personas = _personaService.ConsultarTodos().Personas.Select(p => new PersonaViewModel(p));
            return personas;
        }

        // GET: api/Persona/5
        [HttpGet("{numeroDeDocumento}")]
        public ActionResult<PersonaViewModel> Get(string numeroDeDocumento)
        {
            var persona = _personaService.BuscarPorNumeroDeDocumento(numeroDeDocumento);
            if (persona == null) return NotFound();
            var personaViewModel = new PersonaViewModel(persona);
            return personaViewModel;
        }
        [HttpPost]
        public ActionResult<PersonaViewModel> Post(PersonaInputModel personaInput)
        {
            Persona persona = MapearPersona(personaInput);
            var response = _personaService.Guardar(persona);
            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Persona);
        }

        private Persona MapearPersona(PersonaInputModel personaInput)
        {
            var persona = new Persona
            {
                NumeroDeDocumento = personaInput.NumeroDeDocumento,
            TipoDeDocumento = personaInput.TipoDeDocumento,
            Nombre = personaInput.Nombre,
            Direccion = personaInput.Direccion,
            Telefono = personaInput.Telefono,
            Pais = personaInput.Pais,
            Departamento = personaInput.departamento,
            Ciudad = personaInput.Ciudad,
        };
            return persona;
        }

}
}