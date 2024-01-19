using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using banvemaybay.DAO;
using banvemaybay.DTO;
using System.Data.SqlClient;
using System.Data;


namespace banvemaybay.DAO
{
    class QUYDINHDAO
    {
        public static DataTable TT_QUYDINH()
        {
            string sql = "SELECT * FROM QUYDINH";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.DocDuLieu(sql);

            return dt;
        }
        public static void CapNhat_QUYDINH(QUYDINHDTO dc)
        {
            string sql = "Update QUYDINH set SOLUONGSANBAY='" + dc.SOLUONGSANBAY + "',SOSANBAYTOIDA='" + dc.SOSANBAYTOIDA + "',THOIGIANBAYTOITHIEU='" + dc.THOIGIANBAYTOITHIEU + "',THOIGIANCHAMNHATDATVE='" + dc.THOIGIANCHAMNHATDATVE + "',THOIGIANCHAMNHATHUYVE='" + dc.THOIGIANCHAMNHATHUYVE + "',THOIGIANDUNGTOIDA='" + dc.THOIGIANDUNGTOIDA + "',THOIGIANDUNGTOITHIEU='" + dc.THOIGIANDUNGTOITHIEU + "'";
            KetnoiCSDL.thucthitruyvan(sql);
        }
    }
}
