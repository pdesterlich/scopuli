using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using scopuli.common;

namespace scopuli.sqlite
{
    public class SqliteScopuliDbContext: ScopuliDbContext
    {
        private readonly IConfigurationRoot _config;

        public SqliteScopuliDbContext(DbContextOptions options, IConfigurationRoot config): base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite(_config["Data:ConnectionString"]);
        }
    }
}