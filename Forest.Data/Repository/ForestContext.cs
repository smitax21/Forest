using System;
using Forest.Data.Models.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Forest.Data.Repository
{
    public class ForestContext : DbContext
    {
        public ForestContext() : base("ForestContext")
        {
            Database.SetInitializer(new ForestInitialiser());
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Music> Musics { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderLine> OrderLines { get; set; }
    }
}
