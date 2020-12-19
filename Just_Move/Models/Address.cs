using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Just_Move.Models
{
    public class Address
    {
        public string Id { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string Block { get; set; }
        public int ApartmentNumber { get; set; }
    }
}
