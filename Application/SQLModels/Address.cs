using System;
using System.Collections.Generic;
using System.Text;

namespace SQLModel
{
    class Address
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public int Apartment { get; set; }
        public int UserId { get; set; }
    }
}