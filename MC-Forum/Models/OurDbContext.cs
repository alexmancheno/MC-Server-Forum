using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MC_Forum.Models
{
    public class OurDbContext : DbContext
    {
        public DbSet<UserAccount> UserAccount { get; set; }

        public DbSet<Post> Post { get; set; }
    }
}