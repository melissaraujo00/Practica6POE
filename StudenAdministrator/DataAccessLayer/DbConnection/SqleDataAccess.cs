using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DataAccessLayer.DbConnection
{
    public class SqleDataAccess
    {
        private readonly string _connectionString;
        public SqleDataAccess() 
        {
            _connectionString = "Data Source=MERLYNRAJO\\SQLEXPRESS;Initial Catalog=StudentAdministratorDB;Integrated Security=True;Trust Server Certificate=True";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
