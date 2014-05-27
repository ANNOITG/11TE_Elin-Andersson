using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace projekt_kattsida.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<CatStoreEntities>
    {
        protected override void Seed(CatStoreEntities context)
        {
            var breeds = new List<Breeds>
            {
                new Breeds { Name = "Abyssinian"},
                new Breeds { Name = "Norwegian Forest Cat"},
                new Breeds { Name = "Siamese"},
                new Breeds { Name = "Bengal" },
                new Breeds { Name = "Burma" },
                new Breeds { Name = "Cornish Rex" },
                new Breeds { Name = "European Shorthair" },
                new Breeds { Name = "Manx" },
                new Breeds { Name = "Ocicat" },
                new Breeds { Name = "Ukrainian Levkoy" }
            };


            new List<Cat>
            {
                new Cat { Name = "Misse", Breeds = breeds.Single(b => b.Name == "Ocicat"), Price = 8.99M, CatArtUrl = "/Content/Images/placeholder.gif" },
                new Cat { Name = "Missan", Breeds = breeds.Single(b => b.Name == "Abyssinian"), Price = 8.99M, CatArtUrl = "/Content/Images/placeholder.gif" },
                new Cat { Name = "Katten", Breeds = breeds.Single(b => b.Name == "Norwegian Forest Cat"), Price = 8.99M, CatArtUrl = "/Content/Images/placeholder.gif" },
                new Cat { Name = "Missen", Breeds = breeds.Single(b => b.Name == "Siamese"), Price = 8.99M, CatArtUrl = "/Content/Images/placeholder.gif" },
                new Cat { Name = "Misse", Breeds = breeds.Single(b => b.Name == "Manx"), Price = 8.99M, CatArtUrl = "/Content/Images/placeholder.gif" },
                new Cat { Name = "Misse", Breeds = breeds.Single(b => b.Name == "Bengal"), Price = 8.99M, CatArtUrl = "/Content/Images/placeholder.gif" },
            }.ForEach(c => context.Cats.Add(c));
        }
    }
}