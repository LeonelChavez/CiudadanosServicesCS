using Microsoft.EntityFrameworkCore;
using CiudadanosServicesCS.NombresPropios.Models;


namespace CiudadanosServicesCS.NombresPropios.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<NombrePropioEntity> TB_NombresPropios { get; set; }
    }
}
