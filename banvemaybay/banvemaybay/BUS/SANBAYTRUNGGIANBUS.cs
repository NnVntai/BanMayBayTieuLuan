using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Windows.Forms;


namespace banvemaybay.BUS
{
    class SANBAYTRUNGGIANBUS
    {
        public static void Them_SanBaytrunggian(SANBAYTRUNGGIANDTO TG)
        {
            try
            {
                SANBAYTRUNGGIANDAO.Them_SANBAYTRUNGGIAN(TG);

            }
            catch (Exception)
            {
                MessageBox.Show("them san bay TRUNG GIAN khong thanh cong");
            }
        }
        public static void Capnhat_SanBaytrunggian(SANBAYTRUNGGIANDTO TG)
        {
            try
            {
                SANBAYTRUNGGIANDAO.Capnhat_SANBAYTRUNGGIAN(TG);


            }
            catch (Exception)
            {
                MessageBox.Show("cap nhat  san bay TRUNG GIAN khong thanh cong");
            }
        }
        public static void Xoa_SANBAYtrunggiaN(SANBAYTRUNGGIANDTO TG)
        {
            try
            {
                SANBAYTRUNGGIANDAO.Xoa_SANBAYTRUNGGIAN(TG);

            }
            catch (Exception)
            {
                MessageBox.Show("xoa san bay TRUNG GIAN khong thanh cong");
            }
        }
    }
}
