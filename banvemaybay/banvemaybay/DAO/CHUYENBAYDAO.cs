using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using banvemaybay.DTO;

namespace banvemaybay.DAO
{
    class CHUYENBAYDAO
    {
        public static DataTable CHONG()
        {
            string sql = "select c.machuyenbay,c.NgayGio,c.ThoiGian,(select s.Tensanbay from SanBay s where s.MaSanBay = c.MaSanBayDi) AS 'TENSANBAYDI',(select s.tensanbay from SanBay s where s.MaSanBay = c.MaSanBayDen ) AS'TENSANBAYDEN' ,(select soluong from ChitietSL where ChitietSL.Machuyenbay = c.Machuyenbay and ChitietSL.MaHangVe = 'HV001') AS 'SOLUONGGHELOAI1',(select soluong from ChitietSL where ChitietSL.Machuyenbay = c.Machuyenbay and ChitietSL.MaHangVe = 'HV002') AS 'SOLUONGGHELOAI2',t.MaSanbayTrungGian,(select s.tensanbay from SanBay s where s.MaSanBay = t.MaSanBay) AS 'TENSANBAYTRUNGGIAN' ,t.ThoiGianDung,'H1'AS GHICHU from ChuyenBay c,SanBayTrungGian t where c.Machuyenbay = 'cb002' AND c.Machuyenbay=t.Machuyenbay";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable NAM()
        {
            string sql = "select distinct YEAR(ngaygio) from ChuyenBay group by NgayGio ";


            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable doanhthuNAM(int chuyenbay)
        {
            string sql = "select YEAR(C.ngaygio) as 'nam',Month(C.ngaygio) as 'thang',(select count(A.Machuyenbay) from ChuyenBay A where YEAR(A.NgayGio)=" + chuyenbay + " AND MONTH(A.NgayGio)=MONTH(C.NGAYGIO)) as 'sochuyenbay' ,(select SUM(Z.GIA) FROM ChuyenBay Z,VechuyenBay V WHERE V.Machuyenbay=Z.Machuyenbay AND YEAR(Z.NgayGio)=" + chuyenbay + " AND MONTH(Z.NgayGio ) =MONTH(C.NgayGio)) as 'doanhthu',((select SUM(Z.GIA) FROM ChuyenBay Z,VechuyenBay V WHERE V.Machuyenbay=Z.Machuyenbay AND YEAR(Z.NgayGio)=2021 AND MONTH(Z.NgayGio ) =MONTH(C.NgayGio))/(select SUM(Z.GIA) FROM ChuyenBay Z,VechuyenBay V WHERE V.Machuyenbay=Z.Machuyenbay AND YEAR(Z.NgayGio)=" + chuyenbay + "))*100.0 as 'tyle' from chuyenbay c, VechuyenBay where c.Machuyenbay=VechuyenBay.Machuyenbay and YEAR(ngaygio)=" + chuyenbay + " group by NgayGio,NgayGio";


            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable doanhthuthang(int chuyenbay)
        {
            string sql = "SELECT C.MACHUYENBAY,MONTH(C.NgayGio)AS THANG ,COUNT(V.MAVECHUYENBAY) AS SOVE ,COUNT(V.MAVECHUYENBAY)*C.GIA AS DOANHTHU ,(100.0*COUNT(V.MAVECHUYENBAY)/(SELECT SUM(S.SOLUONG) FROM ChitietSL S,ChuyenBay A WHERE S.Machuyenbay=A.Machuyenbay AND A.Machuyenbay=C.Machuyenbay GROUP BY S.Machuyenbay )*1.0)AS TYLE  FROM CHUYENBAY C,VECHUYENBAY V WHERE C.Machuyenbay=V.Machuyenbay AND MONTH(C.NgayGio)="+ chuyenbay +"  GROUP BY C.Machuyenbay,C.GIA,C.NgayGio";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TT_CHUYENBAYa(string chuyenbay)
        {
            string sql = "SELECT * FROM ChuyenBay where machuyenbay='" + chuyenbay + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TT_TRUQUYDINH(string chuyenbay)
        {
            string sql = "	SELECT (NGAYGIO-CAST(THOIGIANCHAMNHATDATVE AS datetime))AS THOIGIANSAUKHITRU FROM CHUYENBAY,QUYDINH WHERE Machuyenbay='" + chuyenbay + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable TT_RF()
        {
            string sql = "SELECT C.MACHUYENBAY,C.ThoiGian,C.NgayGio,C.MaSanBayDen,C.MaSanBayDi,(SELECT SUM(S.SOLUONG)  FROM ChitietSL S,ChuyenBay A WHERE S.Machuyenbay=A.Machuyenbay AND C.Machuyenbay=A.Machuyenbay  GROUP BY S.MACHUYENBAY) -(SELECT COUNT(P.MAPHIEUDATCHO) FROM PhieuDatCho P,ChuyenBay D WHERE P.Machuyenbay=D.Machuyenbay AND D.Machuyenbay=C.Machuyenbay ) AS SOGHETRONG,(SELECT COUNT(P.MAPHIEUDATCHO) FROM PhieuDatCho P,ChuyenBay D WHERE P.Machuyenbay=D.Machuyenbay AND D.Machuyenbay=C.Machuyenbay ) AS SOGHEDAT FROM CHUYENBAY C";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable TT_CHUYENBAY()
        {
            string sql = "select c.machuyenbay,c.NgayGio,c.ThoiGian,c.Gia,c.MaSanBayDi,c.MaSanBayDen,(select s.TenSanbay from SanBay s where s.MaSanBay=c.MaSanBayDi ) as 'tensanbaydi',(select s.TenSanbay from SanBay s where s.MaSanBay=c.MaSanBayDen ) as 'tensanbayden' from chuyenbay c";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TT_chuyenbay_max()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT TOP 1 MaChuyenBay from ChuyenBay order by MaChuyenBay desc";
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void Them_ChuyenBay(CHUYENBAYDTO cb)
        {
            string sql = "INSERT INTO ChuyenBay(MachuyenBay,MaSanBayDen,MaSanBayDi,ThoiGian,NgayGio,Gia) VALUES ('" + cb.MachyenBay + "','" + cb.MASANBAYDEN + "','" + cb.MASANBAYDI + "','" + cb.ThoiGian + "','" + cb.NgayGio + "','" + cb.Gia + "' )";
            KetnoiCSDL.thucthitruyvan(sql);

        }
        public static void Xoa_ChuyenBay(CHUYENBAYDTO cb)
        {
            string sql = "Delete from CHUYENBAY where MaChuyenBay='" + cb.MachyenBay + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static void Capnhat_chuyenbay(CHUYENBAYDTO cb)
        {
            string sql = "Update ChuyenBay set NgayGio='" + cb.NgayGio + "',ThoiGian='" + cb.ThoiGian + "',Gia='" + cb.Gia + "',MaSanBayDen='" + cb.MASANBAYDEN  + "',MaSanBayDi='" + cb.MASANBAYDI + "' where MaChuyenBay = '" + cb.MachyenBay+ "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
    }
}
