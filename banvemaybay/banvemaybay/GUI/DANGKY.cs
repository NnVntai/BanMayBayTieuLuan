using banvemaybay.BUS;
using banvemaybay.DTO;
using System;
using System.Windows.Forms;
using banvemaybay.DAO;
using System.Data;



namespace banvemaybay.GUI
{
    public partial class DANGKY : Form
    {
        public DANGKY()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DANGKY_Load(object sender, EventArgs e)
        {

        }

        private void btdangky_Click(object sender, EventArgs e)
        {
            if (txpassword.Text == txrepass.Text)
            {
                int a = 0;

                string mahk = "";
                DataTable cb = new DataTable();

                cb = USERDAO.VAITROMAX();

                if (cb.Rows.Count == 0)
                {
                    mahk = "KH001";
                }
                else
                {
                    string mb = cb.Rows[0][0].ToString();




                    mahk = "KH" + (Convert.ToInt32(mb.Substring(mb.Length - 9, 9)) + 1).ToString("000");
                }

                USERDTO us = new USERDTO();
                DataTable dt = new DataTable();
                dt = USERDAO.TT_USER();
                int soluong = dt.Rows.Count;
                if (soluong > 0)
                {

                    for (int i = 0; i < soluong; i++)
                    {
                        int b = Convert.ToInt32(dt.Rows[i]["SDT"].ToString());
                        int c = Convert.ToInt32(txsdt.Text);
                        if (c == b)
                        {
                            a = 1;
                        }



                    }

                    if (0 == a)
                    {
                        us.MAHK = mahk;
                        us.CMND = txcmnd.Text;
                        us.MaVaiTro = "VT002";
                        us.Ten = txten.Text;
                        us.SDT = txsdt.Text;
                        us.password = txpassword.Text;
                        USERBUS.Them_user(us);

                    }
                    else
                    {
                        MessageBox.Show("SO DIEN THOAT DA CO NGUOI TRUNG XIN VUI LONG KIEM TRA LAI");
                    }
                }
                else
                {
                    us.MAHK = mahk;
                    us.CMND = txcmnd.Text;
                    us.MaVaiTro = "VT002";
                    us.Ten = txten.Text;
                    us.SDT = txsdt.Text;
                    us.password = txpassword.Text;
                    USERBUS.Them_user(us);

                }
            }else
            {
                MessageBox.Show("Password sai vui lòng nhập lại ");
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            LOGIN f = new LOGIN();
            f.Show();
            this.Close();
        }
    }
}
