using SaleManager.Common;
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
    internal class ReceiptSlip
    {
        public static DataTable getDataReceiptSlip(ReceiptSlipBean bean)
        {
            DataConnection connection = new DataConnection();
            SqlConnection conn = connection.getConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            StringBuilder txtSql = new StringBuilder();
            txtSql.Append(" SELECT * FROM tblReceiptSlip WHERE 1=1 ");
            if (!String.IsNullOrEmpty(bean.NameCustomer))
            {
                txtSql.Append(" AND NameCustomer = @nameCustomer ");
            }
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = txtSql.ToString();
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

        public static bool saveOrUpdateReceiptSlip(ReceiptSlipBean bean, bool action)
        {
            string txtProc = "proc_add_ReceiptSlip";
           
            try
            {
                DataConnection connection = new DataConnection();
                SqlConnection conn = connection.getConnection();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = txtProc;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", bean.Id);
                cmd.Parameters.AddWithValue("@nameCustomer", bean.NameCustomer);
                cmd.Parameters.AddWithValue("@address", bean.Address);
                cmd.Parameters.AddWithValue("@receivingTime", bean.RecevingTime);
                cmd.Parameters.AddWithValue("@recevier", bean.Recevier);
                cmd.Parameters.AddWithValue("@payTime", bean.PayTime);
                cmd.Parameters.AddWithValue("@flag", action);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static bool delReceiptSlipId(string guid)
        {
            try
            {
                DataConnection connection = new DataConnection();
                SqlConnection conn = connection.getConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE tblReceiptSlip WHERE Id = @id";
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
    }
}
