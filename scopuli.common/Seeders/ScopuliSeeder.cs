using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using scopuli.common.Models;

namespace scopuli.common.Seeders
{
    public class ScopuliSeeder
    {
        private readonly ScopuliDbContext _context;

        public ScopuliSeeder(ScopuliDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.Starships.Any())
            {
                var ships = new List<Starship>()
                {
                    new Starship
                    {
                        Name = "Scopuli",
                        Class = "Light Transport Freighter"
                    },
                    new Starship
                    {
                        Name = "Canterbury",
                        Class = "Transport Ship"
                    },
                    new Starship
                    {
                        Name = "Rocinante",
                        Class = "Corvette"
                    }
                };
                await _context.Starships.AddRangeAsync(ships);
                await _context.SaveChangesAsync();
            }
        }
    }
}