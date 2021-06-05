
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace appTsane.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<appTsane.Models.Contacto> Contacto { get; set; }
        public DbSet<appTsane.Models.Proforma> Carrito { get; set; }

        public DbSet<appTsane.Models.Producto> Producto { get; set; }

        public DbSet<appTsane.Models.Pedido> Pedido { get; set; }

    }
}
