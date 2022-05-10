using Microsoft.Extensions.Logging;
using Reconciliation.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconciliation.Domain.Service
{
    public class ReconciliationService : IReconciliationService
    {
        private readonly ILogger<ReconciliationService> _logger;

        public ReconciliationService(
            ILogger<ReconciliationService> logger
            )
        {
            _logger = logger;
        }

        public async Task<IEnumerable<ReconciliationDto>> GetAllReconciliation()
        {
            var reconcialationList = new List < ReconciliationDto>();
            reconcialationList.Add(new ReconciliationDto { });
            //Console.WriteLine("Getting Connection ...");

            //var datasource = @"DESKTOP-3FVEKP1\SQLEXPRESS";//your server
            //var database = "Bookkeeping"; //your database name
            //var username = "nakul.saha"; //username of server to connect
            //var password = "123"; //password

            ////your connection string 
            //string connString = @"Data Source=" + datasource + ";Initial Catalog="
            //            + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            ////create instanace of database connection
            //SqlConnection conn = new SqlConnection(connString);


            //try
            //{
            //    Console.WriteLine("Openning Connection ...");

            //    //open connection
            //    conn.Open();

            //    Console.WriteLine("Connection successful!");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error: " + e.Message);
            //}

            //Console.Read();

            return reconcialationList;
        }
    }
}
