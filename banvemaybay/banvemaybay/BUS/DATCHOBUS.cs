using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Windows.Forms;

namespace banvemaybay.BUS
{
    class DATCHOBUS
    {
        public static void Them_DATCHO(DATCHODDTO dc)
        {
            try
            {
                DATVEDAO.Them_DATCHO(dc);

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm dat cho không thành công!");
            }
        }
        public static void Xoa_DATCHO(DATCHODDTO dc)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dat cho này?", "Xác nhận",
           MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DATVEDAO.Xoa_DATCHO(dc);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa dat cho không thành công!");
                }

            }
        }
        public static void CapNhat_DATCHO(DATCHODDTO dc)
        {
            if (MessageBox.Show("Bạn có chắc muốn Cập nhật thông tin dat cho này khộng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DATVEDAO.CapNhat_DATCHO(dc);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật dat cho không thành công!");
                }
            }
        }
    }
}
