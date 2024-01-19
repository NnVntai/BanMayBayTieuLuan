using banvemaybay.BUS;
using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace banvemaybay.GUI
{
    public partial class VECHUYENBAY : Form
    {
        public VECHUYENBAY()
        {
            InitializeComponent();
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
        public void TT_chuyenbaylis()
        {
            DataTable dt = new DataTable();
            dt = CHUYENBAYDAO.TT_CHUYENBAY();
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "";
            listBox1.ValueMember = "MaChuyenbay";
        }
        public void TT_DATVE()
        {
            listView1.Items.Clear();
            DataTable cb = new DataTable();
            cb = VECHUYENBAYDAO.TT_VE();
            int sodong = cb.Rows.Count;
            for (int i = 0; i < sodong; i++)
            {
                listView1.Items.Add(cb.Rows[i]["mavechuyenbay"].ToString());
                listView1.Items[i].SubItems.Add(cb.Rows[i]["machuyenbay"].ToString());
                listView1.Items[i].SubItems.Add(cb.Rows[i]["Ten"].ToString());
                listView1.Items[i].SubItems.Add(cb.Rows[i]["TenhangVE"].ToString());

            }


        }
        public void TT_HANGVE()
        {
            DataTable cb = new DataTable();
            cb = HANGVEDAO.TTHANGVE();
            cbhangve.DataSource = cb;
            cbhangve.DisplayMember = "TenHANGVE";
            cbhangve.ValueMember = "MaHangVe";
        }
        public void TT_SDT()
        {
            DataTable cb = new DataTable();
            cb = USERDAO.TT_USER();
            CBKH.DataSource = cb;
            CBKH.DisplayMember = "TEN";
            CBKH.ValueMember = "MAHK";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VECHUYENBAY_Load(object sender, EventArgs e)
        {
            TT_chuyenbaylis();
            TT_HANGVE();
            TT_chuyenbay();
            TT_SDT();
            TT_DATVE();
           
        }

        private void BTTHEM_Click(object sender, EventArgs e)
        {

            DataTable max = new DataTable();


            max = VECHUYENBAYDAO.MAVEVeMax();
            if (max.Rows.Count == 0)
            { txmachuyenbay.Text = "VE001"; }
            else
            {
                string maxx = max.Rows[0][0].ToString();


                txmachuyenbay.Text = "VE" + (Convert.ToInt32(maxx.Substring(maxx.Length - 3, 3)) + 1).ToString("000");
                cbchuyenbay.Text = "";
                cbhangve.Text = "";
                CBKH.Text = "";
            }
        }

        private void BTGHI_Click(object sender, EventArgs e)
        {
            VECHUYENBAYDTO dt = new VECHUYENBAYDTO();
            dt.machuyenbay = cbchuyenbay.Text;
            dt.mavechuyenbay = txmachuyenbay.Text;
            dt.MahangVe = cbhangve.SelectedValue.ToString();

            dt.MAHK = CBKH.SelectedValue.ToString();
            VECHUYENBAYBUS.Them_DATCHO(dt);
            listView1.Items.Clear();
          
            TT_DATVE();
        }

        private void BTXOA_Click(object sender, EventArgs e)
        {
            VECHUYENBAYDTO dt = new VECHUYENBAYDTO();
            dt.machuyenbay = cbchuyenbay.Text;
            dt.mavechuyenbay = txmachuyenbay.Text;
            dt.MahangVe = cbhangve.SelectedValue.ToString();

            dt.MAHK = CBKH.SelectedValue.ToString();
            VECHUYENBAYBUS.Xoa_DATCHO(dt);
            listView1.Items.Clear();
            
            TT_DATVE();
        }

        private void BTCAPNHAT_Click(object sender, EventArgs e)
        {
            VECHUYENBAYDTO dt = new VECHUYENBAYDTO();
            dt.machuyenbay = cbchuyenbay.Text;
            dt.mavechuyenbay = txmachuyenbay.Text;
            dt.MahangVe = cbhangve.SelectedValue.ToString();

            dt.MAHK = CBKH.SelectedValue.ToString();
            VECHUYENBAYBUS.CapNhat_DATCHO(dt);
            listView1.Items.Clear();
           
            TT_DATVE();
        }

        private void BTTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            txmachuyenbay.Text = listView1.SelectedItems[0].SubItems[0].Text;
            cbchuyenbay.Text = listView1.SelectedItems[0].SubItems[1].Text;
            CBKH.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cbhangve.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            DataTable dt = new DataTable();
            dt = VECHUYENBAYDAO.TT_VE_THeochuyenbay(listBox1.SelectedValue.ToString());
            for(int i=0;i<dt.Rows.Count;i++)
            {
                listView1.Items.Add(dt.Rows[i]["Mavechuyenbay"].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i]["Machuyenbay"].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i]["Ten"].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i]["TenHangve"].ToString());
            }
        }
    }
}
