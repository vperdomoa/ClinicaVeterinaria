using ClinicaVeterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;
namespace ClinicaVeterinaria.App.persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> persona { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured) //configuracion de la base de datos
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLOCALDB; Initial Catalog=ClinicaVeterinariaData");
            }

        }
    }
}