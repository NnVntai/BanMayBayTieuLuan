using banvemaybay.DTO;
using System.Data;


namespace banvemaybay.DAO
{
    class USERDAO
    {
        public static DataTable TT_DANGNHAP(string sdt, string password)
        {
            string sql = "SELECT [MAHK],[SDT],[password],[MAVAITRO],[Ten] FROM userA WHERE sdt='" + sdt + "' and password='" + password + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }
        public static void Them_USERdangky(USERDTO us)
        {
            string sql = "INSERT INTO userA([MAHK],[SDT], [Ten],[CMND],[MaVaiTro],[password]) VALUES('" + us.MAHK + "','" + us.SDT + "', N'" + us.Ten + "','" + us.CMND + "','VT002','" + us.password + "')";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static DataTable TT_chitiettheovaitro(string masanbay)
        {
            string sql = "SELECT [MAHK],[SDT], [Ten],[CMND],[MaVaiTro] FROM userA WHERE MAVAITRO='" + masanbay + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }
        public static DataTable TT_chitiettheoUSER(string masanbay)
        {
            string sql = "SELECT [MAHK],[SDT], [Ten],[CMND],[MaVaiTro] FROM userA WHERE MAHK='" + masanbay + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }
        public static DataTable TT_USERLi(string mavaitro)
        {

            string sql = "SELECT [MAHK],[SDT], [Ten],[CMND],[TenVaiTro],UserA.MaVaiTro FROM UserA, VaiTro where VaiTro.MaVaitro=UserA.MaVaitro AND UserA.MaVaiTro='" + mavaitro + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TT_USER()
        {

            string sql = "SELECT [MAHK],[SDT], [Ten],[CMND],[TenVaiTro],UserA.MaVaiTro FROM UserA, VaiTro where VaiTro.MaVaitro=UserA.MaVaitro ";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }

        public static void Them_USER(USERDTO us)
        {
            string sql = "INSERT INTO userA([MAHK],[SDT], [Ten],[CMND],[MaVaiTro],[password]) VALUES('" + us.MAHK + "','" + us.SDT + "', N'" + us.Ten + "','" + us.CMND + "','" + us.MaVaiTro + "','" + us.password + "')";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static void Xoa_USER(USERDTO us)
        {
            string sql = "Delete from userA where MAHK='" + us.MAHK + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static void CapNhat_USER(USERDTO us)
        {
            string sql = "Update userA set [Ten]='" + us.Ten + "',[MaVaiTro]='" + us.MaVaiTro + "',[CMND]='" + us.CMND + "',[password]='" + us.password + "', [SDT]= '" + us.SDT + "' where [MAHK]='" + us.MAHK + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
        public static DataTable VAITROMAX()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT TOP 1 MAHK from USERA order by MAHK desc";
            dt = KetnoiCSDL.DocDuLieu(sql);
            return dt;
        }
    }
}
