using banvemaybay.BUS;
using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace banvemaybay.GUI
{
    public partial class SANBAYTRUNGGIAN : Form
    {
        public SANBAYTRUNGGIAN()
        {
            InitializeComponent();
        }
        public void LOadtreview(TreeView tree)
        {
            TreeNode nodcha = new TreeNode();
            DataTable dt = new DataTable();
            dt = CHUYENBAYDAO.TT_CHUYENBAY();
            int soluong = dt.Rows.Count;
            DataTable dtnv = new DataTable();
            dtnv = SANBAYTRUNGGIANDAO.TT_SANBAYTRUNGGIAN();
            int soluong_nv = dtnv.Rows.Count;

            for (int i = 0; i < soluong; i++)
            {
                nodcha = tre.Nodes.Add(dt.Rows[i]["MACHUYENBAY"].ToString());
                nodcha.Tag = dt.Rows[i]["MACHUYENBAY"].ToString();
                for (int j = 0; j < soluong_nv; j++)
                {
                    if (dt.Rows[i]["MACHUYENBAY"].ToString() == dtnv.Rows[j]["MACHUYENBAY"].ToString())
                    {
                        TreeNode nodcon = new TreeNode();
                        nodcon.Text = dtnv.Rows[j]["MASANBAYTRUNGGIAN"].ToString();
                        nodcon.Tag = dtnv.Rows[j]["MASANBAYTRUNGGIAN"].ToString();
                        nodcha.Nodes.Add(nodcon);
                    }

                }
            }
        }
        public void TT_sanbaytrunggian()

        {
            DataTable tg = new DataTable();
            tg = SANBAYTRUNGGIANDAO.TT_SANBAYTRUNGGIAN();
            int soluong = tg.Rows.Count;
            for (int i = 0; i < soluong; i++)
            {
                listView1.Items.Add(tg.Rows[i]["MaSanbaytrunggian"].ToString());
                listView1.Items[i].SubItems.Add(tg.Rows[i]["TensanBay"].ToString());
                listView1.Items[i].SubItems.Add(tg.Rows[i]["Machuyenbay"].ToString());
                listView1.Items[i].SubItems.Add(tg.Rows[i]["Thoigiandung"].ToString());

            }
        }
        public void TT_chuyenbay()
        {
            DataTable cb = new DataTable();
            cb = CHUYENBAYDAO.TT_CHUYENBAY();
            int sodong = cb.Rows.Count;
            for (int i = 0; i < sodong; i++)
            {
                cbChuyenBay.Items.Add(cb.Rows[i][0].ToString());
            }


        }
        public void TT_sanbay()
        {
            DataTable sa = new DataTable();
            sa = SANBAYDAO.TT_SANBAY();
            cbMasanBay.DataSource = sa;
            cbMasanBay.ValueMember = "MASANBAY";
            cbMasanBay.DisplayMember = "TENSANBAY";
        }
        private void SANBAYTRUNGGIANDTO_Load(object sender, EventArgs e)
        {
            TT_chuyenbay();
            TT_sanbay();
            TT_sanbaytrunggian();
            LOadtreview(tre);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable max = new DataTable();


            max = SANBAYTRUNGGIANDAO.TT_SANBAYTRUNGGIANMAX();
            if (max.Rows.Count == 0)
            { txtMaSanBayTrungGian.Text = "TG001"; }
            else
            {
                string maxx = max.Rows[0][0].ToString();

                txtMaSanBayTrungGian.Text = "TG" + (Convert.ToInt32(maxx.Substring(maxx.Length - 3, 3)) + 1).ToString("000");
                txtthoigian.Text = "";
                cbChuyenBay.Text = "";
                cbMasanBay.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SANBAYTRUNGGIANDTO tg = new SANBAYTRUNGGIANDTO();
            DataTable dt = new DataTable();
            DataTable AT = new DataTable();
            dt = QUYDINHDAO.TT_QUYDINH();
            AT = SANBAYTRUNGGIANDAO.TT_TG_QUYDINH(cbChuyenBay.Text);
            int daco = AT.Rows.Count;
            int Soluong = Convert.ToInt32( dt.Rows[0]["SOSANBAYTOIDA"].ToString());
            DateTime tgdungcao = DateTime.Parse(dt.Rows[0]["THOIGIANDUNGTOIDA"].ToString());
            DateTime tgdungthap = DateTime.Parse(dt.Rows[0]["THOIGIANDUNGTOITHIEU"].ToString());
            DateTime nhap = DateTime.Parse(txtthoigian.Text);
            if ((Soluong < daco)||(tgdungthap>nhap)||(tgdungcao<nhap))
            {

                MessageBox.Show("so san bay vuoc qua  so voi quy dinh");
            }
            else
            {
                tg.MASANBAYTRUNGGIAN = txtMaSanBayTrungGian.Text;
                tg.MACHUYENBAY = cbChuyenBay.Text;
                tg.MASANBAY = cbMasanBay.SelectedValue.ToString();
                tg.THOIGIANDUNG = txtthoigian.Text;
                SANBAYTRUNGGIANBUS.Them_SanBaytrunggian(tg);
            }
            tre.Nodes.Clear();
            LOadtreview(tre);
            listView1.Items.Clear();
            TT_sanbaytrunggian();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SANBAYTRUNGGIANDTO tg = new SANBAYTRUNGGIANDTO();
            tg.MASANBAYTRUNGGIAN = txtMaSanBayTrungGian.Text;
            SANBAYTRUNGGIANDAO.Xoa_SANBAYTRUNGGIAN(tg);
            tre.Nodes.Clear();
            LOadtreview(tre);
            listView1.Items.Clear();
            TT_sanbaytrunggian();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable AT = new DataTable();
            dt = QUYDINHDAO.TT_QUYDINH();
            AT = SANBAYTRUNGGIANDAO.TT_TG_QUYDINH(cbChuyenBay.Text);
            int daco = AT.Rows.Count;
            int Soluong = Convert.ToInt32(dt.Rows[0]["SOSANBAYTOIDA"].ToString());
            DateTime tgdungcao = DateTime.Parse(dt.Rows[0]["THOIGIANDUNGTOIDA"].ToString());
            DateTime tgdungthap = DateTime.Parse(dt.Rows[0]["THOIGIANDUNGTOITHIEU"].ToString());
            DateTime nhap = DateTime.Parse(txtthoigian.Text);
            if ((Soluong < daco) || (tgdungthap > nhap) || (tgdungcao < nhap))
            {

                MessageBox.Show("so san bay vuoc qua  so voi quy dinh");
            }
            else
            {
                SANBAYTRUNGGIANDTO tg = new SANBAYTRUNGGIANDTO();
                tg.MASANBAYTRUNGGIAN = txtMaSanBayTrungGian.Text;
                tg.MACHUYENBAY = cbChuyenBay.Text;
                tg.MASANBAY = cbMasanBay.SelectedValue.ToString();
                tg.THOIGIANDUNG = txtthoigian.Text;
                SANBAYTRUNGGIANDAO.Capnhat_SANBAYTRUNGGIAN(tg);
            }
            tre.Nodes.Clear();
            LOadtreview(tre);
            listView1.Items.Clear();
            TT_sanbaytrunggian();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            txtMaSanBayTrungGian.Text = listView1.SelectedItems[0].SubItems[0].Text;
            cbMasanBay.Text= listView1.SelectedItems[0].SubItems[1].Text;
             cbChuyenBay.Text= listView1.SelectedItems[0].SubItems[2].Text;
            txtthoigian.Text = listView1.SelectedItems[0].SubItems[3].Text; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tre_AfterSelect(object sender, TreeViewEventArgs e)
        {
         
        }

        private void tre_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void tre_AfterSelect_2(object sender, TreeViewEventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dtnv = new DataTable();
            string mkh;
           
            if (tre.SelectedNode.Parent == null)
            {

            }
            else
            {
                mkh = tre.SelectedNode.Tag.ToString();
                dtnv = SANBAYTRUNGGIANDAO.TT_SANBAYTRUNGGIAN_theosanbay(mkh);
                txtMaSanBayTrungGian.Text = dtnv.Rows[0]["MaSanBayTrungGian"].ToString();
                txtthoigian.Text = dtnv.Rows[0]["ThoiGianDung"].ToString();
                cbChuyenBay.Text = dtnv.Rows[0]["MachuyenBay"].ToString();
                cbMasanBay.Text = dtnv.Rows[0]["TenSanBay"].ToString();

            }
        }
    }
}
