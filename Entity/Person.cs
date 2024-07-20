using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Person
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string State {  get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
    }
}
