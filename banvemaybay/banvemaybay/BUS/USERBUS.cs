using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Windows.Forms;


namespace banvemaybay.BUS
{
    class USERBUS
    {
        public static void Them_userDANGKY(USERDTO us)
        {
            if (MessageBox.Show("Bạn có chắc muốn dang ky user này?", "Xác nhận",
          MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    USERDAO.Them_USERdangky(us);
                   
                }
                catch (Exception)
                {
                    MessageBox.Show("SDT DA DUOC TAO DANG KY không thành công!");
                }
            }
        }
        public static void Them_user(USERDTO us)
        {
            if (MessageBox.Show("Bạn có chắc muốn dang ky user này?", "Xác nhận",
          MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                     USERDAO.Them_USER(us);
                    MessageBox.Show("them user thanh cong");
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm user không thành công!");
                }
            }
        }
        public static void Xoa_user(USERDTO us)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa user này?", "Xác nhận",
           MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    USERDAO.Xoa_USER(us);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa user không thành công!");
                }

            }
        }
        public static void CapNhat_user(USERDTO us)
        {
            if (MessageBox.Show("Bạn có chắc muốn Cập nhật thông tin user này khộng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    USERDAO.CapNhat_USER(us);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật user không thành công!");
                }
            }
        }
    }
}
