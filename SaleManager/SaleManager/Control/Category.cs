using SaleManager.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Control
{
    internal class Category
    {
        DataConnection connection;
        

        public Category()
        {
            connection = new DataConnection();
        }

        public static DataTable getAllCategories(string action)
        {
            string sql="";
            DataConnection connDb = new DataConnection();
            if (action.Equals(Constants.ACTION_GET_ALL))
            {
                sql = "SELECT * FROM tblCategory";
            }
            else if (action.Equals(Constants.ACTION_GET_FOR_CBB))
            {
                sql = "SELECT Id, NameCategory FROM tblCategory";
            }
            SqlConnection conn = connDb.getConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        

        public bool saveOrUpdateCategory(string guid, string nameCategory, string nameSupplier, bool status, string action)
        {
            string txtProc;
            if (action.Equals(Constants.ACTION_ADD))
            {
                txtProc = "pro_add_category";
            }
            else
            {
                txtProc = "proc_update_category";
            }
            try
            {
                SqlConnection conn = connection.getConnection();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = txtProc;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", guid);
                cmd.Parameters.AddWithValue("@nameCategory", nameCategory);
                cmd.Parameters.AddWithValue("@nameSupplier", nameSupplier);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool delCategory(string guid)
        {
            try
            {
                SqlConnection conn = connection.getConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE tblCategory WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", guid);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }

    
}