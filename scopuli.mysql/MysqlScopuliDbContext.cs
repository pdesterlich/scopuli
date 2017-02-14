using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using scopuli.common;

namespace scopuli.mysql
{
    public class MysqlScopuliDbContext: ScopuliDbContext
    {
        private readonly IConfigurationRoot _config;

        public MysqlScopuliDbContext(DbContextOptions options, IConfigurationRoot config) : base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql(_config["Data:ConnectionString"]);
        }

    }
}