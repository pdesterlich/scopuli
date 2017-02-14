using Microsoft.EntityFrameworkCore;
using scopuli.common.Models;

namespace scopuli.common
{
    public abstract class ScopuliDbContext: DbContext
    {
        protected ScopuliDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Starship> Starships { get; set; }
    }
}