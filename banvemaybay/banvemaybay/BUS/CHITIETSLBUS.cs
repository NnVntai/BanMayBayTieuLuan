using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Windows.Forms;


namespace banvemaybay.BUS
{
    class CHITIETSLBUS
    {
        public static void Them_SL(CHITIETSLDTO sl)
        {
            try
            {
                CHITIETSLDAO.Them_SLGHE(sl);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm SL không thành công!");
            }
        }
        public static void Xoa_SL(CHITIETSLDTO sl)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa sl này?", "Xác nhận",
           MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    CHITIETSLDAO.Xoa_SLGHE(sl);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa SL không thành công!");
                }

            }
        }
        public static void CapNhat_SL(CHITIETSLDTO sl)
        {
            if (MessageBox.Show("Bạn có chắc muốn Cập nhật thông tin SL này khộng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    CHITIETSLDAO.Capnhat_SLGHE(sl);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật SL không thành công!");
                }
            }
        }
    }
}
