using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCTLTestExam.Models
{
    public class ContactPersonInfo
    {
        public int ID { get; set; }
        public string ContactPerson_Id { get; set; }
        public string ContactPerson_Name { get; set; }
        public string ContactPerson_Designation { get; set; } 
        public string ContactPerson_Phone { get; set; }
        public string ContactPerson_Email { get; set; }
        public string ContactPerson_Customer_Id { get; set; }
    }
}
