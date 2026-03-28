using Microsoft.EntityFrameworkCore;

namespace WebAppSat.Models
{
    
        public class ProContext : DbContext
        {
        public ProContext(DbContextOptions<ProContext>  dbContextOptions) :
       base(dbContextOptions)
        {

        }

        public DbSet<Product> products { set; get; }
    }
    
}
