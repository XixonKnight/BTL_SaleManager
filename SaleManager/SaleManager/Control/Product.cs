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
    internal class Product
    {
        //DataConnection connection;
        public Product()
        {
            //connection = new DataConnection();
        }

        public static DataTable getAllProduct()
        {
            DataConnection connection = new DataConnection();
            SqlConnection conn = connection.getConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "proc_view_product";
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static bool saveOrUpdateProduct(ProductBean product, string action) 
        {
            string txtProc;
            if (action.Equals(Constants.ACTION_ADD))
            {
                txtProc = "proc_add_product";
            }
            else
            {
                txtProc = "proc_update_product";
            }
            try
            {
                DataConnection connection = new DataConnection();
                SqlConnection conn = connection.getConnection();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = txtProc;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", product.id);
                cmd.Parameters.AddWithValue("@idCategory", product.idCategory);
                cmd.Parameters.AddWithValue("@nameProduct", product.nameProduct);
                cmd.Parameters.AddWithValue("@color", product.color);
                cmd.Parameters.AddWithValue("@size", product.size);
                cmd.Parameters.AddWithValue("@price", product.price);
                cmd.Parameters.AddWithValue("@quantity", product.quantity);
                cmd.Parameters.AddWithValue("@description", product.description);
                if(action.Equals(Constants.ACTION_ADD))
                {
                    cmd.Parameters.AddWithValue("@createdDate", product.createdDate);
                }
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool delProductById(string guid)
        {
            try
            {
                DataConnection connection = new DataConnection();
                SqlConnection conn = connection.getConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE tblProduct WHERE Id = @id";
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

        public static DataTable seachProduct(ProductBean product)
        {
            DataConnection connection = new DataConnection();
            SqlConnection conn = connection.getConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            StringBuilder txtSql = new StringBuilder();
            txtSql.Append("SELECT p.*, c.NameCategory FROM tblProduct p JOIN tblCategory c" +
                " ON c.Id = p.IdCategory Where 1=1 ");
            if (!String.IsNullOrEmpty(product.nameProduct))
            {
                txtSql.Append(" AND NameProduct = @nameProduct ");
            }
            if (!String.IsNullOrEmpty(product.idCategory))
            {
                txtSql.Append(" AND IdCategory = @idCategory ");
            }
            if (!String.IsNullOrEmpty(product.color))
            {
                txtSql.Append(" AND Color = @color ");
            }
            if(!String.IsNullOrEmpty(product.description)) 
            {
                txtSql.Append(" AND Description = @description ");
            }
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = txtSql.ToString();

            if (!String.IsNullOrEmpty(product.nameProduct))
            {
                cmd.Parameters.AddWithValue("@nameProduct", product.nameProduct);
            }
            if (!String.IsNullOrEmpty(product.idCategory))
            {
                cmd.Parameters.AddWithValue("@idCategory", product.idCategory);
            }
            if (!String.IsNullOrEmpty(product.color))
            {
                cmd.Parameters.AddWithValue("@color", product.color);
            }
            if (!String.IsNullOrEmpty(product.description))
            {
                cmd.Parameters.AddWithValue("@description", product.description);
            }
            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}
