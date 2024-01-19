using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Windows.Forms;
namespace banvemaybay.BUS
{
    class CHUYENBAYBUS
    {
        public static void Them_lichCB(CHUYENBAYDTO CB)
        {
            try
            {
                CHUYENBAYDAO.Them_ChuyenBay(CB);

            }
            catch (Exception)
            {
                MessageBox.Show("them chuyen bay khong thanh cong");
            }
        }
        public static void xoa_chuyenbay(CHUYENBAYDTO CB)
        {
            try
            {
                CHUYENBAYDAO.Xoa_ChuyenBay(CB);

            }
            catch (Exception)
            {
                MessageBox.Show("Xoa chuyen bay khong thanh cong");
            }
        }
        public static void capnhat_cb(CHUYENBAYDTO CB)
        {
            try
            {
                CHUYENBAYDAO.Capnhat_chuyenbay(CB);

            }
            catch (Exception)
            {
                MessageBox.Show("Cap Nhat chuyen bay khong thanh cong");
            }
        }
    }
}
