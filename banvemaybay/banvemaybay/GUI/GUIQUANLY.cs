using banvemaybay.DAO;
using banvemaybay.GUIRP;
using System;
using System.Data;
using System.Windows.Forms;
namespace banvemaybay.GUI
{
    public partial class GUIQUANLY : Form
    {
        public GUIQUANLY(string sdt)
        {
            InitializeComponent();
            label2.Text = sdt;
        }

        public void thang()
        {
            for (int i = 1; i <= 12; i++)
            {
                cbthang.Items.Add(i);
            }
        }

        public void nam()
        {
            DataTable dt = new DataTable();
            dt = CHUYENBAYDAO.NAM();
            int soluong = dt.Rows.Count;
            for (int i = 0; i < soluong; i++)
            {
                cbnam.Items.Add(dt.Rows[0][0].ToString());
            }
        }
        private void GUIQUANLY_Load(object sender, EventArgs e)
        {
            thang();
            cbnam.Items.Clear();
            nam();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LOGIN n = new LOGIN();
            n.Show();
            this.Hide();
        }

        private void qUANLYCHUYENBAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QUYDINH f = new QUYDINH();
            f.ShowDialog();
        }

        private void qUANLYSANBAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void qUANLYUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void qUANLYHANGVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void qUANLYDATVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void qUANLYVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void qUANLYSOGHEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void qUANLYSANBAYTRUNGGIANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void qUANLYVAITROToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DANHTHUTHEOTHANG dt = new DANHTHUTHEOTHANG(Convert.ToInt32(cbthang.Text));
            dt.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BAOCAOTHEONAM dt = new BAOCAOTHEONAM(Convert.ToInt32(cbnam.Text));
            dt.ShowDialog();
        }

        private void cbthang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            QUYDINH f = new QUYDINH();
            f.ShowDialog();
        }

        private void quảnLýVéChuyếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VECHUYENBAY F = new VECHUYENBAY();
            F.ShowDialog();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHUYENBAY f = new CHUYENBAY();
            f.ShowDialog();
        }

        private void quảnLýUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            USER F = new USER();
            F.ShowDialog();

        }

        private void quảnLýHạngVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HANGVE F = new HANGVE();
            F.ShowDialog();
        }

        private void quảnLýĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DATVE F = new DATVE();
            F.ShowDialog();
        }

        private void quảnLýSốGhếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QUANLYSOGHE F = new QUANLYSOGHE();
            F.ShowDialog();
        }

        private void quảnLýSânBayTrungGiangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SANBAYTRUNGGIAN F = new SANBAYTRUNGGIAN();
            F.ShowDialog();
        }

        private void quảnLýVaiTròToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VAITRO F = new VAITRO();
            F.ShowDialog();
        }

        private void quảnLýSânBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SANBAY F = new SANBAY();
            F.ShowDialog();
        }

        private void cbnam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
