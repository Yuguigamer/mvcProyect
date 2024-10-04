using Microsoft.EntityFrameworkCore;
using mvcProyect.Models;
namespace mvcProyect.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        {
        }
        //Aqui todos los modelos que se creen 
        public DbSet<Producto> Producto { get; set; }

    }
}
