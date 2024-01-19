using banvemaybay.DTO;
using System.Data;


namespace banvemaybay.DAO
{
    class DATVEDAO
    {
        public static DataTable tt_XOADAT_VE_QUYDINH(string mahangve)
        {
            string sql = "select MaPhieuDatCho from ChuyenBay,PhieuDatCho d where ChuyenBay.Machuyenbay=d.Machuyenbay and NgayGio<'" + mahangve + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }
        public static DataTable tt_DATCHO_QUYDINH(string mahangve)
        {
            string sql = "	select NgayDat from PhieuDatCho where MaPhieuDatCho='" + mahangve + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }
        public static DataTable tt_HIEMTHIQUAUSER(string mahangve)
        {
            string sql = "select P.MAPHIEUDATCHO,S.MACHUYENBAY,S.NGAYGIO,S.THOIGIAN,S.MASANBAYDEN,S.MASANBAYDI,H.TENHANGVE,H.MAHANGVE FROM CHUYENBAY S,HANGVE H,PHIEUDATCHO P WHERE H.MaHangVe=P.MaHangVe AND P.Machuyenbay=S.Machuyenbay AND P.MAHK='" + mahangve + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }
        public static DataTable TT_RP(string mahangve)
        {
            string sql = "select C.MACHUYENBAY,H.TENHANGVE AS HANGVE,U.SDT,C.GIA as GIATIEN,U.CMND,U.MAHK,P.MAPHIEUDATCHO FROM PHIEUDATCHO P,HANGVE H,USERA U,CHUYENBAY C WHERE H.MaHangVe=P.MaHangVe AND P.Machuyenbay=C.Machuyenbay AND P.MAHK=U.MAHK  AND P.MAHK='" + mahangve + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }
        public static DataTable tt_datVEchitiet(string mahangve)
        {
            string sql = "SELECT p.MaPhieuDatcho,p.Machuyenbay,p.MaHk,p.MaHangVE,p.NgayDat,t.ten,h.tenhangve FROM phieudatcho p,UserA t,Hangve h WHERE t.MaHK=p.MaHK and p.MaHangVe=h.MaHangve and p.MaPHIEUDATCHO='" + mahangve + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable tt_datVEtheochuyenbay(string mahangve)
        {
            string sql = "SELECT * FROM phieudatcho WHERE MaChuyenbay='" + mahangve + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }

        public static DataTable TT_DATCHOTHEOSDL()
        {
            string sql = "SELECT U.SDT,U.TEN,P.MAHK,P.MACHUYENBAY,P.MAPHIEUDATCHO FROM PHIEUDATCHO P,USERA U WHERE P.MAHK=U.MAHK";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }


        public static DataTable TT_DATCHO()
        {
            string sql = "select p.MaPhieuDatcho,p.Machuyenbay,p.MaHk,p.MaHangVE,p.NgayDat,t.ten,h.tenhangve FROM phieudatcho p,UserA t,Hangve h WHERE t.MaHK=p.MaHK and p.MaHangVe=h.MaHangve";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }
        public static void Them_DATCHO(DATCHODDTO dc)
        {
            string sql = "INSERT INTO PHIEUDATCHO([MAHANGVE], [MAPHIEUDATCHO],[MACHUYENBAY],[MAHK],[NGAYDAT]) VALUES('" + dc.MahangVE + "', '" + dc.MaPhieuDatCho + "','" + dc.MachyenBay + "','" + dc.MAHK + "','" + dc.NgayDat + "')";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static void Xoa_DATCHO(DATCHODDTO dc)
        {
            string sql = "Delete from PHIEUDATCHO where MAPHIEUDATCHO='" + dc.MaPhieuDatCho + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static void CapNhat_DATCHO(DATCHODDTO dc)
        {
            string sql = "Update PHIEUDATCHO set MACHUYENBAY=N'" + dc.MachyenBay + "',MAHANGVE='" + dc.MahangVE + "',MAHK='" + dc.MAHK + "',NGAYDAT='" + dc.NgayDat + "' where MAPHIEUDATCHO = '" + dc.MaPhieuDatCho + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static DataTable MAPHIEUDATCHOVeMax()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT TOP 1 MAPHIEUDATCHO from PHIEUDATCHO order by MAPHIEUDATCHO desc";
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
    }
}
