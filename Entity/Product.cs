using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        public int IdProduct { get; set; }        
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public double Price { get; set; } 
    }
}
