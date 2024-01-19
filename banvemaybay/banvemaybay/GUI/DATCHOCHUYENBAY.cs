using banvemaybay.BUS;
using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace banvemaybay.GUI
{
    public partial class DATCHOCHUYENBAY : Form
    {
        string ssdt;
        string tten;
        string mmahk;

        public DATCHOCHUYENBAY(string ten, string makh, string sdt)
        {
            InitializeComponent();
            ssdt = sdt;
            tten = ten;
            mmahk = makh;

        }

        
        public void TT_vedat()

        {
            DataTable CB = new DataTable();
            CB = DATVEDAO.tt_HIEMTHIQUAUSER(mmahk);
            int sodong = CB.Rows.Count;
            for (int i = 0; i < sodong; i++)
            {
                listView2.Items.Add(CB.Rows[i]["MAPHIEUDATCHO"].ToString());
                listView2.Items[i].SubItems.Add(CB.Rows[i]["MACHUYENBAY"].ToString());
                listView2.Items[i].SubItems.Add(CB.Rows[i]["TenHANGVE"].ToString());
            }
        }
        public void TT_CHUYENBAYCHITIET()

        {
            DataTable CB = new DataTable();
            CB = CHUYENBAYDAO.TT_CHUYENBAY();
            int sodong = CB.Rows.Count;
            for (int i = 0; i < sodong; i++)
            {
                listView1.Items.Add(CB.Rows[i][0].ToString());
                listView1.Items[i].SubItems.Add(CB.Rows[i][1].ToString());
                listView1.Items[i].SubItems.Add(CB.Rows[i][2].ToString());
                listView1.Items[i].SubItems.Add(CB.Rows[i][3].ToString());
                listView1.Items[i].SubItems.Add(CB.Rows[i]["TenSanbaydi"].ToString());
                listView1.Items[i].SubItems.Add(CB.Rows[i]["Tensanbayden"].ToString());
              
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
        public void TT_HANGVE()
        {
            DataTable cb = new DataTable();
            cb = HANGVEDAO.TTHANGVE();
            cbhangve.DataSource = cb;
            cbhangve.DisplayMember = "TenHANGVE";
            cbhangve.ValueMember = "MaHangVe";
        }
        private void DATCHOCHUYENBAY_Load(object sender, EventArgs e)
        {

      
            TT_chuyenbay();
            TT_HANGVE();
            TT_vedat();
            TT_CHUYENBAYCHITIET();
            lahiemthiten.Text = tten;
        }

        private void BTTHEM_Click(object sender, EventArgs e)
        {

            DataTable max = new DataTable();


            max = DATVEDAO.MAPHIEUDATCHOVeMax();
            if (max.Rows.Count == 0)
            { txmadatve.Text = "DC001"; }
            else
            {
                string maxx = max.Rows[0][0].ToString();

                txmadatve.Text = "DC" + (Convert.ToInt32(maxx.Substring(maxx.Length - 3, 3)) + 1).ToString("000");
                cbchuyenbay.Text = "";
                cbhangve.Text = "";

            }
        }

        private void BTGHI_Click(object sender, EventArgs e)
        {
            DataTable ad = new DataTable();
            ad = CHUYENBAYDAO.TT_TRUQUYDINH(cbchuyenbay.Text);
            string ngayhientai = DateTime.Now.ToString();
            DateTime a = DateTime.Parse(ad.Rows[0][0].ToString());
            if (DateTime.Now < a)
            {
                MessageBox.Show("DA het thoi han dat chuyen bay !!");
            }
            else
            {




                DATCHODDTO dt = new DATCHODDTO();
                dt.MachyenBay = cbchuyenbay.Text;
                dt.MaPhieuDatCho = txmadatve.Text;
                dt.MahangVE = cbhangve.SelectedValue.ToString();

                dt.NgayDat = ngayhientai;
                dt.MAHK = mmahk;
                DATCHOBUS.Them_DATCHO(dt);
                

            }
                listView2.Items.Clear();
                TT_vedat();
             

        }

        private void BTCAPNHAT_Click(object sender, EventArgs e)
        {
            DATCHODDTO dt = new DATCHODDTO();
            dt.MachyenBay = cbchuyenbay.Text;
            dt.MaPhieuDatCho = txmadatve.Text;
            dt.MahangVE = cbhangve.SelectedValue.ToString();
            string a = DateTime.Now.ToString();
            dt.NgayDat = a;
            dt.MAHK = mmahk;
            DATCHOBUS.CapNhat_DATCHO(dt);
            listView2.Items.Clear();
            TT_vedat();
            
        }

        private void BTHUY_Click(object sender, EventArgs e)
        {
            DATCHODDTO dt = new DATCHODDTO();
            DataTable ad = new DataTable();
            DataTable PD = new DataTable();
            PD = DATVEDAO.tt_DATCHO_QUYDINH(txmadatve.Text);
            DateTime ngayd = DateTime.Parse(DateTime.Now.ToString());

            ad = QUYDINHDAO.TT_QUYDINH();
            TimeSpan da = TimeSpan.Parse(ad.Rows[0]["THOIGIANCHAMNHATHUYVE"].ToString());
            DateTime b = DateTime.Parse(PD.Rows[0][0].ToString());
            DateTime s = b - da;
            if (ngayd > s)
            {
                MessageBox.Show("da qua thoi gian huy ve");
            }
            else
            {


                dt.MachyenBay = cbchuyenbay.Text;
                dt.MaPhieuDatCho = txmadatve.Text;
                dt.MahangVE = cbhangve.SelectedValue.ToString();
                string a = DateTime.Now.ToString();
                dt.NgayDat = a;
                dt.MAHK = mmahk;
                DATCHOBUS.Xoa_DATCHO(dt);
            }
            listView2.Items.Clear();
            TT_vedat();
           
        }

        private void BTTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbchuyenbay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DataTable dt = new DataTable();
            string a = listView1.SelectedItems[0].SubItems[0].Text;
            DT = SANBAYTRUNGGIANDAO.TT_sanbayTG(a);
            dataGridView1.DataSource = DT;
            dt = HANGVEDAO.TTHANGVEchitietCHUYENBAY(a);
            dataGridView2.DataSource = dt;
            cbchuyenbay.Text = a;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView2_Click(object sender, EventArgs e)
        {
            txmadatve.Text = listView2.SelectedItems[0].SubItems[0].Text;
            cbchuyenbay.Text = listView2.SelectedItems[0].SubItems[1].Text;
            cbhangve.Text = listView2.SelectedItems[0].SubItems[2].Text;
        }
    }
}
