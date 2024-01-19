using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Windows.Forms;


namespace banvemaybay.BUS
{
    class SANBAYBUS
    {
        public static void Them_SanBay(SANBAYDTO SA)
        {
            try
            {
                SANBAYDAO.Them_SANBAY(SA);

            }
            catch (Exception)
            {
                MessageBox.Show("them san bay khong thanh cong");
            }
        }
        public static void Capnhat_SanBay(SANBAYDTO SA)
        {
            try
            {
                SANBAYDAO.CapNhat_SANBAY(SA);

            }
            catch (Exception)
            {
                MessageBox.Show("cap nhat  san bay khong thanh cong");
            }
        }
        public static void Xoa_SANBAY(SANBAYDTO SA)
        {
            try
            {
                SANBAYDAO.Xoa_SANBAY(SA);

            }
            catch (Exception)
            {
                MessageBox.Show("xoa san bay khong thanh cong");
            }
        }
    }
}
