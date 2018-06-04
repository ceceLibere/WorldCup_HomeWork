using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WorldCupRussia.Models
{
    public class WorldCupRussiaDbContext : DbContext
    {
        public WorldCupRussiaDbContext() : base("WorldCupDb")
        {

        }

        public DbSet<Match> Matches { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}