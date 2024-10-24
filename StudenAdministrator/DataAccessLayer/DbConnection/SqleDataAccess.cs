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
            _connectionString = "Data Source=DESKTOP-JDM7JV2\\MSSQLSERVER01;Initial Catalog=StudentAdministratorDB;Integrated Security=True;Encrypt=False";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
