using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Windows.Forms;
namespace banvemaybay.BUS
{
    class VAITROBUS
    {
        public static void Them_VT(VAITRODTO VT)
        {
            try
            {
                VAITRODAO.Them_VAITRO(VT);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm VAI TRO không thành công!");
            }
        }
        public static void Xoa_VT(VAITRODTO VT)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa VAI TRO này?", "Xác nhận",
           MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    VAITRODAO.Xoa_VAITRO(VT);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa VAI TRO không thành công!");
                }

            }
        }
        public static void CapNhat_VAITRO(VAITRODTO VT)
        {
            if (MessageBox.Show("Bạn có chắc muốn Cập nhật thông tin VAI TRO này khộng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    VAITRODAO.CapNhat_VAITRO(VT);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật VAI TRO không thành công!");
                }
            }
        }
    }
}
