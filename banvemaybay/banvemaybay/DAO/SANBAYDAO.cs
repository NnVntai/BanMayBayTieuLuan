using banvemaybay.DTO;
using System.Data;

namespace banvemaybay.DAO
{
    class SANBAYDAO
    {
        public static DataTable TT_sanbaychitiet(string masanbay)
        {
            string sql = "SELECT * FROM SANBAY WHERE MASANBAY='" + masanbay + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }
        public static DataTable TT_SANBAY()
        {

            string sql = "SELECT * FROM SANBAY";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable max_sanbay()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT TOP 1 MASANBAY from SANBAY order by MASANBAY desc";
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void Them_SANBAY(SANBAYDTO sa)
        {
            string sql = "INSERT INTO SANBAY([MASANBAY], [TENSANBAY]) VALUES('" + sa.MASANBAY + "', N'" + sa.TENSANBAY + "')";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static void Xoa_SANBAY(SANBAYDTO sa)
        {
            string sql = "Delete from SANBAY where MASANBAY='" + sa.MASANBAY + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static void CapNhat_SANBAY(SANBAYDTO sa)
        {
            string sql = "Update SANBAY set TENSANBAY=N'" + sa.TENSANBAY + "' where MASANBAY = '" + sa.MASANBAY + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
    }
}
