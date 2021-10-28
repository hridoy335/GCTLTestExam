using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GCTLTestExam.BusinessOperation;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace GCTLTestExam.Controllers
{
    public class ExamController : Controller
    {

        private readonly IConfiguration configuration;
        private readonly ILogger<ExamController> _logger;
        private readonly IExam1Operation _exam1Operation;
        public ExamController(ILogger<ExamController> logger, IConfiguration config, IExam1Operation exam1Operation)
        {
            _logger = logger;
            this.configuration = config;
            _exam1Operation = exam1Operation;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetCustomerInfo()
        {
            var emp = _exam1Operation.GetCoustomer();
            return View(emp);
        }
    }
}
