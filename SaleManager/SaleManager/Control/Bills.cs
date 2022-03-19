using SaleManager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Control
{
    internal class Bills
    {
        public static DataTable getDataBill(BillBean bean)
        {
            DataConnection connection = new DataConnection();
            SqlConnection conn = connection.getConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            StringBuilder txtSql = new StringBuilder();
            txtSql.Append(" SELECT * FROM tblBill WHERE 1=1 ");
            if (!String.IsNullOrEmpty(bean.Biller))
            {
                txtSql.Append(" AND Biller = @biller ");
            }
            if (!String.IsNullOrEmpty(bean.NameCustomer))
            {
                txtSql.Append(" AND NameCustomer = @nameCustomer ");
            }
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = txtSql.ToString();
            if (!String.IsNullOrEmpty(bean.Biller))
            {
                cmd.Parameters.AddWithValue("@biller", bean.Biller);
            }
            if (!String.IsNullOrEmpty(bean.NameCustomer))
            {
                cmd.Parameters.AddWithValue("@nameCustomer", bean.NameCustomer);
            }
            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static bool delBillId(string guid)
        {
            try
            {
                DataConnection connection = new DataConnection();
                SqlConnection conn = connection.getConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE tblBill WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", guid);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static DataTable getBillByIdBill(string guid)
        {
                DataTable ds = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                DataConnection connection = new DataConnection();
                SqlConnection conn = connection.getConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "proc_get_bill_by_id_bill";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idBill", guid);
                conn.Open();
                da.SelectCommand = cmd;
                da.Fill(ds);
                conn.Close();
                return ds;
        }
    }
}
