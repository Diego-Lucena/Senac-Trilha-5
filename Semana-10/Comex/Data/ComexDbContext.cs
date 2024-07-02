
using Comex.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Comex.Data
{
    public class ComexDbContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }

        private string conectionString = "Data Source=(localdb)\\MSSQLLocalDB;" +
            "Initial Catalog=ComexDB;" +
            "Integrated Security=True;Connect Timeout=30;" +
            "Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;" +
            "Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(conectionString);
        }

    }
}
