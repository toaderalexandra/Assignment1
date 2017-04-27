using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Ob
{
    public class Order
    { 
        public int ID { get; set; }
        public string customername { get; set; }
        public string shippingaddress { get; set; }
        public DateTime deliverydate { get; set; }
        public string status { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
    }
}
