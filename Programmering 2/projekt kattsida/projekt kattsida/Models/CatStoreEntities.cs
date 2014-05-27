using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace projekt_kattsida.Models
{
    public class CatStoreEntities : DbContext
    {
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Breeds> Breeds { get; set; }
    }
}