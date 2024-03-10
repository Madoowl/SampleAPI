using API_DOTNET.Models;
using Microsoft.EntityFrameworkCore;

namespace API_DOTNET
{
    public class Context : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public Context(DbContextOptions<Context> options): base(options: options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

    }
}
