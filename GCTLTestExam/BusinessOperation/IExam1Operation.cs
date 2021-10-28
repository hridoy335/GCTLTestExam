using GCTLTestExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCTLTestExam.BusinessOperation
{
    public interface IExam1Operation
    {
        IList<CustomerInfo> GetCoustomer();
    }
}
