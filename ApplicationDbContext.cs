using Microsoft.EntityFrameworkCore;
using WebApiZapateria.Entidades;

namespace WebApiZapateria
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        //crenado la tabla
        public DbSet<Zapato> Zapatos { get; set; }
           
    }
}
