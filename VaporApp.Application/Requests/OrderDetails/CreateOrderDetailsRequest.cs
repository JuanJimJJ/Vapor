using System;
using System.Collections.Generic;
using System.Text;

namespace VaporApp.Application.Requests.OrderDetails
{
    public class CreateOrderDetailsRequest
    {
        public int IdOrderDetails { get; set; }
        public short DetailAmount { get; set; }
        public int IdProduct { get; set; }
        public int IdOrder { get; set; }
        public double DetailPrice { get; set; }
    }
}
