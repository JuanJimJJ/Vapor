using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VaporApp.Domain.Entities
{
    public partial class ProductCategories
    {
        public int IdProductCategory { get; set; }
        public int IdProduct { get; set; }
        public int IdCategory { get; set; }

        public virtual Categories IdCategoryNavigation { get; set; }
        public virtual Products IdProductNavigation { get; set; }
    }
}
