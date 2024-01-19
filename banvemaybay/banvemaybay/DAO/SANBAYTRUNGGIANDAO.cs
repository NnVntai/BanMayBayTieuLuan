using banvemaybay.DTO;
using System.Data;


namespace banvemaybay.DAO
{
    class SANBAYTRUNGGIANDAO
    {
        public static DataTable TT_TG_QUYDINH(string m)
        {
            string sql = "select MaSanbaytrunggian from SanBayTrungGian WHERE Machuyenbay='" + m + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TT_sanbayTG(string m)
        {
            string sql = "SELECT S.TENSANBAY,T.THOIGIANDUNG FROM SANBAYTRUNGGIAN T, SANBAY S WHERE T.MASANBAY=S.MASANBAY AND T.MaCHUYENBAY='" + m + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TT_SANBAYTRUNGGIAN()
        {
            string sql = "SELECT t.MasanbayTrunggian,t.MaSanBay,t.Machuyenbay,t.ThoiGianDung,s.TenSanBay FROM SANBAYTRUNGGIAN t, SanBAY s WHERE t.MaSanBay = s.MaSanBay ";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TT_SANBAYTRUNGGIAN_theosanbay(string m)
        {
            string sql = "SELECT t.MasanbayTrunggian,t.MaSanBay,t.Machuyenbay,t.ThoiGianDung,s.TenSanBay FROM SANBAYTRUNGGIAN t, SanBAY s WHERE t.MaSanBay = s.MaSanBay and MASANBAYTRUNGGIAN = '" + m + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TT_SANBAYTRUNGGIAN_theochuyenbay(string m)
        {
            string sql = "SELECT t.MasanbayTrunggian,t.MaSanBay,t.Machuyenbay,t.ThoiGianDung,s.TenSanBay  FROM SANBAYTRUNGGIAN t,SanBAY s WHERE t.MaSanBay=s.MaSanBay and t.MACHUYENBAY='" + m + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TT_SANBAYTRUNGGIANMAX()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT TOP 1 MASANBAYTRUNGGIAN from SANBAYTRUNGGIAN order by MASANBAYTRUNGGIAN desc";
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void Them_SANBAYTRUNGGIAN(SANBAYTRUNGGIANDTO tg)
        {
            string sql = "INSERT INTO SANBAYTRUNGGIAN(MASANBAYTRUNGGIAN,MACHUYENBAY,MASANBAY,THOIGIANDUNG) VALUES ('" + tg.MASANBAYTRUNGGIAN + "','" + tg.MACHUYENBAY + "','" + tg.MASANBAY + "','" + tg.THOIGIANDUNG + "')";
            KetnoiCSDL.thucthitruyvan(sql);

        }
        public static void Xoa_SANBAYTRUNGGIAN(SANBAYTRUNGGIANDTO tg)
        {
            string sql = "Delete from SANBAYTRUNGGIAN where MASANBAYTRUNGGIAN='" + tg.MASANBAYTRUNGGIAN + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static void Capnhat_SANBAYTRUNGGIAN(SANBAYTRUNGGIANDTO tg)
        {
            string sql = "Update SANBAYTRUNGGIAN set MACHUYENBAY='" + tg.MACHUYENBAY + "',MASANBAY='" + tg.MASANBAY + "',THOIGIANDUNG='" + tg.THOIGIANDUNG + "'  where MASANBAYTRUNGGIAN='" + tg.MASANBAYTRUNGGIAN + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
    }
}
