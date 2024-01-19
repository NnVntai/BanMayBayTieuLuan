using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using banvemaybay.DAO;
using banvemaybay.DTO;
using System.Windows.Forms;


namespace banvemaybay.BUS
{
    class QUYDINHBUS
    {
        public static void CapNhat_quyDinh(QUYDINHDTO hv)
        {
            if (MessageBox.Show("Bạn có chắc muốn Cập nhật thông tin Quy dinh này khộng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    QUYDINHDAO.CapNhat_QUYDINH(hv);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật Quy dinh không thành công!");
                }
            }
        }
    }
}
