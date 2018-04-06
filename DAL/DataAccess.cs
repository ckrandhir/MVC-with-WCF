using Dal;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DataAccess
    {
        public int GetCustomerAndOrders(string Id)
        {
            
            DataTable customerAndOrderse = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CustomerID",Id);


            DataSet ds = SqlHelper.ExecuteDataset(Utility.GetSQlConnection(), CommandType.StoredProcedure, "Get Customer And Orders", param);

            return 1;
        }



    }
}
