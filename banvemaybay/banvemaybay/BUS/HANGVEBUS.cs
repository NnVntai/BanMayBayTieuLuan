using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Windows.Forms;

namespace banvemaybay.BUS
{
    class HANGVEBUS
    {
        public static void Them_Hang_Ve(HANGVEDTO hv)
        {
            try
            {
                HANGVEDAO.Them_HANGVE(hv);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm hạng vé không thành công!");
            }
        }
        public static void Xoa_Hang_Ve(HANGVEDTO hv)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa hạng vé này?", "Xác nhận",
           MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    HANGVEDAO.Xoa_HANGVE(hv);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa hạng vé không thành công!");
                }

            }
        }
        public static void CapNhat_HANGVE(HANGVEDTO hv)
        {
            if (MessageBox.Show("Bạn có chắc muốn Cập nhật thông tin hạng vé này khộng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    HANGVEDAO.CapNhat_HANGVE(hv);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật hạng vé không thành công!");
                }
            }
        }
    }
}
