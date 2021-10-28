using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCTLTestExam.Models
{
    public class CustomerInfo
    {
        public int ID { get; set; }
        public string Customer_Id { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Address { get; set; }
        public string Customer_Country { get; set; }
        public string Customer_Phone { get; set; }
        public string Customer_Email { get; set; }
        public DateTime Customer_Business_StartDate { get; set; }
        public string Customer_Business_Product_Id { get; set; }
        public string Customer_CustomerType_Id { get; set; }
        public string Customer_District_Id { get; set; }
        public string Customer_Thana_Id { get; set; }
        public string Customer_Image_Id { get; set; }
    }
}
