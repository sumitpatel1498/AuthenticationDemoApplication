using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AuthenticationDemoApplication.Models
{
    public class DataContext
    {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ToString());
            public IEnumerable<RoleManagement> GetMobileList()
            {
                string query = "SELECT [ID],[Name]FROM [DemoDB].[dbo].[AspNetRoles]";
                var result = con.Query<RoleManagement>(query);
                return result;
            }

        internal System.Collections.IEnumerable GetRoleManagementDataList()
        {
            throw new NotImplementedException();
        }
    }
}