using System;
using Microsoft.EntityFrameworkCore;
using Entity;

namespace Datos
{
    public class RegistrosContext : DbContext
    {
        public RegistrosContext(DbContextOptions options) : base(options) {}
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Pago> Pagos { get; set; }
    }
}
