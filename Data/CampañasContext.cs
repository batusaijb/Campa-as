using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Campañas.Models
{
    public class CampañasContext : DbContext
    {
        public CampañasContext (DbContextOptions<CampañasContext> options)
            : base(options)
        {
        }

        public DbSet<Campañas.Models.Campaña> Campaña { get; set; }
    }
}
