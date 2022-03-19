using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager
{
    class DataConnection
    {
        string strCon;
        public DataConnection()
        {
            //strCon = @"Data Source=DESKTOP-6O671H3\SQLEXPRESS;Initial Catalog=QlyBanHang;Integrated Security=True";
            //strCon = @"Data Source = NHANNGUYEN; Initial Catalog = QlyBanHang; Integrated Security = True";
            strCon = @"Data Source=NHANNGUYEN;Initial Catalog=QlyBanHang;Integrated Security=True";
            //strCon = @"Data Source=DESKTOP-5EU06RI;Initial Catalog=QlyBanHang;Integrated Security=True";

        }
        public SqlConnection getConnection()
        {
            return new SqlConnection(strCon);
        }
        
    }
}
