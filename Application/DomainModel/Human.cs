using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public class Human
    {
        public int Id { get; set; }

        public string Email { get; set; }

        //[Password]
        public string Name { get; set; }

        public bool IsModelValid()
        {
            return !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Name);
        }
    }
}
