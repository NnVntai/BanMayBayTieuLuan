using banvemaybay.DTO;
using System.Data;


namespace banvemaybay.DAO
{
    class VAITRODAO
    {


        public static DataTable TT_VAITRO()
        {
            string sql = "SELECT * FROM VAITRO";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }
        public static void Them_VAITRO(VAITRODTO VT)
        {
            string sql = "INSERT INTO VAITRO([MAVAITRO], [TENVAITRO]) VALUES('" + VT.MaVaiTro + "', N'" + VT.TenVaiTro + "')";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static void Xoa_VAITRO(VAITRODTO VT)
        {
            string sql = "Delete from VAITRO where MAVAITRO='" + VT.MaVaiTro + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static void CapNhat_VAITRO(VAITRODTO VT)
        {
            string sql = "Update VAITRO set TENVAITRO=N'" + VT.TenVaiTro + "' where MAVAITRO = '" + VT.MaVaiTro + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static DataTable VAITROMAX()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT TOP 1 MAVAITRO from VAITRO order by MAVAITRO desc";
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
    }
}
