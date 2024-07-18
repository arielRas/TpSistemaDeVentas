using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Employee : Person
    {
        public Guid IdEmployee { get; set; }
        public string Sector { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
