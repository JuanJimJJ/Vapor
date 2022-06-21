using System;
using System.Collections.Generic;
using System.Text;

namespace VaporApp.Application.Requests.Orders
{
    public class UpdateOrdersRequest
    {
        public int IdOrder { get; set; }
        public int IdUser { get; set; }
        public string OrderShippingAddress { get; set; }
        public string OrderZipCode { get; set; }
        public string OrderCity { get; set; }
        public string OrderState { get; set; }
        public string OrderCountry { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
