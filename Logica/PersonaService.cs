using Entity;
using Datos;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Logica
{
    public class PersonaService
    {
        
        private readonly RegistrosContext _context;
        public PersonaService(RegistrosContext context)
        {
            _context=context;
        }
        public GuardarPersonaResponse Guardar(Persona persona)
        {
            try
            {   
                var personaBuscada = _context.Personas.Find(persona.NumeroDeDocumento);
                if (personaBuscada != null)
                {
                    return new GuardarPersonaResponse("Error, el persona ya se encuentra registrada.");
                }

                _context.Personas.Add(persona);
                _context.SaveChanges();

                return new GuardarPersonaResponse(persona);
            }
            catch (Exception e)
            {
                return new GuardarPersonaResponse($"Error de la Aplicacion: {e.Message}");
            }
        }
        public Persona BuscarPorNumeroDeDocumento(string numeroDeDocumento)
        {
            Persona persona = _context.Personas.Find(numeroDeDocumento);
            return persona;
        }

        public int Totalizar()
        {
            return _context.Personas.Count();
        }
        
        public ConsultarPersonaResponse ConsultarTodos()
        {
            try
            {
                if(_context.Pagos.ToList().Count()<1){
                    return new ConsultarPersonaResponse("No hay personas registradas");

                }else{
                    return new ConsultarPersonaResponse(_context.Personas.ToList());
                }
            }
            catch (Exception e)
            {
                return new ConsultarPersonaResponse($"Error de la Aplicacion: {e.Message}");
            }
           

        }
        









    }
    public class GuardarPersonaResponse 
    {
        public GuardarPersonaResponse(Persona persona)
        {
            Error = false;
            Persona = persona;
        }
        public GuardarPersonaResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Persona Persona { get; set; }
    }
    public class ConsultarPersonaResponse
    {
        public ConsultarPersonaResponse(List<Persona> personas)
        {
            Error = false;
            Personas = personas;
        }
        public ConsultarPersonaResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public List<Persona> Personas { get; set; }

    }
}