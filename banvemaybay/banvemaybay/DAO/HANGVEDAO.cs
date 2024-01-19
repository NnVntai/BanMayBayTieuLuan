using banvemaybay.DTO;
using System.Data;

namespace banvemaybay.DAO
{
    class HANGVEDAO
    {
        public static DataTable TTHANGVEchitietCHUYENBAY(string mahangve)
        {
            string sql = "SELECT H.TENHANGVE , ((C.SOLUONG)-(select count(MaVeChuyenBay)  from Vechuyenbay v where v.Machuyenbay=C.Machuyenbay and v.Mahangve=C.Mahangve )) FROM HangVe H,CHITIETSL C WHERE H.MAHANGVE=C.MAHANGVE and C.MACHUYENBAY='" + mahangve + "' ";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }

        public static DataTable TTHANGVEchitiet(string mahangve)
        {
            string sql = "SELECT * FROM HANGVE WHERE MAHANGVE='" + mahangve + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }

        public static DataTable TTHANGVE()
        {
            string sql = "SELECT * FROM HANGVE";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }
        public static void Them_HANGVE(HANGVEDTO hv)
        {
            string sql = "INSERT INTO HANGVE([MAHANGVE], [TENHANGVE]) VALUES('" + hv.mahangve + "', N'" + hv.tenhangve + "')";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static void Xoa_HANGVE(HANGVEDTO hv)
        {
            string sql = "Delete from HANGVE where MAHANGVE='" + hv.mahangve + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static void CapNhat_HANGVE(HANGVEDTO hv)
        {
            string sql = "Update HANGVE set TENHANGVE=N'" + hv.tenhangve + "' where MAHANGVE = '" + hv.mahangve + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static DataTable MaHangVeMax()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT TOP 1 MAHANGVE from HANGVE order by MAHANGVE desc";
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
    }
}
