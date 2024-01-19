using banvemaybay.BUS;
using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace banvemaybay.GUI
{
    public partial class MUAVECHUYENBAY : Form
    {
        string ssdt;
        string tten;
        string mmkh;

        public MUAVECHUYENBAY(string ten, string makh, string sdt)
        {
            InitializeComponent();
            tten = ten;
            ssdt = sdt;
            mmkh = makh;
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
                listView1.Items[i].SubItems.Add(CB.Rows[i]["TenSanBaydi"].ToString());
                listView1.Items[i].SubItems.Add(CB.Rows[i]["TenSanBayDen"].ToString());
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
        public void TT_ve()
        {
            DataTable dt = new DataTable();
            dt = VECHUYENBAYDAO.tt_hiemthivemua(mmkh);
        
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listView2.Items.Add(dt.Rows[i]["MaVechuyenbay"].ToString());
                listView2.Items[i].SubItems.Add(dt.Rows[i]["MachuyenBay"].ToString());
                listView2.Items[i].SubItems.Add(dt.Rows[i]["TenHangVe"].ToString());
               
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
        private void MUAVECHUYENBAY_Load(object sender, EventArgs e)
        {

            TT_ve();
            TT_chuyenbay();
            TT_HANGVE();
            TT_CHUYENBAYCHITIET();
            lahiemthiten.Text = tten;
          
      
        }

        private void BTTHEM_Click(object sender, EventArgs e)
        {

            DataTable max = new DataTable();

            max = DATVEDAO.MAPHIEUDATCHOVeMax();
            if (max.Rows.Count == 0)
            { txmadatve.Text = "VE001"; }
            else
            {
                string maxx = max.Rows[0][0].ToString();

                txmadatve.Text = "VE" + (Convert.ToInt32(maxx.Substring(maxx.Length - 3, 3)) + 1).ToString("000");
                cbchuyenbay.Text = "";
                cbhangve.Text = "";

            }
        }

        private void BTGHI_Click(object sender, EventArgs e)
        {

                             VECHUYENBAYDTO dt = new VECHUYENBAYDTO();
                            dt.machuyenbay = cbchuyenbay.Text;
                            dt.mavechuyenbay = txmadatve.Text;
                            dt.MahangVe = cbhangve.SelectedValue.ToString();


                            dt.MAHK = mmkh;
                            VECHUYENBAYBUS.Them_DATCHO(dt);
                           
                          
                           
                  

           
        }

        private void BTCAPNHAT_Click(object sender, EventArgs e)
        {

            VECHUYENBAYDTO dt = new VECHUYENBAYDTO();
            dt.machuyenbay = cbchuyenbay.Text;
            dt.mavechuyenbay = txmadatve.Text;
            dt.MahangVe = cbhangve.SelectedValue.ToString();


            dt.MAHK = mmkh;
            VECHUYENBAYBUS.CapNhat_DATCHO(dt);
            
            
           
        }

        private void BTHUY_Click(object sender, EventArgs e)
        {

            VECHUYENBAYDTO dt = new VECHUYENBAYDTO();
            dt.machuyenbay = cbchuyenbay.Text;
            dt.mavechuyenbay = txmadatve.Text;
            dt.MahangVe = cbhangve.SelectedValue.ToString();


            dt.MAHK = mmkh;
            VECHUYENBAYBUS.Xoa_DATCHO(dt);
            
        }

        private void BTTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void listView2_Click(object sender, EventArgs e)
        {
        }

        private void cbhangve_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_Click_1(object sender, EventArgs e)
        {
            txmadatve.Text = listView2.SelectedItems[0].SubItems[0].Text;
            cbchuyenbay.Text = listView2.SelectedItems[0].SubItems[1].Text;
            cbhangve.Text = listView2.SelectedItems[0].SubItems[2].Text;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
