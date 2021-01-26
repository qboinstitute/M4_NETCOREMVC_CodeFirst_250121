using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M4_NETCOREMVC.CodeFirst.Models
{
    public class FifaDBContext: DbContext
    {
        public FifaDBContext(DbContextOptions<FifaDBContext> options): base(options)
        {

        }

        public DbSet<Player> Players { get; set; }

        public DbSet<SoccerPosition> Positions { get; set; }

        public DbSet<Team> Teams { get; set; }


    }
}
