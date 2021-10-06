using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class Conexion : DbContext
    {
        public DbSet<Empleado> Empleados{get;set;}
        public DbSet<Producto> Productos{get;set;}
        public DbSet<Consola> Consolas{get;set;}
        public DbSet<Controles> Controless{get;set;}
        public DbSet<Videojuego> Videojuegos{get;set;}
        public DbSet<Factura> Facturas{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder builder){
            if(!builder.IsConfigured){
                builder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = Version1Data");
            }
        }



    }
}
