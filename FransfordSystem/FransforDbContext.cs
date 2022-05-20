using Microsoft.EntityFrameworkCore;
using FransfordSystem.Models;


//Clase que sirve para conectar a la base integrando las tablas en models
namespace FransfordSystem
{
    public class FransforDbContext : DbContext
    {
        public FransforDbContext(DbContextOptions<FransforDbContext> options)
            : base(options) { 
        
        
        }


        public DbSet<Trabajador> Trabajador { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Categoria> Categoria { get; set; }





    }
     

}
