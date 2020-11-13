using System.Security.Permissions;
using System.Collections.Generic;

using Entity;
using System;
namespace vista
{
    public class PersonaInputModel
    {
        public string NumeroDeCocumento { get; set; }
        public string TipoDeDocumento { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Pais { get; set; }
        public string departamento { get; set; }
        public string Ciudad { get; set; }
        public List<Pago> Pagos { get; set; }
        
        
    }
    public class PersonaViewModel : PersonaInputModel
    {
        public PersonaViewModel(){ }
        public PersonaViewModel(Persona persona)
        {
            NumeroDeCocumento = persona.NumeroDeCocumento;
            TipoDeDocumento = persona.TipoDeDocumento;
            Nombre = persona.Nombre;
            Direccion = persona.Direccion;
            Telefono = persona.Telefono;
            Pais = persona.Pais;
            departamento = persona.Departamento;
            Ciudad = persona.Ciudad;
            Pagos=persona.Pagos;
            
        }
            
    }
}