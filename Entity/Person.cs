using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryProject.Entity
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }

    public class Address
    {
        public int Id { get; set; }

        public string Street { get; set; }

        public string City { get; set; }
    }
}
