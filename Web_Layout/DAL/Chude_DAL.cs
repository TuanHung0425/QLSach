using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Web_Layout.Models;
namespace Web_Layout.DAL
{
    public class Chude_DAL
    {
        string conString =
  ConfigurationManager.ConnectionStrings
            ["adoConnectionString"].ToString();
        public List<Chude> Get_Chude()
        {
            List<Chude> Chude_List = new List<Chude>();
            using (SqlConnection connection = new 
                SqlConnection(conString))
            {   SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select machude, tenchude " +
                    "from chude";                   
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                connection.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    Chude_List.Add(new Chude
                    {
                        Machude= dr[0].ToString(),
                        Tenchude = dr[1].ToString(),
                        
                    });
                }
            }
            return Chude_List;
        }
        public List<Chude> Get_Chude_Byma(string machude)
        {
            List<Chude> Chude_List = new List<Chude>();
            using (SqlConnection connection = new SqlConnection(conString))
            {

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select machude, tenchude " +
                    "from chude where machude='"+
                    machude+"'";
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                connection.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    Chude_List.Add(new Chude
                    {
                        Machude = dr[0].ToString(),
                        Tenchude = dr[1].ToString(),

                    });
                }
            }
            return Chude_List;
        }

        public void Insert_Chude(Chude ob)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {

     string sql = "Insert into chude values('"
            + ob.Machude + "','" +
            ob.Tenchude + "')";
            connection.Open();
     SqlCommand cmd = new SqlCommand(sql, connection);
     cmd.ExecuteNonQuery();
     connection.Close();
            }
        }
        public void Update_Chude(Chude ob)
        {
            using (SqlConnection connection = 
                new SqlConnection(conString)){
     string sql = "Update Chude set Tenchude='" +
                    ob.Tenchude + 
     "' where Machude='" +ob.Machude+"'";
        connection.Open();
        SqlCommand cmd = new SqlCommand(sql, connection);
        cmd.ExecuteNonQuery();
        connection.Close();
            }
        }
        public void Delete_Chude(string machude)
        {
            using (SqlConnection connection = new 
                SqlConnection(conString))
            {

      string sql = "Delete from Chude " +
      "where Machude='" + machude + "'";
      connection.Open();
      SqlCommand cmd = new SqlCommand(sql, connection);
      cmd.ExecuteNonQuery();
      connection.Close();
            }

        }
    }
}