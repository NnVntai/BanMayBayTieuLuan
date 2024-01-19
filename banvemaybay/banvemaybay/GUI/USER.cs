using banvemaybay.BUS;
using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace banvemaybay.GUI
{
    public partial class USER : Form
    {
        public USER()
        {
            InitializeComponent();
        }
        public void TT_userLi()

        {
            listView1.Items.Clear();
            DataTable tg = new DataTable();
            tg = USERDAO.TT_USERLi(txvaitroli.SelectedValue.ToString());
            int soluong = tg.Rows.Count;
            for (int i = 0; i < soluong; i++)
            {
                listView1.Items.Add(tg.Rows[i][0].ToString());
                listView1.Items[i].SubItems.Add(tg.Rows[i][1].ToString());
                listView1.Items[i].SubItems.Add(tg.Rows[i][2].ToString());
                listView1.Items[i].SubItems.Add(tg.Rows[i][3].ToString());
                listView1.Items[i].SubItems.Add(tg.Rows[i][4].ToString());

            }
        }

        public void TT_user()

        {
            listView1.Items.Clear();
            DataTable tg = new DataTable();
            tg = USERDAO.TT_USER();
            int soluong = tg.Rows.Count;
            for (int i = 0; i < soluong; i++)
            {
                listView1.Items.Add(tg.Rows[i][0].ToString());
                listView1.Items[i].SubItems.Add(tg.Rows[i][1].ToString());
                listView1.Items[i].SubItems.Add(tg.Rows[i][2].ToString());
                listView1.Items[i].SubItems.Add(tg.Rows[i][3].ToString());
                listView1.Items[i].SubItems.Add(tg.Rows[i][4].ToString());

            }
        }
        public void TT_vaitroLi()
        {
            DataTable sa = new DataTable();
            sa = VAITRODAO.TT_VAITRO();
            txvaitroli.DataSource = sa;
            txvaitroli.ValueMember = "MAVAITRO";
            txvaitroli.DisplayMember = "TENVAITRO";
        }
        public void TT_vaitro()
        {
            DataTable sa = new DataTable();
            sa = VAITRODAO.TT_VAITRO();
            cbVaiTro.DataSource = sa;
            cbVaiTro.ValueMember = "MAVAITRO";
            cbVaiTro.DisplayMember = "TENVAITRO";
        }
        private void USER_Load(object sender, EventArgs e)
        {
            TT_user();
            TT_vaitro();
          
            TT_vaitroLi();

        }

        private void btthem_Click(object sender, EventArgs e)
        {

            DataTable cb = new DataTable();

            cb = USERDAO.VAITROMAX();

            if (cb.Rows.Count == 0)
            {
                TXMAKH.Text = "KH001";
            }
            else
            {
                string mb = cb.Rows[0][0].ToString();




                TXMAKH.Text = "KH" + (Convert.ToInt32(mb.Substring(mb.Length - 9, 9)) + 1).ToString("000");
            }
            txCMND.Text = "";
            txHoten.Text = "";
            txSDT.Text = "";
            cbVaiTro.Text = "";
            txpassword.Text = "";

        }

        private void btghi_Click(object sender, EventArgs e)
        {
            int a = 0;
            USERDTO us = new USERDTO();
            DataTable dt = new DataTable();
            dt = USERDAO.TT_USER();
            int soluong = dt.Rows.Count;
            if (soluong > 0)
            {
                
                for (int i = 0; i < soluong; i++)
                {
                    int b = Convert.ToInt32(dt.Rows[i]["SDT"].ToString());
                    int c = Convert.ToInt32(txSDT.Text);
                    if (c == b)
                    {

                        a=1;
                    }


                }

                if (a == 0)
                {
                    us.MAHK = TXMAKH.Text;
                    us.CMND = txCMND.Text;
                    us.MaVaiTro = cbVaiTro.SelectedValue.ToString();
                    us.Ten = txHoten.Text;
                    us.SDT = txSDT.Text;
                    us.password = txpassword.Text;
                    USERBUS.Them_user(us);
                  
                    listView1.Items.Clear();
                    TT_user();
                }
                else
                {
                    MessageBox.Show("SO DIEN THOAT DA CO NGUOI TRUNG XIN VUI LONG KIEM TRA LAI");
                }
            }
            else
            {
                us.MAHK = TXMAKH.Text;
                us.CMND = txCMND.Text;
                us.MaVaiTro = cbVaiTro.SelectedValue.ToString();
                us.Ten = txHoten.Text;
                us.SDT = txSDT.Text;
                us.password = txpassword.Text;
                USERBUS.Them_user(us);
              
                listView1.Items.Clear();
                TT_user();

            }

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            USERDTO us = new USERDTO();
            us.MAHK = TXMAKH.Text;
            us.CMND = txCMND.Text;

            USERBUS.Xoa_user(us);
          
            listView1.Items.Clear();
            TT_user();
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
                    us.MAHK = TXMAKH.Text;
                    us.CMND = txCMND.Text;
                    us.MaVaiTro = cbVaiTro.SelectedValue.ToString();
                    us.Ten = txHoten.Text;
                    us.SDT = txSDT.Text;
                    us.password = txpassword.Text;
                    USERBUS.CapNhat_user(us);
                    listView1.Items.Clear();
                    TT_user();
                }
                else
                {
                    MessageBox.Show("SO DIEN THOAT DA CO NGUOI TRUNG XIN VUI LONG KIEM TRA LAI");
                }
            }

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            TXMAKH.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txSDT.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txHoten.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txCMND.Text = listView1.SelectedItems[0].SubItems[3].Text;
            cbVaiTro.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txvaitroli_SelectedIndexChanged(object sender, EventArgs e)
        {
            TT_userLi();
        }

        private void txvaitroli_Click(object sender, EventArgs e)
        {
           
        }
    }
}
