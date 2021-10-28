using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCTLTestExam.Models
{
    public class BankAccountInfo
    {
        public int ID { get; set; }
        public string BankAccount_Id { get; set; }
        public string BankAccount_BankName { get; set; }
        public string BankAccount_Branch { get; set; }
        public string BankAcount_ACName { get; set; }
        public string BankAcount_ACNo { get; set; }
        public int BankAccount_CreditLimit { get; set; }
        public string BankAccount_SelesPerson { get; set; }
        public string BankAccount_Customer_Id { get; set; }
    }
}
