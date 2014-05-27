using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projekt_kattsida.Models
{
    public class Cat
    {
        
        public int CatId { get; set;}
        public string Name { get; set; }
        public Breeds Breeds { get; set; }
        public int BreedId { get; set; }
        public decimal Price { get; set; }
        public string CatArtUrl { get; set; }
        //public string tedt { get; set; }
    }
}