using banvemaybay.BUS;
using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace banvemaybay.GUI
{
    public partial class HANGVE : Form
    {
        public HANGVE()
        {
            InitializeComponent();
        }
        public void TT_HANGVE()
        {
            DataTable dt = new DataTable();
            dt = HANGVEDAO.TTHANGVE();
            int sodong = dt.Rows.Count;
            int i;
            for (i = 0; i < sodong; i++)
            {
                lvhangve.Items.Add(dt.Rows[i][0].ToString());
                lvhangve.Items[i].SubItems.Add(dt.Rows[i][1].ToString());

            }
        }
        private void HANGVE_Load(object sender, EventArgs e)
        {
            TT_HANGVE();
        }

        private void btthem_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            dt = HANGVEDAO.MaHangVeMax();
            if (dt.Rows.Count == 0)
            { txtma.Text = "HV001"; }
            else
            {
                string mp = dt.Rows[0][0].ToString();

                txtma.Text = "HV" + (Convert.ToInt32(mp.Substring(mp.Length - 3, 3)) + 1).ToString("000");
                txtten.Text = "";
            }
        }

        private void btghi_Click(object sender, EventArgs e)
        {
            HANGVEDTO hv = new HANGVEDTO();
            hv.mahangve = txtma.Text;
            hv.tenhangve = txtten.Text;

            HANGVEBUS.Them_Hang_Ve(hv);
            lvhangve.Items.Clear();
            TT_HANGVE();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            //nut xoa hang ve//
            HANGVEDTO hv = new HANGVEDTO();
            hv.mahangve = txtma.Text;
            HANGVEBUS.Xoa_Hang_Ve(hv);
            lvhangve.Items.Clear();
            TT_HANGVE();
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            HANGVEDTO hv = new HANGVEDTO();
            hv.mahangve = txtma.Text;
            hv.tenhangve = txtten.Text;

            HANGVEBUS.CapNhat_HANGVE(hv);
            lvhangve.Items.Clear();
            TT_HANGVE();

        }

        private void lvhangve_Click(object sender, EventArgs e)
        {
            txtma.Text = lvhangve.SelectedItems[0].SubItems[0].Text;
            txtten.Text = lvhangve.SelectedItems[0].SubItems[1].Text;
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
