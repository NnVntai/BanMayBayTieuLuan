using banvemaybay.BUS;
using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Drawing;

using System.Data;
using System.Windows.Forms;

namespace banvemaybay.GUI
{
    public partial class CHUYENBAY : Form
    {
        public CHUYENBAY()
        {
           
            InitializeComponent();
        }
        public void TT_sanBay()
        {
            DataTable sa = new DataTable();
            sa = SANBAYDAO.TT_SANBAY();
            cbsanbayden.DataSource = sa;
            cbsanbayden.DisplayMember = "TenSanBay";
            cbsanbayden.ValueMember = "MaSanBay";

        }
        public void TT_sanBay2()
        {
            DataTable sa = new DataTable();
            sa = SANBAYDAO.TT_SANBAY();
            cbsanbaydi.DataSource = sa;
            cbsanbaydi.DisplayMember = "TenSanBay";
            cbsanbaydi.ValueMember = "MaSanBay";

        }
        public void TT_lichchuyenbay()
        {
            DataTable sa = new DataTable();
            sa = CHUYENBAYDAO.TT_CHUYENBAY();
            int soluong = sa.Rows.Count;
            for (int i = 0; i < soluong; i++)
            {
                lvchuyenbay.Items.Add(sa.Rows[i]["machuyenbay"].ToString());
                lvchuyenbay.Items[i].SubItems.Add(sa.Rows[i]["Ngaygio"].ToString());
                lvchuyenbay.Items[i].SubItems.Add(sa.Rows[i]["ThoiGian"].ToString());
                lvchuyenbay.Items[i].SubItems.Add(sa.Rows[i]["Gia"].ToString());
                lvchuyenbay.Items[i].SubItems.Add(sa.Rows[i]["TenSanBayDi"].ToString());
                lvchuyenbay.Items[i].SubItems.Add(sa.Rows[i]["TenSanBayDen"].ToString());
            }
        }

        private void CHUYENBAY_Load(object sender, EventArgs e)
        {
       

            TT_lichchuyenbay();
            TT_sanBay();
            TT_sanBay2();
          
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btthem_Click(object sender, EventArgs e)
        {

            DataTable cb = new DataTable();

            cb = CHUYENBAYDAO.TT_chuyenbay_max();

            if (cb.Rows.Count == 0)
            {
                txtmachuyenbay.Text = "CB001";
            }
            else
            {
                string mb = cb.Rows[0][0].ToString();



                txtmachuyenbay.Text = "CB" + (Convert.ToInt32(mb.Substring(mb.Length - 3, 3)) + 1).ToString("000");
                cbsanbayden.Text = "";
                cbsanbaydi.Text = "";

                txtthoigian.Text = "";
                txtgia.Text = "";
            }
        }

        private void btchi_Click(object sender, EventArgs e)
        {
            CHUYENBAYDTO cb = new CHUYENBAYDTO();
            DataTable dt = new DataTable();
            dt = QUYDINHDAO.TT_QUYDINH();
            TimeSpan da = TimeSpan.Parse(dt.Rows[0]["THOIGIANBAYTOITHIEU"].ToString());
            TimeSpan b = TimeSpan.Parse("00:20");
            if (da > b)
            {

                MessageBox.Show("thoi gian bay qua thap so voi quy dinh");
            }
            else
            {
                cb.MachyenBay = txtmachuyenbay.Text;

                string a = dpngaygio.Value.ToString();

                cb.NgayGio = a;
                cb.MASANBAYDEN = cbsanbayden.SelectedValue.ToString();
                cb.MASANBAYDI = cbsanbaydi.SelectedValue.ToString();
                cb.ThoiGian = txtthoigian.Text;
                cb.Gia = txtgia.Text;
                CHUYENBAYBUS.Them_lichCB(cb);
            }
            lvchuyenbay.Items.Clear();
            TT_lichchuyenbay();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            CHUYENBAYDTO cb = new CHUYENBAYDTO();
            cb.MachyenBay = txtmachuyenbay.Text;
            CHUYENBAYBUS.xoa_chuyenbay(cb);
            lvchuyenbay.Items.Clear();
            TT_lichchuyenbay();
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {

            CHUYENBAYDTO cb = new CHUYENBAYDTO();
            DataTable dt = new DataTable();
            dt = QUYDINHDAO.TT_QUYDINH();
            TimeSpan da = TimeSpan.Parse(dt.Rows[0]["THOIGIANBAYTOITHIEU"].ToString());
            TimeSpan b = TimeSpan.Parse("00:20");
            if (da > b)
            {

                MessageBox.Show("thoi gian bay qua thap so voi quy dinh");
            }
            else
            {
                cb.MachyenBay = txtmachuyenbay.Text;

                string a = dpngaygio.Value.ToString();
                cb.NgayGio = a;
                cb.MASANBAYDEN = cbsanbayden.SelectedValue.ToString();
                cb.MASANBAYDI = cbsanbaydi.SelectedValue.ToString();
                cb.ThoiGian = txtthoigian.Text;
                cb.Gia = txtgia.Text;
                CHUYENBAYBUS.capnhat_cb(cb);
            }
            lvchuyenbay.Items.Clear();
            TT_lichchuyenbay();
        }

        private void lvchuyenbay_Click(object sender, EventArgs e)
        {
            txtmachuyenbay.Text = lvchuyenbay.SelectedItems[0].SubItems[0].Text;
            dpngaygio.Text = lvchuyenbay.SelectedItems[0].SubItems[1].Text;
            txtthoigian.Text = lvchuyenbay.SelectedItems[0].SubItems[2].Text;
            txtgia.Text = lvchuyenbay.SelectedItems[0].SubItems[3].Text;
            cbsanbaydi.Text = lvchuyenbay.SelectedItems[0].SubItems[4].Text;
            cbsanbayden.Text = lvchuyenbay.SelectedItems[0].SubItems[5].Text;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dpngaygio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lvchuyenbay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtgia_Leave(object sender, EventArgs e)
        {

            
        }
    }
}
