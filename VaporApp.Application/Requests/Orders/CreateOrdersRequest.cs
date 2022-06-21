using System;
using System.Collections.Generic;
using System.Text;

namespace VaporApp.Application.Requests.Orders
{
    public class CreateOrdersRequest
    {
        public int IdOrder { get; set; }
        public string OrderShippingAddress { get; set; }
        public string OrderZipCode { get; set; }
        public string OrderCity { get; set; }
        public string OrderState { get; set; }
        public string OrderCountry { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
