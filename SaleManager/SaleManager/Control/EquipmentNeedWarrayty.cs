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
    internal class EquipmentNeedWarrayty
    {
        public static DataTable getDataEquipmentNeedWarrayty(EquipmentNeedWarraytyBean bean)
        {
            DataConnection connection = new DataConnection();
            SqlConnection conn = connection.getConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            StringBuilder txtSql = new StringBuilder();
            txtSql.Append(" SELECT * FROM tblEquipmentNeedWarrayty WHERE 1=1 ");
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

        public static bool saveOrUpdateEquipmentNeedWarrayty(EquipmentNeedWarraytyBean bean, bool action)
        {
            string txtProc = "proc_save_or_update_EquipmentNeedWarrayty";

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
                cmd.Parameters.AddWithValue("@status", bean.Status);
                cmd.Parameters.AddWithValue("@description", bean.Description);
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

        public static bool delEquipmentNeedWarraytyId(string guid)
        {
            try
            {
                DataConnection connection = new DataConnection();
                SqlConnection conn = connection.getConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE tblEquipmentNeedWarrayty WHERE Id = @id";
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
