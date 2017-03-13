using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GameShop.Models
{
    public class EFDBContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}