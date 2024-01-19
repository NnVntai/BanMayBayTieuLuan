using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace banvemaybay.DAO
{
    class KetnoiCSDL
    {
        private static SqlConnection cnn = new SqlConnection();
        public static void MoKetNoi()
        {
            try
            {
                string sqlcon = @"Data Source=LAPTOP-633IK1FQ\SQLEXPRESS;Initial Catalog=banvemaybay3;Integrated Security=True";
                cnn.ConnectionString = sqlcon;
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("ket noi khong thanh cong");

            }
        }
        public static void DongKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();

        }
        public static DataTable DocDuLieu(string sql)
        {
            MoKetNoi();
            SqlCommand cd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DongKetNoi();
            return dt;
        }
        public static void thucthitruyvan(string sql)
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}
