﻿using System.Collections.Generic;

namespace EntityLibraryCore5.Models
{
    public partial class Countries
    {
        public Countries()
        {
            Customers = new HashSet<Customers>();
        }

        public int Id { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<Customers> Customers { get; set; }
    }
}