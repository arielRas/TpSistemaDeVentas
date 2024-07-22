﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Promotion
    {
        public Guid IdPromotion { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DiscountPercentage { get; set; }
        public abstract IEnumerable<Object> Products { get; }
        public abstract List<int> GetIdProductsInPromotion();
    }
}
