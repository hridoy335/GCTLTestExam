using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCTLTestExam.Models
{
    public class DeliveryAddressInfo
    {
        public int ID { get; set; }
        public string Delivery_Id { get; set; }
        public string Delivery_Address { get; set; }
        public string Delivery_ContactPerson { get; set; }
        public string Delivery_Phone { get; set; }
        public string Delivery_Customer_Id { get; set; }
    }
}
