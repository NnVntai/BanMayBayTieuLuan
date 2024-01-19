using banvemaybay.BUS;
using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace banvemaybay.GUI
{
    public partial class SANBAY : Form
    {
        public SANBAY()
        {
            InitializeComponent();
        }
        public void TT_SANBAY()
        {
            DataTable sa = new DataTable();
            sa = SANBAYDAO.TT_SANBAY();
            int sodong = sa.Rows.Count;
            for (int i = 0; i < sodong; i++)
            {
                listView1.Items.Add(sa.Rows[i][0].ToString());
                listView1.Items[i].SubItems.Add(sa.Rows[i][1].ToString());
            }


        }
        private void SANBAY_Load(object sender, EventArgs e)
        {
            TT_SANBAY();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            txMaSanBay.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txTenSanBay.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();


            dt = SANBAYDAO.max_sanbay();
            if (dt.Rows.Count == 0)

            { txMaSanBay.Text = "SA001"; }
            else
            {


                string mp = dt.Rows[0][0].ToString();

                { txMaSanBay.Text = "SA" + (Convert.ToInt32(mp.Substring(mp.Length - 3, 3)) + 1).ToString("000"); }
                txTenSanBay.Text = "";
            }
        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            DataTable sac = new DataTable();
            sac = SANBAYDAO.TT_SANBAY();
            int sosanbay = sac.Rows.Count;
            DataTable dt = new DataTable();
            dt = QUYDINHDAO.TT_QUYDINH();
            int quydinh = Convert.ToInt32(dt.Rows[0]["SOLUONGSANBAY"].ToString());

            if (sosanbay > quydinh)
            {
                MessageBox.Show("Không thể thêm sân bay số lượng đã đạt giới hạng ");
            }
            else
            {
                SANBAYDTO sa = new SANBAYDTO();
                sa.MASANBAY = txMaSanBay.Text;
                sa.TENSANBAY = txTenSanBay.Text;
                SANBAYBUS.Them_SanBay(sa);
                listView1.Items.Clear();
                TT_SANBAY();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            SANBAYDTO sa = new SANBAYDTO();
            sa.MASANBAY = txMaSanBay.Text;
            SANBAYBUS.Xoa_SANBAY(sa);
            listView1.Items.Clear();
            TT_SANBAY();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            SANBAYDTO sa = new SANBAYDTO();
            sa.MASANBAY = txMaSanBay.Text;
            sa.TENSANBAY = txTenSanBay.Text;
            SANBAYBUS.Capnhat_SanBay(sa);
            listView1.Items.Clear();
            TT_SANBAY();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
