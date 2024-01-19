using banvemaybay.BUS;
using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace banvemaybay.GUI
{
    public partial class THAYDOITHONGTIN : Form
    {
        string ssdt;
        string mahk;
        public THAYDOITHONGTIN(string sdt, string makh)
        {
            InitializeComponent();
            ssdt = sdt;
            mahk = makh;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void THAYDOITHONGTIN_Load(object sender, EventArgs e)
        {
            SDT.Text = ssdt;


        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            int a = 0;
            USERDTO us = new USERDTO();
            DataTable dt = new DataTable();
            dt = USERDAO.TT_USER();
            int soluong = dt.Rows.Count;
            if (soluong > 0)
            {

                if (a == 0)
                {
                    us.MAHK = mahk;
                    us.CMND = txCMND.Text;
                    us.MaVaiTro = "VT002";
                    us.Ten = txhoten.Text;
                    us.SDT = ssdt;
                    us.password = txpassword.Text;
                    USERBUS.CapNhat_user(us);
                    
                }
                else
                {
                    MessageBox.Show("SO DIEN THOAT DA CO NGUOI TRUNG XIN VUI LONG KIEM TRA LAI");
                }
            }
        }
    }
}
