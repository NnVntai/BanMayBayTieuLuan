using banvemaybay.BUS;
using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Data;
using System.Windows.Forms;


namespace banvemaybay.GUI
{
    public partial class VAITRO : Form
    {
        public VAITRO()
        {
            InitializeComponent();
        }
        public void TT_VAITRO()
        {
            DataTable dt = new DataTable();
            dt = VAITRODAO.TT_VAITRO();
            int sodong = dt.Rows.Count;
            int i;
            for (i = 0; i < sodong; i++)
            {
                listView1.Items.Add(dt.Rows[i][0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
            }
        }
        private void VAITRO_Load(object sender, EventArgs e)
        {
            TT_VAITRO();
        }

        private void btthem_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            dt = VAITRODAO.VAITROMAX();
            if (dt.Rows.Count == 0)
            { txmavaitro.Text = "VT001"; }
            else
            {
                string mp = dt.Rows[0][0].ToString();

                txmavaitro.Text = "VT" + (Convert.ToInt32(mp.Substring(mp.Length - 3, 3)) + 1).ToString("000");
                txtenvaitro.Text = "";
            }
        }

        private void btghi_Click(object sender, EventArgs e)
        {
            VAITRODTO hv = new VAITRODTO();

            hv.MaVaiTro = txmavaitro.Text;
            hv.TenVaiTro = txtenvaitro.Text;

            VAITROBUS.Them_VT(hv);
            listView1.Items.Clear();
            TT_VAITRO();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            VAITRODTO hv = new VAITRODTO();

            hv.MaVaiTro = txmavaitro.Text;


            VAITROBUS.Xoa_VT(hv);
            listView1.Items.Clear();
            TT_VAITRO();
        }

        private void bbtcapnhat_Click(object sender, EventArgs e)
        {
            VAITRODTO hv = new VAITRODTO();

            hv.MaVaiTro = txmavaitro.Text;
            hv.TenVaiTro = txtenvaitro.Text;

            VAITROBUS.CapNhat_VAITRO(hv);
            listView1.Items.Clear();
            TT_VAITRO();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            txmavaitro.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtenvaitro.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtenvaitro_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
