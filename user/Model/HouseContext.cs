using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace user.Model
{
    public class HouseContext: DbContext
    {
        public HouseContext(DbContextOptions<HouseContext> options)
          : base(options)
        {
        }

        public DbSet<House> houses { get; set; }
    }
}
