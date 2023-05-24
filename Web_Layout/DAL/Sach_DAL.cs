using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Web_Layout.Models;
namespace Web_Layout.DAL
{
    public class Sach_DAL
    {
        string conString = 
    ConfigurationManager.ConnectionStrings["adoConnectionString"].ToString();
        public List<Sach> Get_Sach()
        {
            List<Sach> Sach_List = new List<Sach>();
            using (SqlConnection connection = new SqlConnection(conString))
            {

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Masach,Tensach, Giaban" +
                    ", Mota, Anhbia, Ngaycapnhat,Soluongton" +
                    " from Nhaxuatban, Sach, Chude where Nhaxuatban.Manxb=" +
                    "Sach.Manxb and Sach.Machude=Chude.machude";
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                connection.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    Sach_List.Add(new Sach
                    {
                        Masach = dr[0].ToString(),
                        Tensach = dr[1].ToString(),
                        Giaban = float.Parse(dr[2].ToString()),
                        Mota = dr[3].ToString(),
                        Anhbia = dr[4].ToString(),
                        Ngaycapnhat = Convert.ToDateTime(dr[5].ToString()),
                        Soluongton = Convert.ToInt32(dr[6].ToString())
                    }); 
                }
            }
            return Sach_List;
        }
        public List<Sach> Get_Sach_ByChude(string machude)
        {
            List<Sach> Sach_List = new List<Sach>();
            using (SqlConnection connection = new SqlConnection(conString))
            {

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Masach,Tensach, Giaban" +
                    ", Mota, Anhbia, Ngaycapnhat,Soluongton" +
                    " from Nhaxuatban, Sach, Chude where Nhaxuatban.Manxb=" +
                    "Sach.Manxb and Sach.Machude=Chude.machude and Sach.Machude='"+machude+"'";
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                connection.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    Sach_List.Add(new Sach
                    {
                        Masach = dr[0].ToString(),
                        Tensach = dr[1].ToString(),
                        Giaban = float.Parse(dr[2].ToString()),
                        Mota = dr[3].ToString(),
                        Anhbia = dr[4].ToString(),
                        Ngaycapnhat = Convert.ToDateTime(dr[5].ToString()),
                        Soluongton = Convert.ToInt32(dr[6].ToString())
                    });
                }
            }
            return Sach_List;
        }
        public List<Sach> Get_Sach_ByMasach(string Masach)
        {
            List<Sach> Sach_List = new List<Sach>();
            using (SqlConnection connection = new SqlConnection(conString))
            {

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Masach,Tensach, Giaban" +
                    ", Mota, Anhbia, Ngaycapnhat,Soluongton from Sach where Sach.Masach='" + Masach + "'";
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                connection.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    Sach_List.Add(new Sach
                    {
                        Masach = dr[0].ToString(),
                        Tensach = dr[1].ToString(),
                        Giaban = float.Parse(dr[2].ToString()),
                        Mota = dr[3].ToString(),
                        Anhbia = dr[4].ToString(),
                        Ngaycapnhat = Convert.ToDateTime(dr[5].ToString()),
                        Soluongton = Convert.ToInt32(dr[6].ToString())
                    });
                }
            }
            return Sach_List;
        }

    }
}