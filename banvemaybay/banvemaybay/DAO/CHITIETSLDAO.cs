using banvemaybay.DTO;
using System.Data;

namespace banvemaybay.DAO
{
    class CHITIETSLDAO
    {
        public static DataTable TT_CHITIETSL()
        {
            string sql = "SELECT * FROM CHITIETSL";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TT_CHITIETtheohv()
        {
            string sql = "SELECT C.MASLGHE,C.MAHANGVE,C.MACHUYENBAY,C.SOLUONG,H.TENHANGVE FROM CHITIETSL C,HANGVE H WHERE H.MAHANGVE=C.MAHANGVE";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable TT_SL_theoCHUYENBAY(string m)
        {
            string sql = "SELECT C.MASLGHE,C.MAHANGVE,C.MACHUYENBAY,C.SOLUONG,H.TENHANGVE FROM CHITIETSL C,HANGVE H WHERE H.MAHANGVE=C.MAHANGVE and MACHUYENBAY='" + m + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TT_SL_THEOSL(string m)
        {
            string sql = "SELECT C.MASLGHE, C.MAHANGVE,C.MACHUYENBAY,C.SOLUONG,H.TENHANGVE FROM CHITIETSL C,HANGVE H,CHUYENBAY B WHERE B.MACHUYENBAY=C.MACHUYENBAY AND H.MAHANGVE=C.MAHANGVE AND C.MASLGHE='" + m + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TT_CHITIETMAX()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT TOP 1 MASLGHE from CHITIETSL order by MASLGHE desc";
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void Them_SLGHE(CHITIETSLDTO sl)
        {
            string sql = "INSERT INTO CHITIETSL(MASLGHE,MACHUYENBAY,MAHANGVE,SOLUONG) VALUES ('" + sl.MASOLUONGGHE + "','" + sl.MACHUYENBAY + "','" + sl.MAHANGVE + "','" + sl.SOLUONG + "')";
            KetnoiCSDL.thucthitruyvan(sql);

        }
        public static void Xoa_SLGHE(CHITIETSLDTO SL)
        {
            string sql = "Delete from CHITIETSL where MASLGHE='" + SL.MASOLUONGGHE + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static void Capnhat_SLGHE(CHITIETSLDTO SL)
        {
            string sql = "Update CHITIETSL set MACHUYENBAY='" + SL.MACHUYENBAY + "',MAHANGVE='" + SL.MAHANGVE + "',SOLUONG='" + SL.SOLUONG + "'  where MASLGHE='" + SL.MASOLUONGGHE + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
    }
}
