using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VaporApp.Domain.Entities
{
    public partial class Categories
    {
        public Categories()
        {
            ProductCategories = new HashSet<ProductCategories>();
        }

        public int IdCategory { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<ProductCategories> ProductCategories { get; set; }
    }
}
