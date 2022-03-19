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
    internal class DataRepairLog
    {
        public static DataTable getDataDataRepairLog(Model.RepairLogBean bean)
        {
            DataConnection connection = new DataConnection();
            SqlConnection conn = connection.getConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            StringBuilder txtSql = new StringBuilder();
            txtSql.Append(" SELECT * FROM tblRepairLog WHERE 1=1 ");
            if (!String.IsNullOrEmpty(bean.NameProduct))
            {
                txtSql.Append(" AND NameProduct = @nameProduct ");
            }
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = txtSql.ToString();
            if (!String.IsNullOrEmpty(bean.NameProduct))
            {
                cmd.Parameters.AddWithValue("@nameProduct", bean.NameProduct);
            }
            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static bool saveOrUpdateDataRepairLog(RepairLogBean bean, bool action)
        {
            string txtProc = "proc_save_or_update_RepairLog";

            try
            {
                DataConnection connection = new DataConnection();
                SqlConnection conn = connection.getConnection();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = txtProc;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", bean.Id);
                cmd.Parameters.AddWithValue("@nameProduct", bean.NameProduct);
                cmd.Parameters.AddWithValue("@solution", bean.Solution);
                cmd.Parameters.AddWithValue("@fixDate", bean.FixDate);
                cmd.Parameters.AddWithValue("@repairer", bean.Repairer);
                cmd.Parameters.AddWithValue("@repairDate", bean.RepairDate);
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
        public static bool delRepairLogId(string guid)
        {
            try
            {
                DataConnection connection = new DataConnection();
                SqlConnection conn = connection.getConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE tblRepairLog WHERE Id = @id";
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
