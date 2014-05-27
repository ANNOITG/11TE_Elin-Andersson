using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projekt_kattsida.Models
{
    public class Breeds
    {
        public string Name { get; set; }
        public int BreedsId { get; set; }
        public string Description { get; set; }
        public List<Cat> Cats { get; set; }
    }
}