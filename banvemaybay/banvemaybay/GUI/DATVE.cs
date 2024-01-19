using banvemaybay.BUS;
using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Data;
using System.Windows.Forms;


namespace banvemaybay.GUI
{
    public partial class DATVE : Form
    {
        public DATVE()
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
            dtnv = DATVEDAO.TT_DATCHOTHEOSDL();
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
                        nodcon.Text = dtnv.Rows[j]["Ten"].ToString();
                        nodcon.Tag = dtnv.Rows[j]["MAPHIEUDATCHO"].ToString();
                        nodcha.Nodes.Add(nodcon);
                    }

                }
            }
        }
        public void TT_chuyenbay()
        {
            DataTable cb = new DataTable();
            cb = CHUYENBAYDAO.TT_CHUYENBAY();
            int sodong = cb.Rows.Count;
            for (int i = 0; i < sodong; i++)
            {
                cbchuyenbay.Items.Add(cb.Rows[i][0].ToString());
            }


        }
        public void TT_DATVE()
        {
            DataTable cb = new DataTable();
            cb = DATVEDAO.TT_DATCHO();
            int sodong = cb.Rows.Count;
            for (int i = 0; i < sodong; i++)
            {
                listView1.Items.Add(cb.Rows[i]["MaPhieuDatcho"].ToString());
                listView1.Items[i].SubItems.Add(cb.Rows[i]["Machuyenbay"].ToString());
                listView1.Items[i].SubItems.Add(cb.Rows[i]["Ten"].ToString());
                listView1.Items[i].SubItems.Add(cb.Rows[i]["TenHangve"].ToString());
                listView1.Items[i].SubItems.Add(cb.Rows[i]["NgayDat"].ToString());
            }


        }
        public void TT_HANGVE()
        {
            DataTable cb = new DataTable();
            cb = HANGVEDAO.TTHANGVE();
            cbhangve.DataSource = cb;
            cbhangve.DisplayMember = "TenHangve";
            cbhangve.ValueMember = "MaHangVe";
        }
        public void TT_SDT()
        {
            DataTable cb = new DataTable();
            cb = USERDAO.TT_USER();
            cbsodienthoat.DataSource = cb;
            cbsodienthoat.DisplayMember = "Ten";
            cbsodienthoat.ValueMember = "MAHK";
        }
        private void DATVE_Load(object sender, EventArgs e)
        {
            TT_HANGVE();
            TT_chuyenbay();
            TT_SDT();
            TT_DATVE();
            LOadtreview(tre);
        }

        private void btthem_Click(object sender, EventArgs e)
        {

            DataTable max = new DataTable();


            max = DATVEDAO.MAPHIEUDATCHOVeMax();
            if (max.Rows.Count == 0)
            { textBox1.Text = "DC001"; }
            else
            {
                string maxx = max.Rows[0][0].ToString();

                textBox1.Text = "DC" + (Convert.ToInt32(maxx.Substring(maxx.Length - 3, 3)) + 1).ToString("000");
                cbchuyenbay.Text = "";
                cbhangve.Text = "";
                cbsodienthoat.Text = "";
            }
        }

        private void btghi_Click(object sender, EventArgs e)
        {
            DATCHODDTO dt = new DATCHODDTO();
            dt.MachyenBay = cbchuyenbay.Text;
            dt.MaPhieuDatCho = textBox1.Text;
            dt.MahangVE = cbhangve.SelectedValue.ToString();
            string a = dateTimePicker1.Value.ToString();
            dt.NgayDat = a;
            dt.MAHK = cbsodienthoat.SelectedValue.ToString();
            DATCHOBUS.Them_DATCHO(dt);
            listView1.Items.Clear();
            tre.Nodes.Clear();
            LOadtreview(tre);
            TT_DATVE();

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DATCHODDTO dt = new DATCHODDTO();
            dt.MachyenBay = cbchuyenbay.Text;
            dt.MaPhieuDatCho = textBox1.Text;
            dt.MahangVE = cbhangve.SelectedValue.ToString();
            string a = dateTimePicker1.Value.ToString();
            dt.NgayDat = a;
            dt.MAHK = cbsodienthoat.SelectedValue.ToString();
            DATCHOBUS.Xoa_DATCHO(dt);
            listView1.Items.Clear();
            tre.Nodes.Clear();
            LOadtreview(tre);
            TT_DATVE();

        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            DATCHODDTO dt = new DATCHODDTO();
            dt.MachyenBay = cbchuyenbay.Text;
            dt.MaPhieuDatCho = textBox1.Text;
            dt.MahangVE = cbhangve.SelectedValue.ToString();
            string a = dateTimePicker1.Value.ToString();
            dt.NgayDat = a;
            dt.MAHK = cbsodienthoat.SelectedValue.ToString();
            DATCHOBUS.CapNhat_DATCHO(dt);
            listView1.Items.Clear();
            tre.Nodes.Clear();
            LOadtreview(tre);
            TT_DATVE();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tre_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dtnv = new DataTable();
            string mkh;

            if (tre.SelectedNode.Parent == null)
            {
                dt = DATVEDAO.tt_datVEtheochuyenbay(tre.SelectedNode.Tag.ToString());
                Machuyenbayla.Text = tre.SelectedNode.Tag.ToString();
                dataGridView1.DataSource = dt;

            }
            else
            {
                mkh = tre.SelectedNode.Tag.ToString();
                dtnv = DATVEDAO.tt_datVEchitiet(mkh);
                textBox1.Text = dtnv.Rows[0]["MAPHIEUDATCHO"].ToString();
                cbchuyenbay.Text = dtnv.Rows[0]["MACHUYENBAY"].ToString();
                cbhangve.Text = dtnv.Rows[0]["TenHANGVE"].ToString();
                cbsodienthoat.Text = dtnv.Rows[0]["Ten"].ToString();
                dateTimePicker1.Text = dtnv.Rows[0]["Ngaydat"].ToString();

            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            cbchuyenbay.Text = listView1.SelectedItems[0].SubItems[1].Text;
            cbsodienthoat.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cbhangve.Text = listView1.SelectedItems[0].SubItems[3].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
