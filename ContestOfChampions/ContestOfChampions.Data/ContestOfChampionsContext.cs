using ContestOfChampions.Models.EntityModels;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ContestOfChampions.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ContestOfChampionsContext : IdentityDbContext<ApplicationUser>
    {
        public ContestOfChampionsContext()
            : base("data source=(LocalDb)\\MSSQLLocalDB;initial catalog=ContestOfChampionsDb;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework", throwIfV1Schema: false)
        {
        }

        public DbSet<Summoner> Summoners { get; set; }

        public DbSet<Champion> Champions { get; set; }

        public DbSet<Resources> Resources { get; set; }

        public DbSet<Stats> Stats { get; set; }

        public DbSet<Alliance> Alliances { get; set; }

        public DbSet<Treasury> Treasuries { get; set; }


        public static ContestOfChampionsContext Create()
        {
            return new ContestOfChampionsContext();
        }

    }
}