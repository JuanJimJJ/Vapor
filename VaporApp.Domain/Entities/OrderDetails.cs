using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VaporApp.Domain.Entities
{
    public partial class OrderDetails
    {
        public int IdOrderDetails { get; set; }
        public short DetailAmount { get; set; }
        public int IdProduct { get; set; }
        public int IdOrder { get; set; }
        public double DetailPrice { get; set; }

        public virtual Orders IdOrderNavigation { get; set; }
        public virtual Products IdProductNavigation { get; set; }
    }
}
