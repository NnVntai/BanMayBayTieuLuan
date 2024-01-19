using banvemaybay.DTO;
using System.Data;

namespace banvemaybay.DAO
{
    class VECHUYENBAYDAO
    {
        public static DataTable KIEMTRA_CONVE(string machuyenbay,string mahangve)
        {
            string sql = "select s.Machuyenbay,(soluong -(count(maphieudatcho)+COUNT(v.Mavechuyenbay))) from ChitietSL s,PhieuDatCho p,VechuyenBay v where s.MaHangVe=p.MaHangVe and v.MaHangve=s.MaHangVe and  s.Machuyenbay='" + machuyenbay + "' and s.MaHangVe='" + mahangve + "'  group by Soluong,s.Machuyenbay ";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable tt_hiemthivemua(string mahangve)
        {
            string sql = "select S.MACHUYENBAY,S.NGAYGIO,S.THOIGIAN,S.MASANBAYDEN,S.MASANBAYDI,H.TENHANGVE,H.MAHANGVE,P.MAVECHUYENBAY FROM CHUYENBAY S,HANGVE H,VECHUYENBAY P WHERE H.MaHangVe=P.MaHangVe AND P.Machuyenbay=S.Machuyenbay AND P.MAHK='" + mahangve + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }
        public static DataTable TT_RP(string mahangve)
        {
            string sql = "select C.MACHUYENBAY,H.TENHANGVE as MAHANGVE ,U.SDT,C.GIA ,U.CMND,U.MAHK,P.MAVECHUYENBAY FROM VECHUYENBAY P,HANGVE H,USERA U,CHUYENBAY C WHERE H.MaHangVe=P.MaHangVe AND P.Machuyenbay=C.Machuyenbay AND P.MAHK=U.MAHK  AND P.MAHK='" + mahangve + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }
        public static DataTable tt_datVEchitiet(string mahangve)
        {
            string sql = "SELECT * FROM VECHUYENBAY WHERE MaVECHUYENBAY='" + mahangve + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }
        public static DataTable tt_datVEtheochuyenbay(string mahangve)
        {
            string sql = "SELECT * FROM VECHUYENBAY WHERE MaVECHUYENBAY='" + mahangve + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }

        public static DataTable TT_DATCHOTHEOSDL()
        {
            string sql = "SELECT U.TEN,U.SDT,P.MAHK,P.MACHUYENBAY,P.MAVECHUYENBAY FROM VECHUYENBAY P,USERA U WHERE P.MAHK=U.MAHK";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }
        public static DataTable TT_VE_THeochuyenbay(string chuyenbay)
        {
            string sql = "SELECT v.MaveChuyenBay,t.ten,v.Machuyenbay,h.tenHangVe,v.MAHK FROM VECHUYENBAY v,HangVe h,UserA t where h.Mahangve=v.MaHangVe and t.MAHK=v.MAHK and v.Machuyenbay='" + chuyenbay + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }

        public static DataTable TT_VE()
        {
            string sql = "SELECT v.MaveChuyenBay,v.MaHK,v.Machuyenbay,v.MahangVe,h.tenHangVe,t.Ten FROM VECHUYENBAY v,HangVe h,usera t where h.Mahangve=v.MaHangVe and t.MaHK=v.Mahk";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }
        public static void Them_VE(VECHUYENBAYDTO ve)
        {
            string sql = "INSERT INTO VECHUYENBAY([MAHANGVE], [mavechuyenbay],[MACHUYENBAY],[MAHK]) VALUES('" + ve.MahangVe + "', '" + ve.mavechuyenbay + "','" + ve.machuyenbay + "','" + ve.MAHK + "')";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static void Xoa_VE(VECHUYENBAYDTO ve)
        {
            string sql = "Delete from VECHUYENBAY where MAVECHUYENBAY='" + ve.mavechuyenbay + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static void CapNhat_VE(VECHUYENBAYDTO ve)
        {
            string sql = "Update VECHUYENBAY set MACHUYENBAY='" + ve.machuyenbay + "',MAHANGVE='" + ve.MahangVe + "',MAHK='" + ve.MAHK + "' where MAVECHUYENBAY = '" + ve.mavechuyenbay + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static DataTable MAVEVeMax()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT TOP 1 MAVECHUYENBAY from VECHUYENBAY order by MAVECHUYENBAY desc";
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
    }
}
