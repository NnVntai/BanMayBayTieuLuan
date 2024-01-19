using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Windows.Forms;


namespace banvemaybay.BUS
{
    class VECHUYENBAYBUS
    {
        public static void Them_DATCHO(VECHUYENBAYDTO ve)
        {
            try
            {
                VECHUYENBAYDAO.Them_VE(ve);

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm DAT VE không thành công!");
            }
        }
        public static void Xoa_DATCHO(VECHUYENBAYDTO ve)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa DAT VE này?", "Xác nhận",
           MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    VECHUYENBAYDAO.Xoa_VE(ve);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa DAT VE không thành công!");
                }

            }
        }
        public static void CapNhat_DATCHO(VECHUYENBAYDTO ve)
        {
            if (MessageBox.Show("Bạn có chắc muốn Cập nhật thông tin DAT VE này khộng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    VECHUYENBAYDAO.CapNhat_VE(ve);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật DAT VE không thành công!");
                }
            }
        }
    }
}
