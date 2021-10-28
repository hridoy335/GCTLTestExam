using Dapper;
using GCTLTestExam.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GCTLTestExam.BusinessOperation
{
    public class Exam1Operation: IExam1Operation
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<Exam1Operation> _logger;
        private ConnectionStrings _dbSettings;
        public Exam1Operation(ILogger<Exam1Operation> logger, IConfiguration config, IOptions<ConnectionStrings> dbSettings)
        {
            _logger = logger;
            this.configuration = config;
            _dbSettings = dbSettings.Value;

        }

        IList<CustomerInfo> IExam1Operation.GetCoustomer()
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection").ToString());
            var sql = "select * from CustomerInfo ;";
            var models = connection.Query<CustomerInfo>(sql);
            return models.ToList();
        }
    }
}
